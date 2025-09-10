Public Class ISSUE_REPORT

    Private Sub ISSUE_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet3.issuetable' table. You can move, or remove it, as needed.
        Me.issuetableTableAdapter.Fill(Me.PROJECTWORK06DataSet3.issuetable)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Me.issuetableTableAdapter.FillByissuedate(Me.PROJECTWORK06DataSet3.issuetable, issuedtp.Value)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnshowall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshowall.Click
        Me.issuetableTableAdapter.FillByallissue(Me.PROJECTWORK06DataSet3.issuetable)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub
End Class