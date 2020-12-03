<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_branch_Id = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_change_Pass = New System.Windows.Forms.Label()
        Me.cb_show_Password = New System.Windows.Forms.CheckBox()
        Me.cbo_Branch = New System.Windows.Forms.ComboBox()
        Me.cbo_Active = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_Usertype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_Gname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Mi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_Surname = New System.Windows.Forms.TextBox()
        Me.tb_Suffix = New System.Windows.Forms.TextBox()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 55)
        Me.Panel1.TabIndex = 20
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(1363, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(58, 55)
        Me.btn_Close.TabIndex = 54
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Profile"
        '
        'lbl_branch_Id
        '
        Me.lbl_branch_Id.AutoSize = True
        Me.lbl_branch_Id.Location = New System.Drawing.Point(134, 690)
        Me.lbl_branch_Id.Name = "lbl_branch_Id"
        Me.lbl_branch_Id.Size = New System.Drawing.Size(74, 20)
        Me.lbl_branch_Id.TabIndex = 52
        Me.lbl_branch_Id.Text = "BranchId"
        Me.lbl_branch_Id.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_change_Pass)
        Me.GroupBox2.Controls.Add(Me.cb_show_Password)
        Me.GroupBox2.Controls.Add(Me.cbo_Branch)
        Me.GroupBox2.Controls.Add(Me.cbo_Active)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbo_Usertype)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tb_Username)
        Me.GroupBox2.Controls.Add(Me.tb_Password)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 333)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(796, 323)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Account Settings"
        '
        'lbl_change_Pass
        '
        Me.lbl_change_Pass.AutoSize = True
        Me.lbl_change_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change_Pass.Location = New System.Drawing.Point(197, 97)
        Me.lbl_change_Pass.Name = "lbl_change_Pass"
        Me.lbl_change_Pass.Size = New System.Drawing.Size(347, 25)
        Me.lbl_change_Pass.TabIndex = 7
        Me.lbl_change_Pass.Text = "[ Click Here To Change Password ]"
        Me.lbl_change_Pass.Visible = False
        '
        'cb_show_Password
        '
        Me.cb_show_Password.AutoSize = True
        Me.cb_show_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_show_Password.Location = New System.Drawing.Point(569, 98)
        Me.cb_show_Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cb_show_Password.Name = "cb_show_Password"
        Me.cb_show_Password.Size = New System.Drawing.Size(186, 29)
        Me.cb_show_Password.TabIndex = 6
        Me.cb_show_Password.Text = "show password"
        Me.cb_show_Password.UseVisualStyleBackColor = True
        '
        'cbo_Branch
        '
        Me.cbo_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Branch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Branch.Location = New System.Drawing.Point(200, 201)
        Me.cbo_Branch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_Branch.Name = "cbo_Branch"
        Me.cbo_Branch.Size = New System.Drawing.Size(433, 37)
        Me.cbo_Branch.TabIndex = 9
        '
        'cbo_Active
        '
        Me.cbo_Active.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Active.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Active.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbo_Active.Location = New System.Drawing.Point(200, 257)
        Me.cbo_Active.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_Active.Name = "cbo_Active"
        Me.cbo_Active.Size = New System.Drawing.Size(136, 37)
        Me.cbo_Active.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Branch:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Active:"
        '
        'cbo_Usertype
        '
        Me.cbo_Usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Usertype.Items.AddRange(New Object() {"Cashier", "Manager", "Admin"})
        Me.cbo_Usertype.Location = New System.Drawing.Point(200, 146)
        Me.cbo_Usertype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_Usertype.Name = "cbo_Usertype"
        Me.cbo_Usertype.Size = New System.Drawing.Size(136, 37)
        Me.cbo_Usertype.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 25)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "User Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 25)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Password:"
        '
        'tb_Username
        '
        Me.tb_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Username.Location = New System.Drawing.Point(200, 43)
        Me.tb_Username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Username.MaxLength = 30
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.ShortcutsEnabled = False
        Me.tb_Username.Size = New System.Drawing.Size(348, 35)
        Me.tb_Username.TabIndex = 4
        '
        'tb_Password
        '
        Me.tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.Location = New System.Drawing.Point(200, 94)
        Me.tb_Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Password.MaxLength = 30
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.ShortcutsEnabled = False
        Me.tb_Password.Size = New System.Drawing.Size(348, 35)
        Me.tb_Password.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_Gname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_Mi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tb_Surname)
        Me.GroupBox1.Controls.Add(Me.tb_Suffix)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 67)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(796, 255)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'tb_Gname
        '
        Me.tb_Gname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Gname.Location = New System.Drawing.Point(200, 42)
        Me.tb_Gname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Gname.MaxLength = 100
        Me.tb_Gname.Name = "tb_Gname"
        Me.tb_Gname.ShortcutsEnabled = False
        Me.tb_Gname.Size = New System.Drawing.Size(558, 35)
        Me.tb_Gname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Given Name:"
        '
        'tb_Mi
        '
        Me.tb_Mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Mi.Location = New System.Drawing.Point(200, 92)
        Me.tb_Mi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Mi.MaxLength = 10
        Me.tb_Mi.Name = "tb_Mi"
        Me.tb_Mi.ShortcutsEnabled = False
        Me.tb_Mi.Size = New System.Drawing.Size(92, 35)
        Me.tb_Mi.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Middle Initial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Surname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Suffix:"
        '
        'tb_Surname
        '
        Me.tb_Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Surname.Location = New System.Drawing.Point(200, 144)
        Me.tb_Surname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Surname.MaxLength = 100
        Me.tb_Surname.Name = "tb_Surname"
        Me.tb_Surname.ShortcutsEnabled = False
        Me.tb_Surname.Size = New System.Drawing.Size(558, 35)
        Me.tb_Surname.TabIndex = 2
        '
        'tb_Suffix
        '
        Me.tb_Suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Suffix.Location = New System.Drawing.Point(200, 195)
        Me.tb_Suffix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Suffix.MaxLength = 10
        Me.tb_Suffix.Name = "tb_Suffix"
        Me.tb_Suffix.ShortcutsEnabled = False
        Me.tb_Suffix.Size = New System.Drawing.Size(92, 35)
        Me.tb_Suffix.TabIndex = 3
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(73, 690)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(23, 20)
        Me.lbl_Id.TabIndex = 49
        Me.lbl_Id.Text = "Id"
        Me.lbl_Id.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(706, 668)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 64)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(575, 668)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(125, 64)
        Me.btn_Update.TabIndex = 12
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        Me.btn_Update.Visible = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(575, 668)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(125, 64)
        Me.btn_Save.TabIndex = 11
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'frmUserEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 752)
        Me.Controls.Add(Me.lbl_branch_Id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmUserEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_branch_Id As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_change_Pass As Label
    Friend WithEvents cb_show_Password As CheckBox
    Friend WithEvents cbo_Branch As ComboBox
    Friend WithEvents cbo_Active As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_Usertype As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_Gname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Mi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_Surname As TextBox
    Friend WithEvents tb_Suffix As TextBox
    Friend WithEvents lbl_Id As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Save As Button
End Class
