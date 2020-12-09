<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbl_branch_Address = New System.Windows.Forms.Label()
        Me.tblPnlNameUser = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_branch_Id = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.tblPnlButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Pos = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.btn_Profile = New System.Windows.Forms.Button()
        Me.btn_Inventory = New System.Windows.Forms.Button()
        Me.btn_Customer = New System.Windows.Forms.Button()
        Me.btn_Reports = New System.Windows.Forms.Button()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.pbFiller = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.tblPnlNameUser.SuspendLayout()
        Me.pnlUser.SuspendLayout()
        Me.pnlName.SuspendLayout()
        Me.tblPnlButtons.SuspendLayout()
        Me.pnlMid.SuspendLayout()
        CType(Me.pbFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lbl_branch_Address)
        Me.pnlHeader.Controls.Add(Me.tblPnlNameUser)
        Me.pnlHeader.Controls.Add(Me.lbl_branch_Id)
        Me.pnlHeader.Controls.Add(Me.lbl_Username)
        Me.pnlHeader.Controls.Add(Me.lbl_Header)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1924, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lbl_branch_Address
        '
        Me.lbl_branch_Address.AutoSize = True
        Me.lbl_branch_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch_Address.ForeColor = System.Drawing.Color.White
        Me.lbl_branch_Address.Location = New System.Drawing.Point(589, 17)
        Me.lbl_branch_Address.Name = "lbl_branch_Address"
        Me.lbl_branch_Address.Size = New System.Drawing.Size(28, 26)
        Me.lbl_branch_Address.TabIndex = 17
        Me.lbl_branch_Address.Text = "()"
        '
        'tblPnlNameUser
        '
        Me.tblPnlNameUser.ColumnCount = 2
        Me.tblPnlNameUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlNameUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlNameUser.Controls.Add(Me.pnlUser, 1, 0)
        Me.tblPnlNameUser.Controls.Add(Me.pnlName, 0, 0)
        Me.tblPnlNameUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.tblPnlNameUser.Location = New System.Drawing.Point(1403, 0)
        Me.tblPnlNameUser.Name = "tblPnlNameUser"
        Me.tblPnlNameUser.RowCount = 1
        Me.tblPnlNameUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlNameUser.Size = New System.Drawing.Size(521, 60)
        Me.tblPnlNameUser.TabIndex = 16
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.lbl_Type)
        Me.pnlUser.Controls.Add(Me.Label1)
        Me.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUser.Location = New System.Drawing.Point(263, 3)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(255, 54)
        Me.pnlUser.TabIndex = 1
        '
        'lbl_Type
        '
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.ForeColor = System.Drawing.Color.White
        Me.lbl_Type.Location = New System.Drawing.Point(73, 11)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(176, 32)
        Me.lbl_Type.TabIndex = 15
        Me.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User:"
        '
        'pnlName
        '
        Me.pnlName.Controls.Add(Me.lbl_Name)
        Me.pnlName.Controls.Add(Me.Label5)
        Me.pnlName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlName.Location = New System.Drawing.Point(3, 3)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(254, 54)
        Me.pnlName.TabIndex = 0
        '
        'lbl_Name
        '
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.White
        Me.lbl_Name.Location = New System.Drawing.Point(78, 14)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(172, 29)
        Me.lbl_Name.TabIndex = 17
        Me.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Name:"
        '
        'lbl_branch_Id
        '
        Me.lbl_branch_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch_Id.Location = New System.Drawing.Point(771, 14)
        Me.lbl_branch_Id.Name = "lbl_branch_Id"
        Me.lbl_branch_Id.Size = New System.Drawing.Size(176, 32)
        Me.lbl_branch_Id.TabIndex = 15
        Me.lbl_branch_Id.Text = "Branch"
        Me.lbl_branch_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_branch_Id.Visible = False
        '
        'lbl_Username
        '
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(969, 14)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(176, 32)
        Me.lbl_Username.TabIndex = 14
        Me.lbl_Username.Text = "Admin"
        Me.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Username.Visible = False
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(14, 19)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(569, 26)
        Me.lbl_Header.TabIndex = 4
        Me.lbl_Header.Text = "AutoJack's Enterprise Point of Sale and Inventory System"
        '
        'tblPnlButtons
        '
        Me.tblPnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tblPnlButtons.ColumnCount = 1
        Me.tblPnlButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPnlButtons.Controls.Add(Me.btn_Pos, 0, 0)
        Me.tblPnlButtons.Controls.Add(Me.btn_Logout, 0, 6)
        Me.tblPnlButtons.Controls.Add(Me.btn_Profile, 0, 1)
        Me.tblPnlButtons.Controls.Add(Me.btn_Inventory, 0, 2)
        Me.tblPnlButtons.Controls.Add(Me.btn_Customer, 0, 3)
        Me.tblPnlButtons.Controls.Add(Me.btn_Reports, 0, 4)
        Me.tblPnlButtons.Controls.Add(Me.btn_Help, 0, 5)
        Me.tblPnlButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.tblPnlButtons.Location = New System.Drawing.Point(0, 60)
        Me.tblPnlButtons.Name = "tblPnlButtons"
        Me.tblPnlButtons.RowCount = 7
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblPnlButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblPnlButtons.Size = New System.Drawing.Size(273, 596)
        Me.tblPnlButtons.TabIndex = 2
        '
        'btn_Pos
        '
        Me.btn_Pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Pos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Pos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pos.ForeColor = System.Drawing.Color.White
        Me.btn_Pos.Location = New System.Drawing.Point(0, 0)
        Me.btn_Pos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Pos.Name = "btn_Pos"
        Me.btn_Pos.Size = New System.Drawing.Size(273, 85)
        Me.btn_Pos.TabIndex = 11
        Me.btn_Pos.Text = "[F1] &Point of Sale"
        Me.btn_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Pos.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.ForeColor = System.Drawing.Color.White
        Me.btn_Logout.Location = New System.Drawing.Point(0, 510)
        Me.btn_Logout.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(273, 86)
        Me.btn_Logout.TabIndex = 15
        Me.btn_Logout.Text = "[ESC] &Logout "
        Me.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'btn_Profile
        '
        Me.btn_Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Profile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Profile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Profile.ForeColor = System.Drawing.Color.White
        Me.btn_Profile.Location = New System.Drawing.Point(0, 85)
        Me.btn_Profile.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Profile.Name = "btn_Profile"
        Me.btn_Profile.Size = New System.Drawing.Size(273, 85)
        Me.btn_Profile.TabIndex = 10
        Me.btn_Profile.Text = "[F2] &Profiling "
        Me.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Profile.UseVisualStyleBackColor = False
        '
        'btn_Inventory
        '
        Me.btn_Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Inventory.ForeColor = System.Drawing.Color.White
        Me.btn_Inventory.Location = New System.Drawing.Point(0, 170)
        Me.btn_Inventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Inventory.Name = "btn_Inventory"
        Me.btn_Inventory.Size = New System.Drawing.Size(273, 85)
        Me.btn_Inventory.TabIndex = 11
        Me.btn_Inventory.Text = "[F3] &Inventory "
        Me.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Inventory.UseVisualStyleBackColor = False
        '
        'btn_Customer
        '
        Me.btn_Customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Customer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customer.ForeColor = System.Drawing.Color.White
        Me.btn_Customer.Location = New System.Drawing.Point(0, 255)
        Me.btn_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Customer.Name = "btn_Customer"
        Me.btn_Customer.Size = New System.Drawing.Size(273, 85)
        Me.btn_Customer.TabIndex = 12
        Me.btn_Customer.Text = "[F4] &Customers "
        Me.btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Customer.UseVisualStyleBackColor = False
        '
        'btn_Reports
        '
        Me.btn_Reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Reports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reports.ForeColor = System.Drawing.Color.White
        Me.btn_Reports.Location = New System.Drawing.Point(0, 340)
        Me.btn_Reports.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Reports.Name = "btn_Reports"
        Me.btn_Reports.Size = New System.Drawing.Size(273, 85)
        Me.btn_Reports.TabIndex = 13
        Me.btn_Reports.Text = "[F5] &Reports"
        Me.btn_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Reports.UseVisualStyleBackColor = False
        '
        'btn_Help
        '
        Me.btn_Help.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_Help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Help.ForeColor = System.Drawing.Color.White
        Me.btn_Help.Location = New System.Drawing.Point(0, 425)
        Me.btn_Help.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Size = New System.Drawing.Size(273, 85)
        Me.btn_Help.TabIndex = 14
        Me.btn_Help.Text = "[F6] &Help "
        Me.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Help.UseVisualStyleBackColor = False
        Me.btn_Help.Visible = False
        '
        'pnlMid
        '
        Me.pnlMid.Controls.Add(Me.pbFiller)
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(273, 60)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1651, 596)
        Me.pnlMid.TabIndex = 3
        '
        'pbFiller
        '
        Me.pbFiller.BackColor = System.Drawing.Color.White
        Me.pbFiller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbFiller.Image = Global.AJE.My.Resources.Resources.filler
        Me.pbFiller.Location = New System.Drawing.Point(0, 0)
        Me.pbFiller.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbFiller.Name = "pbFiller"
        Me.pbFiller.Size = New System.Drawing.Size(1651, 596)
        Me.pbFiller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFiller.TabIndex = 4
        Me.pbFiller.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 656)
        Me.Controls.Add(Me.pnlMid)
        Me.Controls.Add(Me.tblPnlButtons)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tblPnlNameUser.ResumeLayout(False)
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        Me.pnlName.ResumeLayout(False)
        Me.pnlName.PerformLayout()
        Me.tblPnlButtons.ResumeLayout(False)
        Me.pnlMid.ResumeLayout(False)
        CType(Me.pbFiller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lbl_branch_Id As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Header As Label
    Friend WithEvents tblPnlButtons As TableLayoutPanel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents btn_Profile As Button
    Friend WithEvents btn_Inventory As Button
    Friend WithEvents btn_Customer As Button
    Friend WithEvents btn_Reports As Button
    Friend WithEvents btn_Help As Button
    Friend WithEvents tblPnlNameUser As TableLayoutPanel
    Friend WithEvents pnlUser As Panel
    Friend WithEvents pnlName As Panel
    Friend WithEvents lbl_Name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_Type As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Pos As Button
    Friend WithEvents pnlMid As Panel
    Friend WithEvents pbFiller As PictureBox
    Friend WithEvents lbl_branch_Address As Label
End Class
