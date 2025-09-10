<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISSUE_REPORT
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.issuetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTWORK06DataSet3 = New PROJECTWORK06.PROJECTWORK06DataSet3()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnshowall = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.issuedtp = New System.Windows.Forms.DateTimePicker()
        Me.issuetableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.issuetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'issuetableBindingSource
        '
        Me.issuetableBindingSource.DataMember = "issuetable"
        Me.issuetableBindingSource.DataSource = Me.PROJECTWORK06DataSet3
        '
        'PROJECTWORK06DataSet3
        '
        Me.PROJECTWORK06DataSet3.DataSetName = "PROJECTWORK06DataSet3"
        Me.PROJECTWORK06DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(228, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 36)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Select IssueDate:"
        '
        'btnshowall
        '
        Me.btnshowall.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnshowall.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnshowall.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnshowall.Location = New System.Drawing.Point(946, 201)
        Me.btnshowall.Name = "btnshowall"
        Me.btnshowall.Size = New System.Drawing.Size(350, 57)
        Me.btnshowall.TabIndex = 114
        Me.btnshowall.Text = "FILTER ALL ISSUEBOOKS"
        Me.btnshowall.UseVisualStyleBackColor = False
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnshow.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnshow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnshow.Location = New System.Drawing.Point(946, 117)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(350, 57)
        Me.btnshow.TabIndex = 113
        Me.btnshow.Text = "FILTER BY DATE"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.issuetableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PROJECTWORK06.issueR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(297, 298)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1034, 431)
        Me.ReportViewer1.TabIndex = 112
        '
        'issuedtp
        '
        Me.issuedtp.CustomFormat = ""
        Me.issuedtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.issuedtp.Location = New System.Drawing.Point(509, 120)
        Me.issuedtp.Name = "issuedtp"
        Me.issuedtp.Size = New System.Drawing.Size(254, 39)
        Me.issuedtp.TabIndex = 117
        '
        'issuetableTableAdapter
        '
        Me.issuetableTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(585, 798)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 57)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ISSUE_REPORT
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1591, 1059)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.issuedtp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnshowall)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ISSUE_REPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISSUE_REPORT"
        CType(Me.issuetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnshowall As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents issuedtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents issuetableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROJECTWORK06DataSet3 As PROJECTWORK06.PROJECTWORK06DataSet3
    Friend WithEvents issuetableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
