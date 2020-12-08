<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlClose = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btn_Cashier = New System.Windows.Forms.Button()
        Me.btn_Customer = New System.Windows.Forms.Button()
        Me.btn_Sales = New System.Windows.Forms.Button()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.btn_Refund = New System.Windows.Forms.Button()
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
        Me.pnlHeader.Size = New System.Drawing.Size(1417, 106)
        Me.pnlHeader.TabIndex = 3
        '
        'pnlClose
        '
        Me.pnlClose.Controls.Add(Me.btn_Close)
        Me.pnlClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlClose.Location = New System.Drawing.Point(1301, 0)
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
        Me.Label21.Size = New System.Drawing.Size(165, 52)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Report"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btn_Refund)
        Me.pnlButtons.Controls.Add(Me.btn_Cashier)
        Me.pnlButtons.Controls.Add(Me.btn_Customer)
        Me.pnlButtons.Controls.Add(Me.btn_Sales)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 106)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1417, 68)
        Me.pnlButtons.TabIndex = 4
        '
        'btn_Cashier
        '
        Me.btn_Cashier.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Cashier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cashier.ForeColor = System.Drawing.Color.White
        Me.btn_Cashier.Location = New System.Drawing.Point(397, 0)
        Me.btn_Cashier.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Cashier.Name = "btn_Cashier"
        Me.btn_Cashier.Size = New System.Drawing.Size(180, 68)
        Me.btn_Cashier.TabIndex = 8
        Me.btn_Cashier.Text = "Cashier Report"
        Me.btn_Cashier.UseVisualStyleBackColor = False
        '
        'btn_Customer
        '
        Me.btn_Customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customer.ForeColor = System.Drawing.Color.White
        Me.btn_Customer.Location = New System.Drawing.Point(181, 0)
        Me.btn_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Customer.Name = "btn_Customer"
        Me.btn_Customer.Size = New System.Drawing.Size(216, 68)
        Me.btn_Customer.TabIndex = 6
        Me.btn_Customer.Text = "Customer Report"
        Me.btn_Customer.UseVisualStyleBackColor = False
        '
        'btn_Sales
        '
        Me.btn_Sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sales.ForeColor = System.Drawing.Color.White
        Me.btn_Sales.Location = New System.Drawing.Point(1, 0)
        Me.btn_Sales.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Sales.Name = "btn_Sales"
        Me.btn_Sales.Size = New System.Drawing.Size(180, 68)
        Me.btn_Sales.TabIndex = 5
        Me.btn_Sales.Text = "Sales Report"
        Me.btn_Sales.UseVisualStyleBackColor = False
        '
        'pnlMid
        '
        Me.pnlMid.Controls.Add(Me.pbImage)
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(0, 174)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1417, 427)
        Me.pnlMid.TabIndex = 5
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Image = Global.AJE.My.Resources.Resources.filler
        Me.pbImage.Location = New System.Drawing.Point(0, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(1417, 427)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'btn_Refund
        '
        Me.btn_Refund.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Refund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Refund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refund.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refund.ForeColor = System.Drawing.Color.White
        Me.btn_Refund.Location = New System.Drawing.Point(577, 0)
        Me.btn_Refund.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Refund.Name = "btn_Refund"
        Me.btn_Refund.Size = New System.Drawing.Size(180, 68)
        Me.btn_Refund.TabIndex = 9
        Me.btn_Refund.Text = "Refund Report"
        Me.btn_Refund.UseVisualStyleBackColor = False
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 601)
        Me.Controls.Add(Me.pnlMid)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.Text = "frmSales"
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
    Friend WithEvents pnlClose As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btn_Cashier As Button
    Friend WithEvents btn_Customer As Button
    Friend WithEvents btn_Sales As Button
    Friend WithEvents pnlMid As Panel
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btn_Refund As Button
End Class
