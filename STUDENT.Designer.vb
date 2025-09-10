<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STUDENT))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datagridstudent = New System.Windows.Forms.DataGridView()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudenttableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTWORK06DataSet1 = New PROJECTWORK06.PROJECTWORK06DataSet1()
        Me.StudenttableTableAdapter = New PROJECTWORK06.PROJECTWORK06DataSet1TableAdapters.studenttableTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.birthdtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbsemester = New System.Windows.Forms.ComboBox()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.cmbdepartment = New System.Windows.Forms.ComboBox()
        Me.cmbyear = New System.Windows.Forms.ComboBox()
        Me.cmbsid = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.datagridstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudenttableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTWORK06DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(245, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 133)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Student Details"
        '
        'datagridstudent
        '
        Me.datagridstudent.AutoGenerateColumns = False
        Me.datagridstudent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datagridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridstudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIdDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AcademicYearDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.BirthDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn})
        Me.datagridstudent.DataSource = Me.StudenttableBindingSource
        Me.datagridstudent.Location = New System.Drawing.Point(610, 174)
        Me.datagridstudent.Name = "datagridstudent"
        Me.datagridstudent.RowTemplate.Height = 28
        Me.datagridstudent.Size = New System.Drawing.Size(952, 512)
        Me.datagridstudent.TabIndex = 48
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
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AcademicYearDataGridViewTextBoxColumn
        '
        Me.AcademicYearDataGridViewTextBoxColumn.DataPropertyName = "AcademicYear"
        Me.AcademicYearDataGridViewTextBoxColumn.HeaderText = "AcademicYear"
        Me.AcademicYearDataGridViewTextBoxColumn.Name = "AcademicYearDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'BirthDataGridViewTextBoxColumn
        '
        Me.BirthDataGridViewTextBoxColumn.DataPropertyName = "Birth"
        Me.BirthDataGridViewTextBoxColumn.HeaderText = "Birth"
        Me.BirthDataGridViewTextBoxColumn.Name = "BirthDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'StudenttableBindingSource
        '
        Me.StudenttableBindingSource.DataMember = "studenttable"
        Me.StudenttableBindingSource.DataSource = Me.PROJECTWORK06DataSet1
        '
        'PROJECTWORK06DataSet1
        '
        Me.PROJECTWORK06DataSet1.DataSetName = "PROJECTWORK06DataSet1"
        Me.PROJECTWORK06DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudenttableTableAdapter
        '
        Me.StudenttableTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1336, 855)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdofemale)
        Me.Panel1.Controls.Add(Me.rdomale)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.txtcontact)
        Me.Panel1.Controls.Add(Me.txtsname)
        Me.Panel1.Controls.Add(Me.birthdtp)
        Me.Panel1.Controls.Add(Me.cmbsemester)
        Me.Panel1.Controls.Add(Me.cmbcourse)
        Me.Panel1.Controls.Add(Me.cmbdepartment)
        Me.Panel1.Controls.Add(Me.cmbyear)
        Me.Panel1.Controls.Add(Me.cmbsid)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(26, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 786)
        Me.Panel1.TabIndex = 76
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(369, 124)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(136, 40)
        Me.rdofemale.TabIndex = 124
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(249, 126)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(103, 40)
        Me.rdomale.TabIndex = 123
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(164, 557)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(224, 30)
        Me.lblError.TabIndex = 122
        Me.lblError.Text = "labelerrormessage"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnreset.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnreset.Location = New System.Drawing.Point(445, 638)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(132, 57)
        Me.btnreset.TabIndex = 121
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btndelete.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btndelete.Location = New System.Drawing.Point(295, 638)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 57)
        Me.btndelete.TabIndex = 120
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnedit.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnedit.Location = New System.Drawing.Point(159, 638)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(124, 57)
        Me.btnedit.TabIndex = 119
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsave.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsave.Location = New System.Drawing.Point(12, 638)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(131, 57)
        Me.btnsave.TabIndex = 111
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(248, 496)
        Me.txtcontact.MaxLength = 10
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(283, 42)
        Me.txtcontact.TabIndex = 118
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(249, 69)
        Me.txtsname.Multiline = True
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(290, 42)
        Me.txtsname.TabIndex = 117
        '
        'birthdtp
        '
        Me.birthdtp.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdtp.Location = New System.Drawing.Point(248, 433)
        Me.birthdtp.Name = "birthdtp"
        Me.birthdtp.Size = New System.Drawing.Size(283, 39)
        Me.birthdtp.TabIndex = 116
        '
        'cmbsemester
        '
        Me.cmbsemester.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemester.FormattingEnabled = True
        Me.cmbsemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbsemester.Location = New System.Drawing.Point(249, 369)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.Size = New System.Drawing.Size(290, 44)
        Me.cmbsemester.TabIndex = 115
        '
        'cmbcourse
        '
        Me.cmbcourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"AIML", "CA AND IT", "BCA", "BCOM", "BNF", "BSC CHEMISTRY", "BSC BIOTECH", "ENGLISH", "MATHS"})
        Me.cmbcourse.Location = New System.Drawing.Point(249, 301)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(290, 44)
        Me.cmbcourse.TabIndex = 100
        '
        'cmbdepartment
        '
        Me.cmbdepartment.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdepartment.FormattingEnabled = True
        Me.cmbdepartment.Items.AddRange(New Object() {"COMPUTER", "BSC", "FOOD TECHNOLOGY", "SCIENCE", "ENGLISH", "MATHEMATICS"})
        Me.cmbdepartment.Location = New System.Drawing.Point(249, 239)
        Me.cmbdepartment.Name = "cmbdepartment"
        Me.cmbdepartment.Size = New System.Drawing.Size(290, 44)
        Me.cmbdepartment.TabIndex = 114
        '
        'cmbyear
        '
        Me.cmbyear.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Items.AddRange(New Object() {"2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmbyear.Location = New System.Drawing.Point(248, 179)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(290, 44)
        Me.cmbyear.TabIndex = 113
        '
        'cmbsid
        '
        Me.cmbsid.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsid.FormattingEnabled = True
        Me.cmbsid.Items.AddRange(New Object() {"S101", "S102", "S103", "S104", "S105", "S106", "S107", "S108", "S109", "S110"})
        Me.cmbsid.Location = New System.Drawing.Point(249, 8)
        Me.cmbsid.Name = "cmbsid"
        Me.cmbsid.Size = New System.Drawing.Size(290, 44)
        Me.cmbsid.TabIndex = 112
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 36)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "ContactNo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 36)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Date of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 36)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 36)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Semester:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 36)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Course:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 36)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Department:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 36)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Academic Year:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 36)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Student Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 36)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Student Id:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(159, 701)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 47)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'STUDENT
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1613, 1466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.datagridstudent)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "STUDENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagridstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudenttableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTWORK06DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents datagridstudent As System.Windows.Forms.DataGridView
    Friend WithEvents PROJECTWORK06DataSet1 As PROJECTWORK06.PROJECTWORK06DataSet1
    Friend WithEvents StudenttableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudenttableTableAdapter As PROJECTWORK06.PROJECTWORK06DataSet1TableAdapters.studenttableTableAdapter
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcademicYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents birthdtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbsemester As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsid As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
