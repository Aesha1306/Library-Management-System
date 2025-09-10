Imports System.Data.SqlClient
Public Class STUDENT
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim s1 As String
    Dim initialbirth As Date
    Dim g1 As Char

    Private Sub STUDENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet1.studenttable' table. You can move, or remove it, as needed.
        Me.StudenttableTableAdapter.Fill(Me.PROJECTWORK06DataSet1.studenttable)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True")
        LoadGrid()
        s1 = "select * from studenttable"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(s1, con)
        DataAdap.Fill(DataTab)
        datagridstudent.DataSource = DataTab
    End Sub
    ' Check if all fields are filled
    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(cmbsid.Text) OrElse
           String.IsNullOrEmpty(txtsname.Text) OrElse
           String.IsNullOrEmpty(cmbyear.SelectedItem) OrElse
           String.IsNullOrEmpty(cmbdepartment.SelectedItem) OrElse
            String.IsNullOrEmpty(cmbcourse.SelectedItem) OrElse
            String.IsNullOrEmpty(cmbsemester.SelectedItem) OrElse
            String.IsNullOrEmpty(txtcontact.Text) Then
            lblError.Text = "All fields must be filled!"
            lblError.ForeColor = Color.Red
            Return False
        End If

        lblError.Text = ""
        Return True
    End Function

    Private Sub LoadGrid()
        s1 = "select * from studenttable"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(s1, con)
        DataAdap.Fill(DataTab)
        datagridstudent.DataSource = DataTab
    End Sub


    Private Sub datagridstudent_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datagridstudent.CellMouseClick
        Dim row As DataGridViewRow = datagridstudent.Rows(e.RowIndex)
        cmbsid.Text = row.Cells(0).Value.ToString
        txtsname.Text = row.Cells(1).Value.ToString
        If row.Cells(2).Value.ToString = "M" Then
            rdomale.Checked = True
        Else
            rdofemale.Checked = True
        End If
        cmbyear.Text = row.Cells(3).Value.ToString
        cmbdepartment.Text = row.Cells(4).Value.ToString
        cmbcourse.Text = row.Cells(5).Value.ToString
        cmbsemester.Text = row.Cells(6).Value.ToString
        birthdtp.Value = row.Cells(7).Value.ToString
        txtcontact.Text = row.Cells(8).Value.ToString
    End Sub
    ' Reset Form Fields
    Private Sub ResetForm()
        cmbsid.Text = ""
        txtsname.Text = ""
        cmbyear.Text = ""
        cmbdepartment.Text = ""
        cmbcourse.Text = ""
        cmbsemester.Text = ""
        txtcontact.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim loginform As New LOGIN
        loginform.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Not ValidateFields() Then Exit Sub
        If birthdtp.Value = initialbirth Then
            lblError.Text = "PLEASE SELECT BIRTHDATE!"
            lblError.ForeColor = Color.Red
            Exit Sub
        End If
        If txtcontact.Text.Length < 9 Then
            lblError.Text = "NUMBER MUST BE EXACTLY 10 DIGIT"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
        Try
            con.Open()
            s1 = "insert into studenttable values(@tStudentId,@tStudentName,@tGender,@tAcademicYear,@tDepartment,@tCourse,@tSemester,@tBirth,@tContact)"

            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tStudentId", Me.cmbsid.SelectedItem)
            cmd.Parameters.AddWithValue("@tStudentName", Me.txtsname.Text)

            If Me.rdomale.Checked = True Then
                g1 = "M"
            Else
                g1 = "F"
            End If

            cmd.Parameters.AddWithValue("@tGender", g1)
            cmd.Parameters.AddWithValue("@tAcademicYear", Me.cmbyear.SelectedItem)
            cmd.Parameters.AddWithValue("@tDepartment", Me.cmbdepartment.SelectedItem)
            cmd.Parameters.AddWithValue("@tCourse", Me.cmbcourse.SelectedItem)
            cmd.Parameters.AddWithValue("@tSemester", Me.cmbsemester.SelectedItem)
            cmd.Parameters.AddWithValue("@tBirth", Me.birthdtp.Value)
            cmd.Parameters.AddWithValue("@tContact", Me.txtcontact.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Record is inserted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            LoadGrid()
            ResetForm()
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If Not ValidateFields() Then Exit Sub
        Try
            con.Open()
            s1 = "update studenttable set StudentId=@tStudentId,StudentName=@tStudentName,Gender=@tGender,AcademicYear=@tAcademicYear,Department=@tDepartment,Course=@tCourse,Semester=@tSemester,Birth=@tBirth,Contact=@tContact where StudentId=@tStudentId"

            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tStudentId", Me.cmbsid.SelectedItem)
            cmd.Parameters.AddWithValue("@tStudentName", Me.txtsname.Text)
            If Me.rdomale.Checked = True Then
                g1 = "M"
            Else
                g1 = "F"
            End If

            cmd.Parameters.AddWithValue("@tGender", g1)
            cmd.Parameters.AddWithValue("@tAcademicYear", Me.cmbyear.SelectedItem)
            cmd.Parameters.AddWithValue("@tDepartment", Me.cmbdepartment.SelectedItem)
            cmd.Parameters.AddWithValue("@tCourse", Me.cmbcourse.SelectedItem)
            cmd.Parameters.AddWithValue("@tSemester", Me.cmbsemester.SelectedItem)
            cmd.Parameters.AddWithValue("@tBirth", Me.birthdtp.Value)
            cmd.Parameters.AddWithValue("@tContact", Me.txtcontact.Text)


            cmd.ExecuteNonQuery()
            MsgBox("record is Edited")
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            LoadGrid()
            ResetForm()
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            con.Open()

            s1 = "delete from studenttable where StudentId=@tStudentId"
            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tStudentId", Me.cmbsid.SelectedItem)
            cmd.ExecuteNonQuery()
            MsgBox("record is Deleted")
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            LoadGrid()
            ResetForm()
        End Try
    End Sub

    Private Sub btnreset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        ResetForm()
    End Sub


    Private Sub txtsname_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "NAME FIELD ALLOWS ONLY LETTERS"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtcontact_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "CONTACT FIELD ALLOWS ONLY NUMBERS"
            lblError.ForeColor = Color.Red
        End If

        If txtcontact.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If

        If txtcontact.Text.Length < 9 Then
            lblError.Text = "NUMBER MUST BE EXACTLY 10 DIGIT"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""

        End If
    End Sub
End Class



