Imports System.Data.SqlClient
Public Class BOOK
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim s1 As String

    Private Sub BOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet2.booktable' table. You can move, or remove it, as needed.
        Me.BooktableTableAdapter.Fill(Me.PROJECTWORK06DataSet2.booktable)
        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True"
        LoadGrid()
        s1 = "select * from booktable"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(s1, con)
        DataAdap.Fill(DataTab)
        griddatabook.DataSource = DataTab
    End Sub
    Private Sub LoadGrid()
        s1 = "select * from booktable"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(s1, con)
        DataAdap.Fill(DataTab)
        griddatabook.DataSource = DataTab
    End Sub

    ' Check if all fields are filled
    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(cmbbid.Text) OrElse
           String.IsNullOrEmpty(txtbname.Text) OrElse
            String.IsNullOrEmpty(cmbbsubject.SelectedItem) OrElse
           String.IsNullOrEmpty(cmbedition.SelectedItem) OrElse
           String.IsNullOrEmpty(txtauthor.Text) OrElse
           String.IsNullOrEmpty(txtpublisher.Text) OrElse
           String.IsNullOrEmpty(txtprice.Text) OrElse
           String.IsNullOrEmpty(txtquantity.Text) Then
            lblError.Text = "All fields must be filled!"
            lblError.ForeColor = Color.Red
            Return False
        End If

        lblError.Text = ""
        Return True
    End Function

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Not ValidateFields() Then Exit Sub
        Try
            con.Open()
            s1 = "insert into booktable values(@tBookId,@tBookName,@tSubject,@tEdition,@tAuthor,@tPublisher,@tPrice,@tQuantity)"

            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tBookId", Me.cmbbid.SelectedItem)
            cmd.Parameters.AddWithValue("@tBookName", Me.txtbname.Text)
            cmd.Parameters.AddWithValue("@tSubject", Me.cmbbsubject.SelectedItem)
            cmd.Parameters.AddWithValue("@tEdition", Me.cmbedition.SelectedItem)
            cmd.Parameters.AddWithValue("@tAuthor", Me.txtauthor.Text)
            cmd.Parameters.AddWithValue("@tPublisher", Me.txtpublisher.Text)
            cmd.Parameters.AddWithValue("@tPrice", Me.txtprice.Text)
            cmd.Parameters.AddWithValue("@tQuantity", Me.txtquantity.Text)

            cmd.ExecuteNonQuery()
            MsgBox("record is inserted")

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
            s1 = "update booktable set BookId=@tBookId,BookName=@tBookName,Subject=@tSubject,Edition=@tEdition,Author=@tAuthor,Publisher=@tPublisher,Price=@tPrice,Quantity=@tQuantity where BookId=@tBookId"
            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tBookid", Me.cmbbid.SelectedItem)
            cmd.Parameters.AddWithValue("@tBookName", Me.txtbname.Text)
            cmd.Parameters.AddWithValue("@tSubject", Me.cmbbsubject.SelectedItem)
            cmd.Parameters.AddWithValue("@tEdition", Me.cmbedition.SelectedItem)
            cmd.Parameters.AddWithValue("@tAuthor", Me.txtauthor.Text)
            cmd.Parameters.AddWithValue("@tPublisher", Me.txtpublisher.Text)
            cmd.Parameters.AddWithValue("@tPrice", Me.txtprice.Text)
            cmd.Parameters.AddWithValue("@tQuantity", Me.txtquantity.Text)

            cmd.ExecuteNonQuery()
            MsgBox("record is Edited")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            LoadGrid()
            ResetForm()
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If Not ValidateFields() Then Exit Sub
        Try
            con.Open()
            s1 = "delete from booktable where BookId=@tBookId"

            cmd = New SqlCommand(s1, con)
            cmd.Parameters.AddWithValue("@tBookid", Me.cmbbid.SelectedItem)
            cmd.Parameters.AddWithValue("@tBookName", Me.txtbname.Text)
            cmd.Parameters.AddWithValue("@tSubject", Me.cmbbsubject.SelectedItem)
            cmd.Parameters.AddWithValue("@tEdition", Me.cmbedition.SelectedItem)
            cmd.Parameters.AddWithValue("@tAuthor", Me.txtauthor.Text)
            cmd.Parameters.AddWithValue("@tPublisher", Me.txtpublisher.Text)
            cmd.Parameters.AddWithValue("@tPrice", Me.txtprice.Text)
            cmd.Parameters.AddWithValue("@tQuantity", Me.txtquantity.Text)

            cmd.ExecuteNonQuery()
            MsgBox("record is Deleted")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            LoadGrid()
            ResetForm()
        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        ResetForm()
    End Sub

    Private Sub txtbname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "BOOK NAME ALLOWS ONLY LETTER!"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtpublisher_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpublisher.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "PUBLISHER NAME ALLOWS ONLY LETTER!"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtauthor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtauthor.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "AUTHOR NAME ALLOWS ONLY LETTER!"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "PRICE ALLOWS ONLY NUMBERS!"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtquantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            lblError.Text = "PRICE ALLOWS ONLY NUMBERS!"
            lblError.ForeColor = Color.Red
        Else
            lblError.Text = ""

        End If
    End Sub

    Private Sub griddatabook_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles griddatabook.CellMouseClick
        Dim row As DataGridViewRow = griddatabook.Rows(e.RowIndex)
        cmbbid.SelectedItem = row.Cells(0).Value.ToString
        txtbname.Text = row.Cells(1).Value.ToString
        cmbbsubject.SelectedItem = row.Cells(2).Value.ToString
        cmbedition.SelectedItem = row.Cells(3).Value.ToString
        txtauthor.Text = row.Cells(4).Value.ToString
        txtpublisher.Text = row.Cells(5).Value.ToString
        txtprice.Text = row.Cells(6).Value.ToString
        txtquantity.Text = row.Cells(7).Value.ToString

    End Sub

    ' Reset Form Fields
    Private Sub ResetForm()
        cmbbid.Text = ""
        txtbname.Text = ""
        cmbbsubject.Text = ""
        cmbedition.Text = ""
        txtauthor.Text = ""
        txtpublisher.Text = ""
        txtprice.Text = ""
        txtquantity.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim login As New LOGIN
        login.Show()
    End Sub
End Class





