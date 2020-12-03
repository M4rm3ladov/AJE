<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCash_in
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
        Me.lbl_cash_In = New System.Windows.Forms.Label()
        Me.lbl_cash_Out = New System.Windows.Forms.Label()
        Me.tb_Amount = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_transDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Remarks = New System.Windows.Forms.TextBox()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lbl_cash_Out)
        Me.pnlHeader.Controls.Add(Me.lbl_cash_In)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(584, 60)
        Me.pnlHeader.TabIndex = 3
        '
        'lbl_cash_In
        '
        Me.lbl_cash_In.AutoSize = True
        Me.lbl_cash_In.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash_In.ForeColor = System.Drawing.Color.White
        Me.lbl_cash_In.Location = New System.Drawing.Point(14, 19)
        Me.lbl_cash_In.Name = "lbl_cash_In"
        Me.lbl_cash_In.Size = New System.Drawing.Size(87, 26)
        Me.lbl_cash_In.TabIndex = 6
        Me.lbl_cash_In.Text = "Cash In"
        '
        'lbl_cash_Out
        '
        Me.lbl_cash_Out.AutoSize = True
        Me.lbl_cash_Out.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash_Out.ForeColor = System.Drawing.Color.White
        Me.lbl_cash_Out.Location = New System.Drawing.Point(14, 19)
        Me.lbl_cash_Out.Name = "lbl_cash_Out"
        Me.lbl_cash_Out.Size = New System.Drawing.Size(104, 26)
        Me.lbl_cash_Out.TabIndex = 7
        Me.lbl_cash_Out.Text = "Cash Out"
        '
        'tb_Amount
        '
        Me.tb_Amount.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Amount.ForeColor = System.Drawing.Color.Black
        Me.tb_Amount.Location = New System.Drawing.Point(179, 148)
        Me.tb_Amount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Amount.Multiline = True
        Me.tb_Amount.Name = "tb_Amount"
        Me.tb_Amount.Size = New System.Drawing.Size(360, 96)
        Me.tb_Amount.TabIndex = 15
        Me.tb_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(414, 434)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(125, 64)
        Me.btn_Cancel.TabIndex = 18
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Go
        '
        Me.btn_Go.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Go.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Go.ForeColor = System.Drawing.Color.White
        Me.btn_Go.Location = New System.Drawing.Point(283, 434)
        Me.btn_Go.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(125, 64)
        Me.btn_Go.TabIndex = 17
        Me.btn_Go.Text = "Save"
        Me.btn_Go.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Date:"
        '
        'dtp_transDate
        '
        Me.dtp_transDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_transDate.Location = New System.Drawing.Point(179, 94)
        Me.dtp_transDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_transDate.Name = "dtp_transDate"
        Me.dtp_transDate.Size = New System.Drawing.Size(360, 31)
        Me.dtp_transDate.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Remarks:"
        '
        'tb_Remarks
        '
        Me.tb_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Remarks.Location = New System.Drawing.Point(179, 274)
        Me.tb_Remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Remarks.Multiline = True
        Me.tb_Remarks.Name = "tb_Remarks"
        Me.tb_Remarks.Size = New System.Drawing.Size(360, 132)
        Me.tb_Remarks.TabIndex = 16
        '
        'frmCash_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 524)
        Me.Controls.Add(Me.tb_Amount)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Go)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_transDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Remarks)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCash_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCash_in"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lbl_cash_Out As Label
    Friend WithEvents lbl_cash_In As Label
    Friend WithEvents tb_Amount As TextBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Go As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_transDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Remarks As TextBox
End Class
