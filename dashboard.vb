Imports System.Data.SqlClient
Public Class dashboard
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\VBAESHUU\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06\PROJECTWORK06.mdf;Integrated Security=True;User Instance=True")

    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        countstudents()
        countbooks()
        countissue()
        countreturn()
    End Sub
    Private Sub countstudents()
        Dim stunum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from studenttable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        stunum = cmd.ExecuteScalar
        lblstudent.Text = stunum
        con.Close()
    End Sub

    Private Sub countbooks()
        Dim booknum As Integer
        con.Open()
        Dim sql = "Select sum(Quantity) from booktable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        booknum = cmd.ExecuteScalar
        lbltotalbooks.Text = booknum
        con.Close()
    End Sub

    Private Sub countissue()
        Dim issuenum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from issuetable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        issuenum = cmd.ExecuteScalar
        lblissued.Text = issuenum
        con.Close()
    End Sub
    Private Sub countreturn()
        Dim returnnum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from returntable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        returnnum = cmd.ExecuteScalar
        lblreturned.Text = returnnum
        con.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim login As New LOGIN
        login.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub
End Class