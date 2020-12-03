<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfiling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfiling))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlClose = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btn_Supplier = New System.Windows.Forms.Button()
        Me.btn_Branch = New System.Windows.Forms.Button()
        Me.btn_Service = New System.Windows.Forms.Button()
        Me.btn_Item = New System.Windows.Forms.Button()
        Me.btn_User = New System.Windows.Forms.Button()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlClose.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlMid.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.pnlClose)
        Me.pnlHeader.Controls.Add(Me.Label21)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1431, 106)
        Me.pnlHeader.TabIndex = 2
        '
        'pnlClose
        '
        Me.pnlClose.Controls.Add(Me.btn_Close)
        Me.pnlClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlClose.Location = New System.Drawing.Point(1315, 0)
        Me.pnlClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(116, 106)
        Me.pnlClose.TabIndex = 4
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(0, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(116, 106)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = " "
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(195, 52)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Profiling"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btn_Supplier)
        Me.pnlButtons.Controls.Add(Me.btn_Branch)
        Me.pnlButtons.Controls.Add(Me.btn_Service)
        Me.pnlButtons.Controls.Add(Me.btn_Item)
        Me.pnlButtons.Controls.Add(Me.btn_User)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 106)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1431, 68)
        Me.pnlButtons.TabIndex = 3
        '
        'btn_Supplier
        '
        Me.btn_Supplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Supplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Supplier.ForeColor = System.Drawing.Color.White
        Me.btn_Supplier.Location = New System.Drawing.Point(584, 0)
        Me.btn_Supplier.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Supplier.Name = "btn_Supplier"
        Me.btn_Supplier.Size = New System.Drawing.Size(146, 68)
        Me.btn_Supplier.TabIndex = 9
        Me.btn_Supplier.Text = "Supplier"
        Me.btn_Supplier.UseVisualStyleBackColor = False
        '
        'btn_Branch
        '
        Me.btn_Branch.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Branch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Branch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Branch.ForeColor = System.Drawing.Color.White
        Me.btn_Branch.Location = New System.Drawing.Point(438, 0)
        Me.btn_Branch.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Branch.Name = "btn_Branch"
        Me.btn_Branch.Size = New System.Drawing.Size(146, 68)
        Me.btn_Branch.TabIndex = 8
        Me.btn_Branch.Text = "Branch"
        Me.btn_Branch.UseVisualStyleBackColor = False
        '
        'btn_Service
        '
        Me.btn_Service.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Service.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Service.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Service.ForeColor = System.Drawing.Color.White
        Me.btn_Service.Location = New System.Drawing.Point(293, 0)
        Me.btn_Service.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Service.Name = "btn_Service"
        Me.btn_Service.Size = New System.Drawing.Size(146, 68)
        Me.btn_Service.TabIndex = 6
        Me.btn_Service.Text = "Services"
        Me.btn_Service.UseVisualStyleBackColor = False
        '
        'btn_Item
        '
        Me.btn_Item.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Item.ForeColor = System.Drawing.Color.White
        Me.btn_Item.Location = New System.Drawing.Point(1, 0)
        Me.btn_Item.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Item.Name = "btn_Item"
        Me.btn_Item.Size = New System.Drawing.Size(146, 68)
        Me.btn_Item.TabIndex = 5
        Me.btn_Item.Text = "Items"
        Me.btn_Item.UseVisualStyleBackColor = False
        '
        'btn_User
        '
        Me.btn_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_User.ForeColor = System.Drawing.Color.White
        Me.btn_User.Location = New System.Drawing.Point(147, 0)
        Me.btn_User.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_User.Name = "btn_User"
        Me.btn_User.Size = New System.Drawing.Size(146, 68)
        Me.btn_User.TabIndex = 7
        Me.btn_User.Text = "Users"
        Me.btn_User.UseVisualStyleBackColor = False
        '
        'pnlMid
        '
        Me.pnlMid.Controls.Add(Me.pbImage)
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(0, 174)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1431, 690)
        Me.pnlMid.TabIndex = 4
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Image = Global.AJE.My.Resources.Resources.filler
        Me.pbImage.Location = New System.Drawing.Point(0, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(1431, 690)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'frmProfiling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 864)
        Me.Controls.Add(Me.pnlMid)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfiling"
        Me.Text = "frmProfiling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlClose.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlMid.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btn_Supplier As Button
    Friend WithEvents btn_Branch As Button
    Friend WithEvents btn_Service As Button
    Friend WithEvents btn_Item As Button
    Friend WithEvents btn_User As Button
    Friend WithEvents pnlClose As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents pnlMid As Panel
    Friend WithEvents pbImage As PictureBox
End Class
