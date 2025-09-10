Public Class MAINFORM

    Private Sub StudentFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentFormToolStripMenuItem.Click
        Dim childform As New STUDENT
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub BookFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookFormToolStripMenuItem.Click
        Dim childform As New BOOK
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub IssueFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueFormToolStripMenuItem.Click
        Dim childform As New ISSUE
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub ReturnFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnFormToolStripMenuItem.Click
        Dim childform As New RETURNN
        childform.MdiParent = Me
        childform.Show()
    End Sub

    'Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
    '    Dim childform As New studentreport
    '    childform.MdiParent = Me
    '    childform.Show()
    'End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim childform As New dashboard
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub BookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookToolStripMenuItem.Click
        Dim childform As New BOOK_REPORT
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub IssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueToolStripMenuItem.Click
        Dim childform As New ISSUE_REPORT
        childform.MdiParent = Me
        childform.Show()
    End Sub

    
    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Dim childform As New STUDENT_REPORT
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim childform As New RETURN_REPORT
        childform.MdiParent = Me
        childform.Show()
    End Sub

    Private Sub MAINFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class