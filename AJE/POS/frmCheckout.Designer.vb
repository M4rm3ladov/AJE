<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.tb_Receipt = New System.Windows.Forms.TextBox()
        Me.lbl_Receipt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Due = New System.Windows.Forms.Label()
        Me.tb_Change = New System.Windows.Forms.TextBox()
        Me.tb_cash_Tendered = New System.Windows.Forms.TextBox()
        Me.tb_due_Total = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tb_Receipt
        '
        Me.tb_Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Receipt.Location = New System.Drawing.Point(448, 109)
        Me.tb_Receipt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Receipt.Multiline = True
        Me.tb_Receipt.Name = "tb_Receipt"
        Me.tb_Receipt.Size = New System.Drawing.Size(361, 54)
        Me.tb_Receipt.TabIndex = 30
        '
        'lbl_Receipt
        '
        Me.lbl_Receipt.AutoSize = True
        Me.lbl_Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Receipt.ForeColor = System.Drawing.Color.White
        Me.lbl_Receipt.Location = New System.Drawing.Point(68, 117)
        Me.lbl_Receipt.Name = "lbl_Receipt"
        Me.lbl_Receipt.Size = New System.Drawing.Size(262, 38)
        Me.lbl_Receipt.TabIndex = 29
        Me.lbl_Receipt.Text = "Receipt Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(68, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 38)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Transaction Date:"
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Location = New System.Drawing.Point(448, 53)
        Me.dtp_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(361, 31)
        Me.dtp_Date.TabIndex = 20
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(688, 494)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(122, 70)
        Me.btn_Cancel.TabIndex = 22
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Pay
        '
        Me.btn_Pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.ForeColor = System.Drawing.Color.White
        Me.btn_Pay.Location = New System.Drawing.Point(560, 494)
        Me.btn_Pay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(122, 70)
        Me.btn_Pay.TabIndex = 21
        Me.btn_Pay.Text = "Pay"
        Me.btn_Pay.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 82)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Change:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(68, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 38)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Cash Tendered:"
        '
        'lbl_Due
        '
        Me.lbl_Due.AutoSize = True
        Me.lbl_Due.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Due.ForeColor = System.Drawing.Color.White
        Me.lbl_Due.Location = New System.Drawing.Point(68, 206)
        Me.lbl_Due.Name = "lbl_Due"
        Me.lbl_Due.Size = New System.Drawing.Size(167, 38)
        Me.lbl_Due.TabIndex = 23
        Me.lbl_Due.Text = "Due Total:"
        '
        'tb_Change
        '
        Me.tb_Change.BackColor = System.Drawing.Color.Black
        Me.tb_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Change.ForeColor = System.Drawing.Color.Green
        Me.tb_Change.Location = New System.Drawing.Point(395, 368)
        Me.tb_Change.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Change.Multiline = True
        Me.tb_Change.Name = "tb_Change"
        Me.tb_Change.ReadOnly = True
        Me.tb_Change.Size = New System.Drawing.Size(414, 96)
        Me.tb_Change.TabIndex = 25
        Me.tb_Change.TabStop = False
        Me.tb_Change.Text = "0.00"
        Me.tb_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_cash_Tendered
        '
        Me.tb_cash_Tendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cash_Tendered.Location = New System.Drawing.Point(395, 277)
        Me.tb_cash_Tendered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_cash_Tendered.Multiline = True
        Me.tb_cash_Tendered.Name = "tb_cash_Tendered"
        Me.tb_cash_Tendered.Size = New System.Drawing.Size(414, 70)
        Me.tb_cash_Tendered.TabIndex = 19
        Me.tb_cash_Tendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_due_Total
        '
        Me.tb_due_Total.BackColor = System.Drawing.Color.Black
        Me.tb_due_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_due_Total.ForeColor = System.Drawing.Color.Green
        Me.tb_due_Total.Location = New System.Drawing.Point(395, 187)
        Me.tb_due_Total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_due_Total.Multiline = True
        Me.tb_due_Total.Name = "tb_due_Total"
        Me.tb_due_Total.ReadOnly = True
        Me.tb_due_Total.Size = New System.Drawing.Size(414, 70)
        Me.tb_due_Total.TabIndex = 24
        Me.tb_due_Total.TabStop = False
        Me.tb_due_Total.Text = "0.00"
        Me.tb_due_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 610)
        Me.Controls.Add(Me.tb_Receipt)
        Me.Controls.Add(Me.lbl_Receipt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Pay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Due)
        Me.Controls.Add(Me.tb_Change)
        Me.Controls.Add(Me.tb_cash_Tendered)
        Me.Controls.Add(Me.tb_due_Total)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCheckout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Receipt As TextBox
    Friend WithEvents lbl_Receipt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Pay As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Due As Label
    Friend WithEvents tb_Change As TextBox
    Friend WithEvents tb_cash_Tendered As TextBox
    Friend WithEvents tb_due_Total As TextBox
End Class
