<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalance
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
        Me.tb_initial_Bal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Verify = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_initial_Bal
        '
        Me.tb_initial_Bal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_initial_Bal.Location = New System.Drawing.Point(63, 101)
        Me.tb_initial_Bal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_initial_Bal.MaxLength = 0
        Me.tb_initial_Bal.Multiline = True
        Me.tb_initial_Bal.Name = "tb_initial_Bal"
        Me.tb_initial_Bal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_initial_Bal.Size = New System.Drawing.Size(345, 85)
        Me.tb_initial_Bal.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Initial Balance:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(283, 216)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(125, 64)
        Me.btn_Cancel.TabIndex = 16
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Verify
        '
        Me.btn_Verify.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Verify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Verify.ForeColor = System.Drawing.Color.White
        Me.btn_Verify.Location = New System.Drawing.Point(152, 216)
        Me.btn_Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Verify.Name = "btn_Verify"
        Me.btn_Verify.Size = New System.Drawing.Size(125, 64)
        Me.btn_Verify.TabIndex = 14
        Me.btn_Verify.Text = "Set"
        Me.btn_Verify.UseVisualStyleBackColor = False
        '
        'frmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 314)
        Me.Controls.Add(Me.tb_initial_Bal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Verify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBalance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_initial_Bal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Verify As Button
End Class
