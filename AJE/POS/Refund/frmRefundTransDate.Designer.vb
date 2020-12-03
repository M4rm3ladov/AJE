<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefundTransDate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Remarks = New System.Windows.Forms.TextBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Continue = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 38)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Remarks:"
        '
        'tb_Remarks
        '
        Me.tb_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Remarks.Location = New System.Drawing.Point(97, 250)
        Me.tb_Remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Remarks.Multiline = True
        Me.tb_Remarks.Name = "tb_Remarks"
        Me.tb_Remarks.Size = New System.Drawing.Size(360, 132)
        Me.tb_Remarks.TabIndex = 39
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(332, 424)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(125, 64)
        Me.btn_Back.TabIndex = 38
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Continue
        '
        Me.btn_Continue.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Continue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Continue.ForeColor = System.Drawing.Color.White
        Me.btn_Continue.Location = New System.Drawing.Point(201, 424)
        Me.btn_Continue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Continue.Name = "btn_Continue"
        Me.btn_Continue.Size = New System.Drawing.Size(125, 64)
        Me.btn_Continue.TabIndex = 37
        Me.btn_Continue.Text = "Continue"
        Me.btn_Continue.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 38)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Transaction Date:"
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Location = New System.Drawing.Point(95, 111)
        Me.dtp_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(361, 31)
        Me.dtp_Date.TabIndex = 35
        '
        'frmRefundTransDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Remarks)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Continue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_Date)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRefundTransDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRefundTransDate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Remarks As TextBox
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Continue As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_Date As DateTimePicker
End Class
