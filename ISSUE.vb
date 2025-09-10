Imports System.Data.SqlClient

Public Class ISSUE
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True")
    Dim initialissuedate As Date
    Dim previousBookId As String = ""

        Private Sub Issueform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                LoadStudentIDs()
                LoadBookIDs()
                LoadIssuedBooks()
                GenerateIssueID()
                ClearForm()
            Catch ex As Exception
                MsgBox("Error loading form: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        ' Generate next Issue ID
        Private Sub GenerateIssueID()
            Try
                Dim cmd As New SqlCommand("SELECT TOP 1 IssueId FROM issuetable ORDER BY IssueId DESC", con)
                con.Open()
                Dim lastId As Object = cmd.ExecuteScalar()
                con.Close()

                If lastId IsNot Nothing Then
                    Dim num As Integer = Convert.ToInt32(lastId.ToString().Substring(1)) + 1
                    txtIssueId.Text = "I" & num.ToString()
                Else
                    txtIssueId.Text = "I101"
                End If
            Catch ex As Exception
                MsgBox("Error generating Issue ID: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
            End Try
        End Sub

        ' Load Student IDs into ComboBox
        Private Sub LoadStudentIDs()
            Try
                Dim cmd As New SqlCommand("SELECT StudentId, StudentName FROM studenttable", con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbsid.DataSource = dt
                cmbsid.DisplayMember = "StudentId"
            Catch ex As Exception
                MsgBox("Error loading Student IDs: " & ex.Message, MsgBoxStyle.Critical)
            End Try
    End Sub
    Private Sub LoadIssuedBooks()
        Dim cmd As New SqlCommand("SELECT * FROM issuetable", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        datagridissue.DataSource = dt
    End Sub


        ' Fetch Student Name on Student ID selection
        Private Sub cmbsid_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbsid.SelectedIndexChanged
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()
            Dim cmd As New SqlCommand("SELECT StudentName FROM studenttable WHERE StudentId = @tStudentId", con)
            cmd.Parameters.AddWithValue("@tStudentId", cmbsid.Text)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                labelsname.Text = reader("StudentName").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error fetching Student Name: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        End Sub

        ' Load Book IDs into ComboBox
        Private Sub LoadBookIDs()
            Try
                Dim cmd As New SqlCommand("SELECT BookId, BookName, Edition, Quantity FROM booktable WHERE Quantity > 0", con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbbid.DataSource = dt
                cmbbid.DisplayMember = "BookId"
            Catch ex As Exception
                MsgBox("Error loading Book IDs: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        ' Fetch Book Details on Book ID selection
        Private Sub cmbbid_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbbid.SelectedIndexChanged
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()
            Dim cmd As New SqlCommand("SELECT BookName, Edition, Quantity FROM booktable WHERE BookId = @tBookId", con)
            cmd.Parameters.AddWithValue("@tBookId", cmbbid.Text)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                labelbname.Text = reader("BookName").ToString()
                labeledition.Text = reader("Edition").ToString()
                labelquantity.Text = reader("Quantity").ToString()
            End If

            reader.Close()

        Catch ex As Exception
            MsgBox("Error fetching Book Details: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        End Sub

        ' Validate fields before performing operations
        Private Function ValidateFields() As Boolean
            If String.IsNullOrEmpty(txtIssueId.Text) OrElse
               String.IsNullOrEmpty(cmbsid.Text) OrElse
               String.IsNullOrEmpty(cmbbid.Text) Then
                lblError.Text = "All fields must be filled!"
                lblError.ForeColor = Color.Red
                Return False
            End If

            lblError.Text = ""
            Return True
        End Function

        ' Save Issue Record
        Private Sub btnsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsave.Click
        If Not ValidateFields() Then Exit Sub

        ' Check if the book is available
        If Val(labelquantity.Text) = 0 Then
            MsgBox("This book is not available.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

            ' Check student issue limit
            Dim issuedCount As Integer
        Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM issuetable WHERE StudentId = @tStudentId", con)
        cmdCheck.Parameters.AddWithValue("@tStudentId", cmbsid.Text)
            con.Open()
            issuedCount = cmdCheck.ExecuteScalar()
            con.Close()

            If issuedCount >= 2 Then
                MsgBox("A student can only issue 2 books.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Insert issue record and decrement book quantity
            Try
            Dim cmdInsert As New SqlCommand("INSERT INTO issuetable (IssueId, StudentId, StudentName, BookId, BookName, Edition,Quantity, IssueDate) VALUES (@tIssueId, @tStudentId, @tStudentName, @tBookId, @tBookName, @tEdition,@tQuantity, @tIssueDate)", con)
            cmdInsert.Parameters.AddWithValue("@tIssueId", txtissueid.Text)
            cmdInsert.Parameters.AddWithValue("@tStudentId", cmbsid.Text)
            cmdInsert.Parameters.AddWithValue("@tStudentName", labelsname.Text)
            cmdInsert.Parameters.AddWithValue("@tBookId", cmbbid.Text)
            cmdInsert.Parameters.AddWithValue("@tBookName", labelbname.Text)
            cmdInsert.Parameters.AddWithValue("@tEdition", labeledition.Text)
            cmdInsert.Parameters.AddWithValue("@tQuantity", labelquantity.Text)

            cmdInsert.Parameters.AddWithValue("@tIssueDate", issuedtp.Value)

            Dim cmdUpdate As New SqlCommand("UPDATE booktable SET Quantity = Quantity - 1 WHERE BookId = @tBookId AND Quantity > 0", con)
            cmdUpdate.Parameters.AddWithValue("@tBookId", cmbbid.Text)

                con.Open()
                cmdInsert.ExecuteNonQuery()
                cmdUpdate.ExecuteNonQuery()
                con.Close()

                MsgBox("Book issued successfully.", MsgBoxStyle.Information)
                GenerateIssueID()
                LoadIssuedBooks()
                ClearForm()
            Catch ex As Exception
                MsgBox("Error issuing book: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
            End Try
        End Sub

        ' Delete Issue Record
        Private Sub btndelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btndelete.Click
            If Not ValidateFields() Then Exit Sub

            Try
            Dim cmdDelete As New SqlCommand("DELETE FROM issuetable WHERE IssueId = @tIssueId", con)
            cmdDelete.Parameters.AddWithValue("@tIssueId", txtissueid.Text)

            Dim cmdUpdate As New SqlCommand("UPDATE booktable SET Quantity = Quantity + 1 WHERE BookId = @tBookId", con)
            cmdUpdate.Parameters.AddWithValue("@tBookId", cmbbid.Text)

                con.Open()
                cmdDelete.ExecuteNonQuery()
                cmdUpdate.ExecuteNonQuery()
                con.Close()

                MsgBox("Issue record deleted successfully", MsgBoxStyle.Information)
                GenerateIssueID()
                LoadIssuedBooks()
                ClearForm()
            Catch ex As Exception
                MsgBox("Error deleting record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
            End Try
        End Sub

        ' Clear form fields
        Private Sub ClearForm()

            cmbsid.SelectedIndex = -1
            cmbbid.SelectedIndex = -1
            labelsname.Text = ""
            labelbname.Text = ""
            labeledition.Text = ""
            labelquantity.Text = ""
        End Sub

    Private Sub txtissueid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtissueid.TextChanged
        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True")

        If String.IsNullOrWhiteSpace(txtissueid.Text) Then Exit Sub
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM issuetable WHERE IssueId = @tIssueId", con)
            cmd.Parameters.AddWithValue("@tIssueId", txtissueid.Text)


            Using reader As SqlDataReader = cmd.ExecuteReader()


                If reader.HasRows Then
                    reader.Read()

                    cmbsid.Text = If(IsDBNull(reader("StudentId")), "", reader("StudentId").ToString())
                    labelsname.Text = If(IsDBNull(reader("StudentName")), "", reader("StudentName").ToString())
                    cmbbid.Text = If(IsDBNull(reader("BookId")), "", reader("BookId").ToString())
                    labelbname.Text = If(IsDBNull(reader("BookName")), "", reader("BookName").ToString())
                    labeledition.Text = If(IsDBNull(reader("Edition")), "", reader("Edition").ToString())
                    labelquantity.Text = If(IsDBNull(reader("Quantity")), "", reader("Quantity").ToString())


                    If Not IsDBNull(reader("IssueDate")) Then
                        issuedtp.Value = Convert.ToDateTime(reader("IssueDate"))
                    Else
                        issuedtp.Value = DateTime.Now
                    End If

                Else
                    cmbsid.Text = ""
                    cmbbid.Text = ""
                    labelsname.Text = ""
                    labelbname.Text = ""
                    labeledition.Text = ""
                    labelquantity.Text = ""
                    issuedtp.Value = DateTime.Now
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error fetching record: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        '1. Validate form fields
        If Not ValidateFields() Then Exit Sub

        Try
            ' 2. Retrieve the old BookId from the existing issue record
            Dim oldBookId As String = ""
            Dim cmdGetOldBook As New SqlCommand("SELECT BookId FROM issuetable WHERE IssueId = @tIssueId", con)
            cmdGetOldBook.Parameters.AddWithValue("@tIssueId", txtissueid.Text)

            con.Open()
            Dim oldBookObj As Object = cmdGetOldBook.ExecuteScalar()
            con.Close()

            If oldBookObj Is Nothing Then
                MsgBox("No existing record found for this Issue ID.", MsgBoxStyle.Exclamation)
                Return
            End If

            oldBookId = oldBookObj.ToString()

            ' 3. Start a transaction to ensure all changes succeed or fail together
            con.Open()
            Dim transaction As SqlTransaction = con.BeginTransaction()

            Try
                ' 4. If the new BookId differs from the old BookId, restore and decrement quantities
                If Not oldBookId.Equals(cmbbid.Text, StringComparison.OrdinalIgnoreCase) Then
                    ' Increase old book quantity by 1
                    Dim cmdRestoreOld As New SqlCommand("UPDATE booktable SET Quantity = Quantity + 1 WHERE BookId = @tOldBookId", con, transaction)
                    cmdRestoreOld.Parameters.AddWithValue("@tOldBookId", oldBookId)
                    cmdRestoreOld.ExecuteNonQuery()

                    ' Decrease new book quantity by 1
                    Dim cmdDecrementNew As New SqlCommand("UPDATE booktable SET Quantity = Quantity - 1 WHERE BookId = @tNewBookId AND Quantity > 0", con, transaction)
                    cmdDecrementNew.Parameters.AddWithValue("@tNewBookId", cmbbid.Text)
                    cmdDecrementNew.ExecuteNonQuery()
                End If

                ' 5. Update the issue record itself
                Dim cmdEdit As New SqlCommand("Update issuetable SET StudentId = @tStudentId,StudentName = @tStudentName,BookId = @tBookId,BookName = @tBookName,Edition = @tEdition,Quantity = @tQuantity,IssueDate = @tIssueDate WHERE IssueId = @tIssueId", con, transaction)

                cmdEdit.Parameters.AddWithValue("@tIssueId", txtissueid.Text)
                cmdEdit.Parameters.AddWithValue("@tStudentId", cmbsid.Text)
                cmdEdit.Parameters.AddWithValue("@tStudentName", labelsname.Text)
                cmdEdit.Parameters.AddWithValue("@tBookId", cmbbid.Text)
                cmdEdit.Parameters.AddWithValue("@tBookName", labelbname.Text)
                cmdEdit.Parameters.AddWithValue("@tEdition", labeledition.Text)
                cmdEdit.Parameters.AddWithValue("@tQuantity", labelquantity.Text)
                cmdEdit.Parameters.AddWithValue("@tIssueDate", issuedtp.Value)
                cmdEdit.ExecuteNonQuery()

                ' 6. Commit the transaction
                transaction.Commit()

                MsgBox("Issue record updated successfully!", MsgBoxStyle.Information)

            Catch ex As Exception
                ' Roll back if anything fails
                transaction.Rollback()
                MsgBox("Error updating issue record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
                LoadIssuedBooks()
                ClearForm()
            End Try

        Catch ex As Exception
            ' Catch any errors outside the transaction scope
            con.Close()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datagridissue.CellMouseClick
        Dim row As DataGridViewRow = datagridissue.Rows(e.RowIndex)
        txtissueid.Text = row.Cells(0).Value.ToString
        cmbsid.Text = row.Cells(1).Value.ToString
        labelsname.Text = row.Cells(2).Value.ToString
        cmbbid.Text = row.Cells(3).Value.ToString
        labelbname.Text = row.Cells(4).Value.ToString
        labeledition.Text = row.Cells(5).Value.ToString
        labelquantity.Text = row.Cells(6).Value.ToString
        issuedtp.Value = row.Cells(7).Value

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim login As New LOGIN
        login.Show()
    End Sub
End Class


















