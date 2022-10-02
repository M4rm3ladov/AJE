<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrandCat
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
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.lbl_brand_Cat = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.tb_brand_Cat = New System.Windows.Forms.TextBox()
        Me.lbl_tag = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Header)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 36)
        Me.Panel1.TabIndex = 15
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(9, 7)
        Me.lbl_Header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(85, 18)
        Me.lbl_Header.TabIndex = 6
        Me.lbl_Header.Text = "Brand Entry"
        '
        'lbl_brand_Cat
        '
        Me.lbl_brand_Cat.AutoSize = True
        Me.lbl_brand_Cat.Location = New System.Drawing.Point(26, 94)
        Me.lbl_brand_Cat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_brand_Cat.Name = "lbl_brand_Cat"
        Me.lbl_brand_Cat.Size = New System.Drawing.Size(39, 13)
        Me.lbl_brand_Cat.TabIndex = 20
        Me.lbl_brand_Cat.Text = "Label1"
        Me.lbl_brand_Cat.Visible = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(303, 94)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(83, 42)
        Me.btn_Update.TabIndex = 19
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(390, 94)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(83, 42)
        Me.btn_Cancel.TabIndex = 18
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(303, 94)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(83, 42)
        Me.btn_Save.TabIndex = 17
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'tb_brand_Cat
        '
        Me.tb_brand_Cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_brand_Cat.Location = New System.Drawing.Point(131, 58)
        Me.tb_brand_Cat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_brand_Cat.Name = "tb_brand_Cat"
        Me.tb_brand_Cat.Size = New System.Drawing.Size(343, 26)
        Me.tb_brand_Cat.TabIndex = 16
        '
        'lbl_tag
        '
        Me.lbl_tag.AutoSize = True
        Me.lbl_tag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tag.Location = New System.Drawing.Point(25, 60)
        Me.lbl_tag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tag.Name = "lbl_tag"
        Me.lbl_tag.Size = New System.Drawing.Size(91, 17)
        Me.lbl_tag.TabIndex = 71
        Me.lbl_tag.Text = "Brand Name:"
        '
        'frmBrandCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 148)
        Me.Controls.Add(Me.lbl_tag)
        Me.Controls.Add(Me.lbl_brand_Cat)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_brand_Cat)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBrandCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBrandCat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Header As Label
    Friend WithEvents lbl_brand_Cat As Label
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents tb_brand_Cat As TextBox
    Friend WithEvents lbl_tag As Label
End Class
