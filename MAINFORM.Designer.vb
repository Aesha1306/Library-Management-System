<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAINFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAINFORM))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentFormToolStripMenuItem, Me.BookFormToolStripMenuItem, Me.IssueFormToolStripMenuItem, Me.ReturnFormToolStripMenuItem, Me.ReportToolStripMenuItem, Me.DashboardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1591, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentFormToolStripMenuItem
        '
        Me.StudentFormToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple
        Me.StudentFormToolStripMenuItem.Name = "StudentFormToolStripMenuItem"
        Me.StudentFormToolStripMenuItem.Size = New System.Drawing.Size(165, 36)
        Me.StudentFormToolStripMenuItem.Text = "StudentForm"
        '
        'BookFormToolStripMenuItem
        '
        Me.BookFormToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.BookFormToolStripMenuItem.Name = "BookFormToolStripMenuItem"
        Me.BookFormToolStripMenuItem.Size = New System.Drawing.Size(136, 36)
        Me.BookFormToolStripMenuItem.Text = "BookForm"
        '
        'IssueFormToolStripMenuItem
        '
        Me.IssueFormToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple
        Me.IssueFormToolStripMenuItem.Name = "IssueFormToolStripMenuItem"
        Me.IssueFormToolStripMenuItem.Size = New System.Drawing.Size(135, 36)
        Me.IssueFormToolStripMenuItem.Text = "IssueForm"
        '
        'ReturnFormToolStripMenuItem
        '
        Me.ReturnFormToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.ReturnFormToolStripMenuItem.Name = "ReturnFormToolStripMenuItem"
        Me.ReturnFormToolStripMenuItem.Size = New System.Drawing.Size(152, 36)
        Me.ReturnFormToolStripMenuItem.Text = "ReturnForm"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.BookToolStripMenuItem, Me.IssueToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(97, 36)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(173, 36)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(173, 36)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'IssueToolStripMenuItem
        '
        Me.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem"
        Me.IssueToolStripMenuItem.Size = New System.Drawing.Size(173, 36)
        Me.IssueToolStripMenuItem.Text = "Issue "
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(173, 36)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(139, 36)
        Me.DashboardToolStripMenuItem.Text = "dashboard"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1381, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 80
        Me.PictureBox4.TabStop = False
        '
        'MAINFORM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.PROJECTWORK06.My.Resources.Resources.IMG_2749
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1591, 1059)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MAINFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAINFORM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
