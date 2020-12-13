<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceRefund
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
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Qty = New System.Windows.Forms.TextBox()
        Me.tb_price_Range = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Price = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.ForeColor = System.Drawing.Color.White
        Me.lbl_Type.Location = New System.Drawing.Point(55, 386)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(68, 29)
        Me.lbl_Type.TabIndex = 29
        Me.lbl_Type.Text = "Type"
        Me.lbl_Type.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Quantity:"
        '
        'tb_Qty
        '
        Me.tb_Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Qty.Location = New System.Drawing.Point(304, 319)
        Me.tb_Qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Qty.MaxLength = 3
        Me.tb_Qty.Multiline = True
        Me.tb_Qty.Name = "tb_Qty"
        Me.tb_Qty.Size = New System.Drawing.Size(170, 96)
        Me.tb_Qty.TabIndex = 23
        Me.tb_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_price_Range
        '
        Me.tb_price_Range.BackColor = System.Drawing.Color.Black
        Me.tb_price_Range.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price_Range.ForeColor = System.Drawing.Color.Green
        Me.tb_price_Range.Location = New System.Drawing.Point(144, 96)
        Me.tb_price_Range.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_price_Range.MaxLength = 2
        Me.tb_price_Range.Multiline = True
        Me.tb_price_Range.Name = "tb_price_Range"
        Me.tb_price_Range.ReadOnly = True
        Me.tb_price_Range.Size = New System.Drawing.Size(330, 63)
        Me.tb_price_Range.TabIndex = 27
        Me.tb_price_Range.TabStop = False
        Me.tb_price_Range.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(348, 439)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(125, 64)
        Me.btn_Cancel.TabIndex = 25
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.White
        Me.btn_Add.Location = New System.Drawing.Point(217, 439)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(125, 64)
        Me.btn_Add.TabIndex = 24
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Price:"
        '
        'tb_Price
        '
        Me.tb_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Price.Location = New System.Drawing.Point(82, 167)
        Me.tb_Price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Price.MaxLength = 2
        Me.tb_Price.Multiline = True
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.Size = New System.Drawing.Size(392, 79)
        Me.tb_Price.TabIndex = 22
        Me.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPriceRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(539, 550)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Qty)
        Me.Controls.Add(Me.tb_price_Range)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Price)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPriceRefund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPriceRefund"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Type As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Qty As TextBox
    Friend WithEvents tb_price_Range As TextBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Price As TextBox
End Class
