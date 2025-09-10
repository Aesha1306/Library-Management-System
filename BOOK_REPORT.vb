Public Class BOOK_REPORT

    Private Sub BOOK_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet2.booktable' table. You can move, or remove it, as needed.
        Me.booktableTableAdapter.Fill(Me.PROJECTWORK06DataSet2.booktable)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet2.booktable' table. You can move, or remove it, as needed.
        Me.booktableTableAdapter.FillBysubject(Me.PROJECTWORK06DataSet2.booktable, cmbbsubject.SelectedItem)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnshowall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshowall.Click
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet2.booktable' table. You can move, or remove it, as needed.
        Me.booktableTableAdapter.FillByallsubject(Me.PROJECTWORK06DataSet2.booktable)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub
End Class