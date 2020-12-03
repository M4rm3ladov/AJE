<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEntry
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
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.tb_Balance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_credit_Limit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.tb_Suffix = New System.Windows.Forms.TextBox()
        Me.tb_Surname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Gname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Mi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(46, 446)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(47, 20)
        Me.lbl_Id.TabIndex = 82
        Me.lbl_Id.Text = "lbl_Id"
        Me.lbl_Id.Visible = False
        '
        'tb_Balance
        '
        Me.tb_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Balance.Location = New System.Drawing.Point(255, 393)
        Me.tb_Balance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Balance.Name = "tb_Balance"
        Me.tb_Balance.ReadOnly = True
        Me.tb_Balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_Balance.Size = New System.Drawing.Size(185, 35)
        Me.tb_Balance.TabIndex = 7
        Me.tb_Balance.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 26)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Balance:"
        '
        'tb_credit_Limit
        '
        Me.tb_credit_Limit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_credit_Limit.Location = New System.Drawing.Point(255, 338)
        Me.tb_credit_Limit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_credit_Limit.Name = "tb_credit_Limit"
        Me.tb_credit_Limit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_credit_Limit.ShortcutsEnabled = False
        Me.tb_credit_Limit.Size = New System.Drawing.Size(185, 35)
        Me.tb_credit_Limit.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 26)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Credit Limit:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(688, 451)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(125, 64)
        Me.btn_Cancel.TabIndex = 10
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(557, 451)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(125, 64)
        Me.btn_Update.TabIndex = 9
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(425, 451)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(125, 64)
        Me.btn_Save.TabIndex = 8
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'tb_Suffix
        '
        Me.tb_Suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Suffix.Location = New System.Drawing.Point(255, 280)
        Me.tb_Suffix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Suffix.MaxLength = 10
        Me.tb_Suffix.Name = "tb_Suffix"
        Me.tb_Suffix.ShortcutsEnabled = False
        Me.tb_Suffix.Size = New System.Drawing.Size(92, 35)
        Me.tb_Suffix.TabIndex = 5
        '
        'tb_Surname
        '
        Me.tb_Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Surname.Location = New System.Drawing.Point(255, 229)
        Me.tb_Surname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Surname.MaxLength = 100
        Me.tb_Surname.Name = "tb_Surname"
        Me.tb_Surname.ShortcutsEnabled = False
        Me.tb_Surname.Size = New System.Drawing.Size(558, 35)
        Me.tb_Surname.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Suffix:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 26)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 26)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Middle Initial:"
        '
        'tb_Gname
        '
        Me.tb_Gname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Gname.Location = New System.Drawing.Point(255, 126)
        Me.tb_Gname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Gname.MaxLength = 100
        Me.tb_Gname.Name = "tb_Gname"
        Me.tb_Gname.ShortcutsEnabled = False
        Me.tb_Gname.Size = New System.Drawing.Size(558, 35)
        Me.tb_Gname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 26)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Given Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 26)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Customer Code:"
        '
        'tb_Code
        '
        Me.tb_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Code.Location = New System.Drawing.Point(255, 75)
        Me.tb_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Code.MaxLength = 50
        Me.tb_Code.Name = "tb_Code"
        Me.tb_Code.ShortcutsEnabled = False
        Me.tb_Code.Size = New System.Drawing.Size(453, 35)
        Me.tb_Code.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Profile"
        '
        'tb_Mi
        '
        Me.tb_Mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Mi.Location = New System.Drawing.Point(255, 176)
        Me.tb_Mi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Mi.MaxLength = 10
        Me.tb_Mi.Name = "tb_Mi"
        Me.tb_Mi.ShortcutsEnabled = False
        Me.tb_Mi.Size = New System.Drawing.Size(92, 35)
        Me.tb_Mi.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 55)
        Me.Panel1.TabIndex = 64
        '
        'frmCustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 538)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.tb_Balance)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_credit_Limit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_Suffix)
        Me.Controls.Add(Me.tb_Surname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Gname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Code)
        Me.Controls.Add(Me.tb_Mi)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerEntry"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Id As Label
    Friend WithEvents tb_Balance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_credit_Limit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents tb_Suffix As TextBox
    Friend WithEvents tb_Surname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Gname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Mi As TextBox
    Friend WithEvents Panel1 As Panel
End Class
