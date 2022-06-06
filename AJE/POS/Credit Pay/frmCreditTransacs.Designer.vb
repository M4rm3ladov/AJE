<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditTransacs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditTransacs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_Top = New System.Windows.Forms.Panel()
        Me.pnl_Bottom = New System.Windows.Forms.Panel()
        Me.lbl_due_Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnl_Left = New System.Windows.Forms.Panel()
        Me.pnl_Right = New System.Windows.Forms.Panel()
        Me.dg_Cred_Transac = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnl_Bottom.SuspendLayout()
        CType(Me.dg_Cred_Transac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 36)
        Me.Panel1.TabIndex = 17
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(828, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(39, 36)
        Me.btn_Close.TabIndex = 55
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credit Transaction"
        '
        'pnl_Top
        '
        Me.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Top.Location = New System.Drawing.Point(0, 36)
        Me.pnl_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_Top.Name = "pnl_Top"
        Me.pnl_Top.Size = New System.Drawing.Size(867, 13)
        Me.pnl_Top.TabIndex = 18
        '
        'pnl_Bottom
        '
        Me.pnl_Bottom.Controls.Add(Me.lbl_due_Total)
        Me.pnl_Bottom.Controls.Add(Me.Label7)
        Me.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Bottom.Location = New System.Drawing.Point(0, 429)
        Me.pnl_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_Bottom.Name = "pnl_Bottom"
        Me.pnl_Bottom.Size = New System.Drawing.Size(867, 66)
        Me.pnl_Bottom.TabIndex = 19
        '
        'lbl_due_Total
        '
        Me.lbl_due_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_due_Total.BackColor = System.Drawing.Color.Black
        Me.lbl_due_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_due_Total.ForeColor = System.Drawing.Color.Green
        Me.lbl_due_Total.Location = New System.Drawing.Point(638, 10)
        Me.lbl_due_Total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_due_Total.Name = "lbl_due_Total"
        Me.lbl_due_Total.Size = New System.Drawing.Size(227, 46)
        Me.lbl_due_Total.TabIndex = 27
        Me.lbl_due_Total.Text = "0.00"
        Me.lbl_due_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 37)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Due Total:"
        '
        'pnl_Left
        '
        Me.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_Left.Location = New System.Drawing.Point(0, 49)
        Me.pnl_Left.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_Left.Name = "pnl_Left"
        Me.pnl_Left.Size = New System.Drawing.Size(10, 380)
        Me.pnl_Left.TabIndex = 20
        '
        'pnl_Right
        '
        Me.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Right.Location = New System.Drawing.Point(858, 49)
        Me.pnl_Right.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_Right.Name = "pnl_Right"
        Me.pnl_Right.Size = New System.Drawing.Size(9, 380)
        Me.pnl_Right.TabIndex = 21
        '
        'dg_Cred_Transac
        '
        Me.dg_Cred_Transac.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Cred_Transac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_Cred_Transac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Cred_Transac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column1, Me.Column2})
        Me.dg_Cred_Transac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Cred_Transac.Location = New System.Drawing.Point(10, 49)
        Me.dg_Cred_Transac.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dg_Cred_Transac.Name = "dg_Cred_Transac"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Cred_Transac.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_Cred_Transac.RowHeadersVisible = False
        Me.dg_Cred_Transac.RowHeadersWidth = 51
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dg_Cred_Transac.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_Cred_Transac.RowTemplate.Height = 24
        Me.dg_Cred_Transac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Cred_Transac.Size = New System.Drawing.Size(848, 380)
        Me.dg_Cred_Transac.TabIndex = 22
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column8.HeaderText = "Description"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column9.HeaderText = "Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 69
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column1.HeaderText = "Qty"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 58
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column2.HeaderText = "Total"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 69
        '
        'frmCreditTransacs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 495)
        Me.Controls.Add(Me.dg_Cred_Transac)
        Me.Controls.Add(Me.pnl_Right)
        Me.Controls.Add(Me.pnl_Left)
        Me.Controls.Add(Me.pnl_Bottom)
        Me.Controls.Add(Me.pnl_Top)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCreditTransacs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCreditTransacs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_Bottom.ResumeLayout(False)
        Me.pnl_Bottom.PerformLayout()
        CType(Me.dg_Cred_Transac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pnl_Top As Panel
    Friend WithEvents pnl_Bottom As Panel
    Friend WithEvents lbl_due_Total As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnl_Left As Panel
    Friend WithEvents pnl_Right As Panel
    Friend WithEvents dg_Cred_Transac As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
