<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISSUE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISSUE))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtissueid = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.cmbbid = New System.Windows.Forms.ComboBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.issuedtp = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labelquantity = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labeledition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.labelbname = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelsname = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbsid = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridissue = New System.Windows.Forms.DataGridView()
        Me.IssueIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTWORK06DataSet3 = New PROJECTWORK06.PROJECTWORK06DataSet3()
        Me.IssuetableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(268, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 141)
        Me.Panel2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Issue Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtissueid)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.cmbbid)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.issuedtp)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.labelquantity)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.labeledition)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.labelbname)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.labelsname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbsid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(26, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 767)
        Me.Panel1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(147, 677)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 47)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtissueid
        '
        Me.txtissueid.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtissueid.Location = New System.Drawing.Point(231, 20)
        Me.txtissueid.Multiline = True
        Me.txtissueid.Name = "txtissueid"
        Me.txtissueid.Size = New System.Drawing.Size(290, 42)
        Me.txtissueid.TabIndex = 72
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(117, 531)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(323, 42)
        Me.lblError.TabIndex = 71
        Me.lblError.Text = "labelerrormessage"
        '
        'cmbbid
        '
        Me.cmbbid.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbid.FormattingEnabled = True
        Me.cmbbid.Location = New System.Drawing.Point(231, 203)
        Me.cmbbid.Name = "cmbbid"
        Me.cmbbid.Size = New System.Drawing.Size(290, 44)
        Me.cmbbid.TabIndex = 63
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnreset.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnreset.Location = New System.Drawing.Point(456, 597)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(132, 57)
        Me.btnreset.TabIndex = 62
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btndelete.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btndelete.Location = New System.Drawing.Point(306, 597)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 57)
        Me.btndelete.TabIndex = 61
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnedit.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnedit.Location = New System.Drawing.Point(163, 597)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(124, 57)
        Me.btnedit.TabIndex = 60
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsave.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsave.Location = New System.Drawing.Point(26, 597)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(131, 57)
        Me.btnsave.TabIndex = 59
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'issuedtp
        '
        Me.issuedtp.CustomFormat = ""
        Me.issuedtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.issuedtp.Location = New System.Drawing.Point(230, 438)
        Me.issuedtp.Name = "issuedtp"
        Me.issuedtp.Size = New System.Drawing.Size(254, 39)
        Me.issuedtp.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(20, 442)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 36)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Issue Date:"
        '
        'labelquantity
        '
        Me.labelquantity.AutoSize = True
        Me.labelquantity.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelquantity.Location = New System.Drawing.Point(224, 381)
        Me.labelquantity.Name = "labelquantity"
        Me.labelquantity.Size = New System.Drawing.Size(0, 36)
        Me.labelquantity.TabIndex = 56
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(18, 381)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 36)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Quantity:"
        '
        'labeledition
        '
        Me.labeledition.AutoSize = True
        Me.labeledition.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeledition.Location = New System.Drawing.Point(224, 330)
        Me.labeledition.Name = "labeledition"
        Me.labeledition.Size = New System.Drawing.Size(0, 36)
        Me.labeledition.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(17, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 36)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Book Edition:"
        '
        'labelbname
        '
        Me.labelbname.AutoSize = True
        Me.labelbname.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbname.Location = New System.Drawing.Point(224, 276)
        Me.labelbname.Name = "labelbname"
        Me.labelbname.Size = New System.Drawing.Size(0, 36)
        Me.labelbname.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(20, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 36)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Book Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(20, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 36)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Book Id:"
        '
        'labelsname
        '
        Me.labelsname.AutoSize = True
        Me.labelsname.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelsname.Location = New System.Drawing.Point(225, 157)
        Me.labelsname.Name = "labelsname"
        Me.labelsname.Size = New System.Drawing.Size(0, 42)
        Me.labelsname.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 36)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Student Name:"
        '
        'cmbsid
        '
        Me.cmbsid.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbsid.FormattingEnabled = True
        Me.cmbsid.Items.AddRange(New Object() {"1"})
        Me.cmbsid.Location = New System.Drawing.Point(231, 86)
        Me.cmbsid.Name = "cmbsid"
        Me.cmbsid.Size = New System.Drawing.Size(290, 44)
        Me.cmbsid.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 36)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Student Id:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 36)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Issue Id:"
        '
        'datagridissue
        '
        Me.datagridissue.AutoGenerateColumns = False
        Me.datagridissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridissue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueIdDataGridViewTextBoxColumn, Me.StudentIdDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.BookIdDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn})
        Me.datagridissue.DataSource = Me.IssuetableBindingSource
        Me.datagridissue.Location = New System.Drawing.Point(643, 168)
        Me.datagridissue.Name = "datagridissue"
        Me.datagridissue.RowTemplate.Height = 28
        Me.datagridissue.Size = New System.Drawing.Size(970, 676)
        Me.datagridissue.TabIndex = 24
        '
        'IssueIdDataGridViewTextBoxColumn
        '
        Me.IssueIdDataGridViewTextBoxColumn.DataPropertyName = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.HeaderText = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.Name = "IssueIdDataGridViewTextBoxColumn"
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'BookIdDataGridViewTextBoxColumn
        '
        Me.BookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId"
        Me.BookIdDataGridViewTextBoxColumn.HeaderText = "BookId"
        Me.BookIdDataGridViewTextBoxColumn.Name = "BookIdDataGridViewTextBoxColumn"
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "Edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        '
        'IssuetableBindingSource
        '
        Me.IssuetableBindingSource.DataMember = "issuetable"
        Me.IssuetableBindingSource.DataSource = Me.PROJECTWORK06DataSet3
        '
        'PROJECTWORK06DataSet3
        '
        Me.PROJECTWORK06DataSet3.DataSetName = "PROJECTWORK06DataSet3"
        Me.PROJECTWORK06DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssuetableTableAdapter
        '
        Me.IssuetableTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1611, 1040)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1624, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1336, 855)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(90, 71)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 80
        Me.PictureBox5.TabStop = False
        '
        'ISSUE
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1613, 1116)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.datagridissue)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ISSUE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISSUE"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagridissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents cmbbid As System.Windows.Forms.ComboBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents issuedtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labelquantity As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents labeledition As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents labelbname As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labelsname As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbsid As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagridissue As System.Windows.Forms.DataGridView
    Friend WithEvents PROJECTWORK06DataSet3 As PROJECTWORK06.PROJECTWORK06DataSet3
    Friend WithEvents IssuetableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssuetableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet3TableAdapters.issuetableTableAdapter
    Friend WithEvents IssueIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtissueid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
