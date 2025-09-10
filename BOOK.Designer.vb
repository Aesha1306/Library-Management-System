<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOOK))
        Me.griddatabook = New System.Windows.Forms.DataGridView()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooktableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTWORK06DataSet2 = New PROJECTWORK06.PROJECTWORK06DataSet2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.cmbedition = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtbname = New System.Windows.Forms.TextBox()
        Me.cmbbsubject = New System.Windows.Forms.ComboBox()
        Me.cmbbid = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BooktableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet2TableAdapters.booktableTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.griddatabook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooktableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griddatabook
        '
        Me.griddatabook.AutoGenerateColumns = False
        Me.griddatabook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griddatabook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIdDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.griddatabook.DataSource = Me.BooktableBindingSource
        Me.griddatabook.Location = New System.Drawing.Point(644, 193)
        Me.griddatabook.Name = "griddatabook"
        Me.griddatabook.RowTemplate.Height = 28
        Me.griddatabook.Size = New System.Drawing.Size(960, 656)
        Me.griddatabook.TabIndex = 31
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
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "Edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'BooktableBindingSource
        '
        Me.BooktableBindingSource.DataMember = "booktable"
        Me.BooktableBindingSource.DataSource = Me.PROJECTWORK06DataSet2
        '
        'PROJECTWORK06DataSet2
        '
        Me.PROJECTWORK06DataSet2.DataSetName = "PROJECTWORK06DataSet2"
        Me.PROJECTWORK06DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.cmbedition)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtquantity)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.txtpublisher)
        Me.Panel1.Controls.Add(Me.txtauthor)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.txtbname)
        Me.Panel1.Controls.Add(Me.cmbbsubject)
        Me.Panel1.Controls.Add(Me.cmbbid)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(26, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 656)
        Me.Panel1.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(173, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 47)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(140, 487)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(224, 30)
        Me.lblError.TabIndex = 72
        Me.lblError.Text = "labelerrormessage"
        '
        'cmbedition
        '
        Me.cmbedition.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbedition.FormattingEnabled = True
        Me.cmbedition.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th"})
        Me.cmbedition.Location = New System.Drawing.Point(229, 178)
        Me.cmbedition.Name = "cmbedition"
        Me.cmbedition.Size = New System.Drawing.Size(290, 44)
        Me.cmbedition.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(11, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 36)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Book Edition:"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtquantity.Location = New System.Drawing.Point(229, 418)
        Me.txtquantity.Multiline = True
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(290, 42)
        Me.txtquantity.TabIndex = 24
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtprice.Location = New System.Drawing.Point(229, 362)
        Me.txtprice.Multiline = True
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(290, 42)
        Me.txtprice.TabIndex = 23
        '
        'txtpublisher
        '
        Me.txtpublisher.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtpublisher.Location = New System.Drawing.Point(229, 299)
        Me.txtpublisher.Multiline = True
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(290, 42)
        Me.txtpublisher.TabIndex = 22
        '
        'txtauthor
        '
        Me.txtauthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtauthor.Location = New System.Drawing.Point(229, 242)
        Me.txtauthor.Multiline = True
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(290, 42)
        Me.txtauthor.TabIndex = 21
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnreset.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnreset.Location = New System.Drawing.Point(440, 546)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(132, 57)
        Me.btnreset.TabIndex = 20
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btndelete.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btndelete.Location = New System.Drawing.Point(290, 546)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 57)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnedit.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnedit.Location = New System.Drawing.Point(160, 546)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(124, 57)
        Me.btnedit.TabIndex = 18
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsave.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsave.Location = New System.Drawing.Point(23, 546)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(131, 57)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtbname
        '
        Me.txtbname.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbname.Location = New System.Drawing.Point(229, 75)
        Me.txtbname.Multiline = True
        Me.txtbname.Name = "txtbname"
        Me.txtbname.Size = New System.Drawing.Size(290, 42)
        Me.txtbname.TabIndex = 16
        '
        'cmbbsubject
        '
        Me.cmbbsubject.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbsubject.FormattingEnabled = True
        Me.cmbbsubject.Items.AddRange(New Object() {"Physics", "Chemistry", "Biology", "Food Technology", "Java", "C", "C++"})
        Me.cmbbsubject.Location = New System.Drawing.Point(229, 128)
        Me.cmbbsubject.Name = "cmbbsubject"
        Me.cmbbsubject.Size = New System.Drawing.Size(290, 44)
        Me.cmbbsubject.TabIndex = 11
        '
        'cmbbid
        '
        Me.cmbbid.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbid.FormattingEnabled = True
        Me.cmbbid.Items.AddRange(New Object() {"B101", "B102", "B103", "B104", "B105", "B106", "B107", "B108", "B109", "B110"})
        Me.cmbbid.Location = New System.Drawing.Point(229, 15)
        Me.cmbbid.Name = "cmbbid"
        Me.cmbbid.Size = New System.Drawing.Size(290, 44)
        Me.cmbbid.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 36)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Book Subject:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(17, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 36)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(17, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 36)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 36)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Publisher:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Id:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(235, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 141)
        Me.Panel2.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Book Details"
        '
        'BooktableTableAdapter
        '
        Me.BooktableTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1336, 855)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 77
        Me.PictureBox4.TabStop = False
        '
        'BOOK
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1659, 1409)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.griddatabook)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BOOK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOOK"
        CType(Me.griddatabook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooktableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents griddatabook As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbedition As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtbname As System.Windows.Forms.TextBox
    Friend WithEvents cmbbsubject As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbid As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents PROJECTWORK06DataSet2 As PROJECTWORK06.PROJECTWORK06DataSet2
    Friend WithEvents BooktableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooktableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet2TableAdapters.booktableTableAdapter
    Friend WithEvents BookIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
