<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT_REPORT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.studenttableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTWORK06DataSet1 = New PROJECTWORK06.PROJECTWORK06DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.studenttableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet1TableAdapters.studenttableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.studenttableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studenttableBindingSource
        '
        Me.studenttableBindingSource.DataMember = "studenttable"
        Me.studenttableBindingSource.DataSource = Me.PROJECTWORK06DataSet1
        '
        'PROJECTWORK06DataSet1
        '
        Me.PROJECTWORK06DataSet1.DataSetName = "PROJECTWORK06DataSet1"
        Me.PROJECTWORK06DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "studenttt"
        ReportDataSource2.Value = Me.studenttableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PROJECTWORK06.studentR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(217, 232)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1034, 431)
        Me.ReportViewer1.TabIndex = 0
        '
        'studenttableTableAdapter
        '
        Me.studenttableTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(555, 722)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 57)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'STUDENT_REPORT
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1569, 1002)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "STUDENT_REPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STU_REPORT"
        CType(Me.studenttableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents studenttableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROJECTWORK06DataSet1 As PROJECTWORK06.PROJECTWORK06DataSet1
    Friend WithEvents studenttableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet1TableAdapters.studenttableTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
