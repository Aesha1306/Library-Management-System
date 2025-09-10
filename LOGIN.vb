Imports System.Data
Imports System.Data.SqlClient
Public Class LOGIN
    Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim str As String
    Dim a1, a2 As String

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True"
    End Sub

    Private Sub forgotpasswordlabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgotpasswordlabel.LinkClicked
        Me.Hide()
        Dim reset As New RESET
        reset.Show()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        ' Validate inputs
        If String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtpassword.Text) Then
            labelmessage.Text = "All fields are required."
            labelmessage.ForeColor = Color.Red
            Return
        End If

        con.Open()
        str = "select * from logintable"
        cmd = New SqlCommand(str, con)
        Dim r1 As SqlDataReader
        r1 = cmd.ExecuteReader()

        While r1.Read()
            a1 = r1(0).ToString().Trim()
            a2 = r1(1).ToString().Trim()

            If (a1 = Me.txtusername.Text And a2 = Me.txtpassword.Text) Then
                MAINFORM.ShowDialog()
            Else
                labelmessage.Text = "INVALID TRY AGAIN....."
                labelmessage.ForeColor = Color.Red
                Me.txtusername.Clear()
                Me.txtpassword.Clear()
            End If
        End While
        con.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.txtusername.Clear()
        Me.txtpassword.Clear()
        Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class