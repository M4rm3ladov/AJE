<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSearch))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_Top = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.pnl_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_Expendable = New System.Windows.Forms.Panel()
        Me.lbl_Expendable = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_Balance = New System.Windows.Forms.Panel()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.pnl_Left = New System.Windows.Forms.Panel()
        Me.pnl_Right = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Gname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Add = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.pnl_Top.SuspendLayout()
        Me.pnl_Bottom.SuspendLayout()
        Me.pnl_Expendable.SuspendLayout()
        Me.pnl_Balance.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Type)
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1691, 55)
        Me.Panel1.TabIndex = 17
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.ForeColor = System.Drawing.Color.White
        Me.lbl_Type.Location = New System.Drawing.Point(819, 14)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(53, 26)
        Me.lbl_Type.TabIndex = 56
        Me.lbl_Type.Text = "type"
        Me.lbl_Type.Visible = False
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(1633, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(58, 55)
        Me.btn_Close.TabIndex = 55
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer List"
        '
        'pnl_Top
        '
        Me.pnl_Top.Controls.Add(Me.Label1)
        Me.pnl_Top.Controls.Add(Me.tb_Search)
        Me.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Top.Location = New System.Drawing.Point(0, 55)
        Me.pnl_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_Top.Name = "pnl_Top"
        Me.pnl_Top.Size = New System.Drawing.Size(1691, 82)
        Me.pnl_Top.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Search.Location = New System.Drawing.Point(127, 20)
        Me.tb_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Search.MaxLength = 50
        Me.tb_Search.Multiline = True
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.ShortcutsEnabled = False
        Me.tb_Search.Size = New System.Drawing.Size(994, 43)
        Me.tb_Search.TabIndex = 3
        '
        'pnl_Bottom
        '
        Me.pnl_Bottom.Controls.Add(Me.pnl_Expendable)
        Me.pnl_Bottom.Controls.Add(Me.pnl_Balance)
        Me.pnl_Bottom.Controls.Add(Me.lbl_row_Count)
        Me.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Bottom.Location = New System.Drawing.Point(0, 672)
        Me.pnl_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_Bottom.Name = "pnl_Bottom"
        Me.pnl_Bottom.Size = New System.Drawing.Size(1691, 94)
        Me.pnl_Bottom.TabIndex = 27
        '
        'pnl_Expendable
        '
        Me.pnl_Expendable.Controls.Add(Me.lbl_Expendable)
        Me.pnl_Expendable.Controls.Add(Me.Label4)
        Me.pnl_Expendable.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Expendable.Location = New System.Drawing.Point(232, 0)
        Me.pnl_Expendable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_Expendable.Name = "pnl_Expendable"
        Me.pnl_Expendable.Size = New System.Drawing.Size(713, 94)
        Me.pnl_Expendable.TabIndex = 30
        '
        'lbl_Expendable
        '
        Me.lbl_Expendable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Expendable.BackColor = System.Drawing.Color.Black
        Me.lbl_Expendable.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Expendable.ForeColor = System.Drawing.Color.Green
        Me.lbl_Expendable.Location = New System.Drawing.Point(330, 16)
        Me.lbl_Expendable.Name = "lbl_Expendable"
        Me.lbl_Expendable.Size = New System.Drawing.Size(370, 62)
        Me.lbl_Expendable.TabIndex = 27
        Me.lbl_Expendable.Text = "0.00"
        Me.lbl_Expendable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 55)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Expendable:"
        '
        'pnl_Balance
        '
        Me.pnl_Balance.Controls.Add(Me.lbl_Balance)
        Me.pnl_Balance.Controls.Add(Me.Label7)
        Me.pnl_Balance.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Balance.Location = New System.Drawing.Point(945, 0)
        Me.pnl_Balance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_Balance.Name = "pnl_Balance"
        Me.pnl_Balance.Size = New System.Drawing.Size(746, 94)
        Me.pnl_Balance.TabIndex = 29
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.BackColor = System.Drawing.Color.Black
        Me.lbl_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.ForeColor = System.Drawing.Color.Green
        Me.lbl_Balance.Location = New System.Drawing.Point(362, 16)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(370, 62)
        Me.lbl_Balance.TabIndex = 27
        Me.lbl_Balance.Text = "0.00"
        Me.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(339, 55)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "User Balance:"
        '
        'lbl_row_Count
        '
        Me.lbl_row_Count.AutoSize = True
        Me.lbl_row_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_row_Count.Location = New System.Drawing.Point(30, 40)
        Me.lbl_row_Count.Name = "lbl_row_Count"
        Me.lbl_row_Count.Size = New System.Drawing.Size(117, 25)
        Me.lbl_row_Count.TabIndex = 9
        Me.lbl_row_Count.Text = "Row Count"
        '
        'pnl_Left
        '
        Me.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_Left.Location = New System.Drawing.Point(0, 137)
        Me.pnl_Left.Name = "pnl_Left"
        Me.pnl_Left.Size = New System.Drawing.Size(16, 535)
        Me.pnl_Left.TabIndex = 29
        '
        'pnl_Right
        '
        Me.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Right.Location = New System.Drawing.Point(1675, 137)
        Me.pnl_Right.Name = "pnl_Right"
        Me.pnl_Right.Size = New System.Drawing.Size(16, 535)
        Me.pnl_Right.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.col_Code, Me.col_Gname, Me.col_Mi, Me.col_Fname, Me.col_Suffix, Me.Column1, Me.col_Balance, Me.col_Add})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(16, 137)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1659, 535)
        Me.DataGridView1.TabIndex = 31
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'col_Code
        '
        Me.col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Code.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_Code.HeaderText = "Code"
        Me.col_Code.MinimumWidth = 6
        Me.col_Code.Name = "col_Code"
        Me.col_Code.ReadOnly = True
        Me.col_Code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Code.Width = 96
        '
        'col_Gname
        '
        Me.col_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Gname.DefaultCellStyle = DataGridViewCellStyle12
        Me.col_Gname.HeaderText = "Given Name"
        Me.col_Gname.MinimumWidth = 6
        Me.col_Gname.Name = "col_Gname"
        Me.col_Gname.ReadOnly = True
        Me.col_Gname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Mi
        '
        Me.col_Mi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Mi.DefaultCellStyle = DataGridViewCellStyle13
        Me.col_Mi.HeaderText = "M.I."
        Me.col_Mi.MinimumWidth = 6
        Me.col_Mi.Name = "col_Mi"
        Me.col_Mi.ReadOnly = True
        Me.col_Mi.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Mi.Width = 80
        '
        'col_Fname
        '
        Me.col_Fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Fname.DefaultCellStyle = DataGridViewCellStyle14
        Me.col_Fname.HeaderText = "Family Name"
        Me.col_Fname.MinimumWidth = 6
        Me.col_Fname.Name = "col_Fname"
        Me.col_Fname.ReadOnly = True
        Me.col_Fname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Suffix
        '
        Me.col_Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Suffix.DefaultCellStyle = DataGridViewCellStyle15
        Me.col_Suffix.HeaderText = "Suffix"
        Me.col_Suffix.MinimumWidth = 6
        Me.col_Suffix.Name = "col_Suffix"
        Me.col_Suffix.ReadOnly = True
        Me.col_Suffix.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Suffix.Width = 97
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column1.HeaderText = "Credit Limit"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 134
        '
        'col_Balance
        '
        Me.col_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Balance.HeaderText = "Balance"
        Me.col_Balance.MinimumWidth = 6
        Me.col_Balance.Name = "col_Balance"
        Me.col_Balance.Visible = False
        '
        'col_Add
        '
        Me.col_Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.col_Add.DefaultCellStyle = DataGridViewCellStyle17
        Me.col_Add.HeaderText = ""
        Me.col_Add.MinimumWidth = 6
        Me.col_Add.Name = "col_Add"
        Me.col_Add.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Add.Width = 29
        '
        'frmCustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1691, 766)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnl_Right)
        Me.Controls.Add(Me.pnl_Left)
        Me.Controls.Add(Me.pnl_Bottom)
        Me.Controls.Add(Me.pnl_Top)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerSearch"
        Me.Text = "frmCustomerSearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_Top.ResumeLayout(False)
        Me.pnl_Top.PerformLayout()
        Me.pnl_Bottom.ResumeLayout(False)
        Me.pnl_Bottom.PerformLayout()
        Me.pnl_Expendable.ResumeLayout(False)
        Me.pnl_Expendable.PerformLayout()
        Me.pnl_Balance.ResumeLayout(False)
        Me.pnl_Balance.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Type As Label
    Friend WithEvents pnl_Top As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents pnl_Bottom As Panel
    Friend WithEvents pnl_Expendable As Panel
    Friend WithEvents lbl_Expendable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnl_Balance As Panel
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents pnl_Left As Panel
    Friend WithEvents pnl_Right As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_Code As DataGridViewTextBoxColumn
    Friend WithEvents col_Gname As DataGridViewTextBoxColumn
    Friend WithEvents col_Mi As DataGridViewTextBoxColumn
    Friend WithEvents col_Fname As DataGridViewTextBoxColumn
    Friend WithEvents col_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_Balance As DataGridViewTextBoxColumn
    Friend WithEvents col_Add As DataGridViewButtonColumn
End Class
