﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_amount_Receivable = New System.Windows.Forms.Label()
        Me.pnlBalance = New System.Windows.Forms.Panel()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cbo_Category = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlClose = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.dgCustomers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Gname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlBottom.SuspendLayout()
        Me.pnlBalance.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlClose.SuspendLayout()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lbl_row_Count)
        Me.pnlBottom.Controls.Add(Me.Label2)
        Me.pnlBottom.Controls.Add(Me.lbl_amount_Receivable)
        Me.pnlBottom.Controls.Add(Me.pnlBalance)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 634)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1500, 96)
        Me.pnlBottom.TabIndex = 3
        '
        'lbl_row_Count
        '
        Me.lbl_row_Count.AutoSize = True
        Me.lbl_row_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_row_Count.Location = New System.Drawing.Point(37, 38)
        Me.lbl_row_Count.Name = "lbl_row_Count"
        Me.lbl_row_Count.Size = New System.Drawing.Size(117, 25)
        Me.lbl_row_Count.TabIndex = 31
        Me.lbl_row_Count.Text = "Row Count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(281, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 37)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Amount(s) Receivable:"
        '
        'lbl_amount_Receivable
        '
        Me.lbl_amount_Receivable.BackColor = System.Drawing.Color.Black
        Me.lbl_amount_Receivable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount_Receivable.ForeColor = System.Drawing.Color.Green
        Me.lbl_amount_Receivable.Location = New System.Drawing.Point(709, 31)
        Me.lbl_amount_Receivable.Name = "lbl_amount_Receivable"
        Me.lbl_amount_Receivable.Size = New System.Drawing.Size(193, 42)
        Me.lbl_amount_Receivable.TabIndex = 29
        Me.lbl_amount_Receivable.Text = "Row Count"
        Me.lbl_amount_Receivable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlBalance
        '
        Me.pnlBalance.Controls.Add(Me.lbl_Balance)
        Me.pnlBalance.Controls.Add(Me.Label7)
        Me.pnlBalance.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBalance.Location = New System.Drawing.Point(792, 0)
        Me.pnlBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBalance.Name = "pnlBalance"
        Me.pnlBalance.Size = New System.Drawing.Size(708, 96)
        Me.pnlBalance.TabIndex = 28
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.BackColor = System.Drawing.Color.Black
        Me.lbl_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.ForeColor = System.Drawing.Color.Green
        Me.lbl_Balance.Location = New System.Drawing.Point(337, 16)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(340, 62)
        Me.lbl_Balance.TabIndex = 27
        Me.lbl_Balance.Text = "200,000.00"
        Me.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(326, 55)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "User Balance:"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.Panel3)
        Me.pnlTop.Controls.Add(Me.pnlHeader)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1500, 224)
        Me.pnlTop.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btn_Add)
        Me.Panel3.Controls.Add(Me.cbo_Category)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tb_Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 110)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1500, 114)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(919, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filter By:"
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.White
        Me.btn_Add.Location = New System.Drawing.Point(1275, 25)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(184, 68)
        Me.btn_Add.TabIndex = 5
        Me.btn_Add.Text = "Add Customer"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'cbo_Category
        '
        Me.cbo_Category.BackColor = System.Drawing.Color.White
        Me.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Category.FormattingEnabled = True
        Me.cbo_Category.Items.AddRange(New Object() {"Name", "Code"})
        Me.cbo_Category.Location = New System.Drawing.Point(1040, 40)
        Me.cbo_Category.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_Category.Name = "cbo_Category"
        Me.cbo_Category.Size = New System.Drawing.Size(205, 37)
        Me.cbo_Category.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Search.Location = New System.Drawing.Point(143, 42)
        Me.tb_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(745, 35)
        Me.tb_Search.TabIndex = 3
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.pnlClose)
        Me.pnlHeader.Controls.Add(Me.Label21)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 106)
        Me.pnlHeader.TabIndex = 3
        '
        'pnlClose
        '
        Me.pnlClose.Controls.Add(Me.btn_Close)
        Me.pnlClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlClose.Location = New System.Drawing.Point(1384, 0)
        Me.pnlClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(116, 106)
        Me.pnlClose.TabIndex = 3
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
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(32, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(251, 52)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Customers"
        '
        'pnlLeft
        '
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 224)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(31, 410)
        Me.pnlLeft.TabIndex = 5
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1469, 224)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(31, 410)
        Me.pnlRight.TabIndex = 6
        '
        'dgCustomers
        '
        Me.dgCustomers.AllowUserToAddRows = False
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column6, Me.col_Code, Me.col_Gname, Me.col_Mi, Me.col_Fname, Me.col_Suffix, Me.Column1, Me.col_Balance, Me.col_Edit, Me.col_Delete})
        Me.dgCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCustomers.EnableHeadersVisualStyles = False
        Me.dgCustomers.Location = New System.Drawing.Point(31, 224)
        Me.dgCustomers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgCustomers.Name = "dgCustomers"
        Me.dgCustomers.RowHeadersVisible = False
        Me.dgCustomers.RowHeadersWidth = 51
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White
        Me.dgCustomers.RowsDefaultCellStyle = DataGridViewCellStyle38
        Me.dgCustomers.RowTemplate.Height = 24
        Me.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomers.Size = New System.Drawing.Size(1438, 410)
        Me.dgCustomers.TabIndex = 9
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle28
        Me.Column6.HeaderText = "#"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 59
        '
        'col_Code
        '
        Me.col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Code.DefaultCellStyle = DataGridViewCellStyle29
        Me.col_Code.HeaderText = "Customer Code"
        Me.col_Code.MinimumWidth = 6
        Me.col_Code.Name = "col_Code"
        Me.col_Code.ReadOnly = True
        Me.col_Code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Code.Width = 170
        '
        'col_Gname
        '
        Me.col_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Gname.DefaultCellStyle = DataGridViewCellStyle30
        Me.col_Gname.HeaderText = "Given Name"
        Me.col_Gname.MinimumWidth = 6
        Me.col_Gname.Name = "col_Gname"
        Me.col_Gname.ReadOnly = True
        Me.col_Gname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Mi
        '
        Me.col_Mi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Mi.DefaultCellStyle = DataGridViewCellStyle31
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
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Fname.DefaultCellStyle = DataGridViewCellStyle32
        Me.col_Fname.HeaderText = "Family Name"
        Me.col_Fname.MinimumWidth = 6
        Me.col_Fname.Name = "col_Fname"
        Me.col_Fname.ReadOnly = True
        Me.col_Fname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Suffix
        '
        Me.col_Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Suffix.DefaultCellStyle = DataGridViewCellStyle33
        Me.col_Suffix.HeaderText = "Suffix"
        Me.col_Suffix.MinimumWidth = 6
        Me.col_Suffix.Name = "col_Suffix"
        Me.col_Suffix.ReadOnly = True
        Me.col_Suffix.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Suffix.Width = 97
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle34
        Me.Column1.HeaderText = "Credit Limit"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 134
        '
        'col_Balance
        '
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Balance.DefaultCellStyle = DataGridViewCellStyle35
        Me.col_Balance.HeaderText = "Balance"
        Me.col_Balance.MinimumWidth = 6
        Me.col_Balance.Name = "col_Balance"
        Me.col_Balance.Visible = False
        Me.col_Balance.Width = 125
        '
        'col_Edit
        '
        Me.col_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.White
        Me.col_Edit.DefaultCellStyle = DataGridViewCellStyle36
        Me.col_Edit.HeaderText = ""
        Me.col_Edit.MinimumWidth = 6
        Me.col_Edit.Name = "col_Edit"
        Me.col_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Edit.Width = 29
        '
        'col_Delete
        '
        Me.col_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.White
        Me.col_Delete.DefaultCellStyle = DataGridViewCellStyle37
        Me.col_Delete.HeaderText = ""
        Me.col_Delete.MinimumWidth = 6
        Me.col_Delete.Name = "col_Delete"
        Me.col_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Delete.Width = 29
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle39.NullValue = CType(resources.GetObject("DataGridViewCellStyle39.NullValue"), Object)
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 730)
        Me.Controls.Add(Me.dgCustomers)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomers"
        Me.Text = "frmCustomers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlBalance.ResumeLayout(False)
        Me.pnlBalance.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlClose.ResumeLayout(False)
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_amount_Receivable As Label
    Friend WithEvents pnlBalance As Panel
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents cbo_Category As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlClose As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents dgCustomers As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents col_Code As DataGridViewTextBoxColumn
    Friend WithEvents col_Gname As DataGridViewTextBoxColumn
    Friend WithEvents col_Mi As DataGridViewTextBoxColumn
    Friend WithEvents col_Fname As DataGridViewTextBoxColumn
    Friend WithEvents col_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_Balance As DataGridViewTextBoxColumn
    Friend WithEvents col_Edit As DataGridViewButtonColumn
    Friend WithEvents col_Delete As DataGridViewButtonColumn
End Class