<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOK_REPORT
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btnshowall = New System.Windows.Forms.Button()
        Me.cmbbsubject = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PROJECTWORK06DataSet2 = New PROJECTWORK06.PROJECTWORK06DataSet2()
        Me.booktableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.booktableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet2TableAdapters.booktableTableAdapter()
        Me.PROJECTWORK06DataSet3 = New PROJECTWORK06.PROJECTWORK06DataSet3()
        Me.issuetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.issuetableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PROJECTWORK06DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.booktableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.issuetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.issuetableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PROJECTWORK06.issueR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(248, 325)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1034, 431)
        Me.ReportViewer1.TabIndex = 1
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnshow.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnshow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnshow.Location = New System.Drawing.Point(851, 115)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(350, 57)
        Me.btnshow.TabIndex = 108
        Me.btnshow.Text = "FILTER BY SUBJECT"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'btnshowall
        '
        Me.btnshowall.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnshowall.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnshowall.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnshowall.Location = New System.Drawing.Point(851, 199)
        Me.btnshowall.Name = "btnshowall"
        Me.btnshowall.Size = New System.Drawing.Size(350, 57)
        Me.btnshowall.TabIndex = 109
        Me.btnshowall.Text = "SHOW ALL"
        Me.btnshowall.UseVisualStyleBackColor = False
        '
        'cmbbsubject
        '
        Me.cmbbsubject.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbsubject.FormattingEnabled = True
        Me.cmbbsubject.Items.AddRange(New Object() {"Physics", "Chemistry", "Biology", "Food Technology", "Java", "C", "C++"})
        Me.cmbbsubject.Location = New System.Drawing.Point(467, 122)
        Me.cmbbsubject.Name = "cmbbsubject"
        Me.cmbbsubject.Size = New System.Drawing.Size(290, 44)
        Me.cmbbsubject.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(283, 36)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Select Book Subject:"
        '
        'PROJECTWORK06DataSet2
        '
        Me.PROJECTWORK06DataSet2.DataSetName = "PROJECTWORK06DataSet2"
        Me.PROJECTWORK06DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'booktableBindingSource
        '
        Me.booktableBindingSource.DataMember = "booktable"
        Me.booktableBindingSource.DataSource = Me.PROJECTWORK06DataSet2
        '
        'booktableTableAdapter
        '
        Me.booktableTableAdapter.ClearBeforeFill = True
        '
        'PROJECTWORK06DataSet3
        '
        Me.PROJECTWORK06DataSet3.DataSetName = "PROJECTWORK06DataSet3"
        Me.PROJECTWORK06DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'issuetableBindingSource
        '
        Me.issuetableBindingSource.DataMember = "issuetable"
        Me.issuetableBindingSource.DataSource = Me.PROJECTWORK06DataSet3
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
        Me.Button1.Location = New System.Drawing.Point(561, 793)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 57)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BOOK_REPORT
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1569, 1002)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbbsubject)
        Me.Controls.Add(Me.btnshowall)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BOOK_REPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOOK_REPORT"
        CType(Me.PROJECTWORK06DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.booktableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.issuetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents btnshowall As System.Windows.Forms.Button
    Friend WithEvents cmbbsubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents booktableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROJECTWORK06DataSet2 As PROJECTWORK06.PROJECTWORK06DataSet2
    Friend WithEvents booktableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet2TableAdapters.booktableTableAdapter
    Friend WithEvents issuetableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROJECTWORK06DataSet3 As PROJECTWORK06.PROJECTWORK06DataSet3
    Friend WithEvents issuetableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
