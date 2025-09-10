Public Class STUDENT_REPORT

    Private Sub STU_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTWORK06DataSet1.studenttable' table. You can move, or remove it, as needed.
        Me.studenttableTableAdapter.Fill(Me.PROJECTWORK06DataSet1.studenttable)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainform As New MAINFORM
        mainform.Show()
    End Sub
End Class