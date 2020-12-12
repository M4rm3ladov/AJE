<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditPay
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.tc_Credit = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dg_Transactions = New System.Windows.Forms.DataGridView()
        Me.pnl_settle_bal_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_settle_bal_Balance = New System.Windows.Forms.Panel()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_settle_bal_Left = New System.Windows.Forms.Panel()
        Me.pnl_settle_bal_Right = New System.Windows.Forms.Panel()
        Me.tbl_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.pnl_settle_bal_Top = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_cb_Search = New System.Windows.Forms.ComboBox()
        Me.btn_load_Orders = New System.Windows.Forms.Button()
        Me.dtp_cb_To = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_cb_From = New System.Windows.Forms.DateTimePicker()
        Me.lbl_customer_Id = New System.Windows.Forms.Label()
        Me.lbl_Customer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dg_History = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_history_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_history_Left = New System.Windows.Forms.Panel()
        Me.pnl_history_Right = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_custSearch = New System.Windows.Forms.Label()
        Me.lbl_custId = New System.Windows.Forms.Label()
        Me.dtp_To = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_CustName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_From = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_History = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        Me.tc_Credit.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_Transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_settle_bal_Bottom.SuspendLayout()
        Me.pnl_settle_bal_Balance.SuspendLayout()
        Me.tbl_Buttons.SuspendLayout()
        Me.pnl_settle_bal_Top.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_History, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lbl_Header)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1744, 60)
        Me.pnlHeader.TabIndex = 3
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(14, 19)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(163, 26)
        Me.lbl_Header.TabIndex = 4
        Me.lbl_Header.Text = "Credit Payment"
        '
        'tc_Credit
        '
        Me.tc_Credit.Controls.Add(Me.TabPage1)
        Me.tc_Credit.Controls.Add(Me.TabPage2)
        Me.tc_Credit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Credit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_Credit.Location = New System.Drawing.Point(0, 60)
        Me.tc_Credit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tc_Credit.Name = "tc_Credit"
        Me.tc_Credit.SelectedIndex = 0
        Me.tc_Credit.Size = New System.Drawing.Size(1744, 862)
        Me.tc_Credit.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_Transactions)
        Me.TabPage1.Controls.Add(Me.pnl_settle_bal_Bottom)
        Me.TabPage1.Controls.Add(Me.pnl_settle_bal_Left)
        Me.TabPage1.Controls.Add(Me.pnl_settle_bal_Right)
        Me.TabPage1.Controls.Add(Me.tbl_Buttons)
        Me.TabPage1.Controls.Add(Me.pnl_settle_bal_Top)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1736, 820)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settle Credit Balance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dg_Transactions
        '
        Me.dg_Transactions.AllowUserToAddRows = False
        Me.dg_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Transactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column8, Me.Column4, Me.DataGridViewTextBoxColumn5, Me.Column3, Me.Column2})
        Me.dg_Transactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Transactions.Location = New System.Drawing.Point(14, 173)
        Me.dg_Transactions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dg_Transactions.Name = "dg_Transactions"
        Me.dg_Transactions.RowHeadersVisible = False
        Me.dg_Transactions.RowHeadersWidth = 51
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dg_Transactions.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_Transactions.RowTemplate.Height = 24
        Me.dg_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Transactions.Size = New System.Drawing.Size(1410, 539)
        Me.dg_Transactions.TabIndex = 23
        '
        'pnl_settle_bal_Bottom
        '
        Me.pnl_settle_bal_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_settle_bal_Bottom.Controls.Add(Me.pnl_settle_bal_Balance)
        Me.pnl_settle_bal_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_settle_bal_Bottom.Location = New System.Drawing.Point(14, 712)
        Me.pnl_settle_bal_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_settle_bal_Bottom.Name = "pnl_settle_bal_Bottom"
        Me.pnl_settle_bal_Bottom.Size = New System.Drawing.Size(1410, 104)
        Me.pnl_settle_bal_Bottom.TabIndex = 24
        '
        'pnl_settle_bal_Balance
        '
        Me.pnl_settle_bal_Balance.Controls.Add(Me.lbl_Balance)
        Me.pnl_settle_bal_Balance.Controls.Add(Me.Label2)
        Me.pnl_settle_bal_Balance.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_settle_bal_Balance.Location = New System.Drawing.Point(682, 0)
        Me.pnl_settle_bal_Balance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_settle_bal_Balance.Name = "pnl_settle_bal_Balance"
        Me.pnl_settle_bal_Balance.Size = New System.Drawing.Size(728, 104)
        Me.pnl_settle_bal_Balance.TabIndex = 35
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.BackColor = System.Drawing.Color.Black
        Me.lbl_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.ForeColor = System.Drawing.Color.Green
        Me.lbl_Balance.Location = New System.Drawing.Point(351, 18)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(370, 62)
        Me.lbl_Balance.TabIndex = 33
        Me.lbl_Balance.Text = "0.00"
        Me.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 55)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "User Balance:"
        '
        'pnl_settle_bal_Left
        '
        Me.pnl_settle_bal_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_settle_bal_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_settle_bal_Left.Location = New System.Drawing.Point(3, 173)
        Me.pnl_settle_bal_Left.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_settle_bal_Left.Name = "pnl_settle_bal_Left"
        Me.pnl_settle_bal_Left.Size = New System.Drawing.Size(11, 643)
        Me.pnl_settle_bal_Left.TabIndex = 22
        '
        'pnl_settle_bal_Right
        '
        Me.pnl_settle_bal_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_settle_bal_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_settle_bal_Right.Location = New System.Drawing.Point(1424, 173)
        Me.pnl_settle_bal_Right.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_settle_bal_Right.Name = "pnl_settle_bal_Right"
        Me.pnl_settle_bal_Right.Size = New System.Drawing.Size(15, 643)
        Me.pnl_settle_bal_Right.TabIndex = 21
        '
        'tbl_Buttons
        '
        Me.tbl_Buttons.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbl_Buttons.ColumnCount = 1
        Me.tbl_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl_Buttons.Controls.Add(Me.btn_Back, 0, 3)
        Me.tbl_Buttons.Controls.Add(Me.btn_New, 0, 2)
        Me.tbl_Buttons.Controls.Add(Me.btn_Checkout, 0, 1)
        Me.tbl_Buttons.Controls.Add(Me.btn_Load, 0, 0)
        Me.tbl_Buttons.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbl_Buttons.Location = New System.Drawing.Point(1439, 173)
        Me.tbl_Buttons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbl_Buttons.Name = "tbl_Buttons"
        Me.tbl_Buttons.RowCount = 4
        Me.tbl_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbl_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbl_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbl_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbl_Buttons.Size = New System.Drawing.Size(294, 643)
        Me.tbl_Buttons.TabIndex = 20
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(3, 484)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(288, 155)
        Me.btn_Back.TabIndex = 39
        Me.btn_Back.Text = "[ESC] Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_New
        '
        Me.btn_New.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.ForeColor = System.Drawing.Color.White
        Me.btn_New.Location = New System.Drawing.Point(3, 324)
        Me.btn_New.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(288, 152)
        Me.btn_New.TabIndex = 34
        Me.btn_New.Text = "[F2] New Payment"
        Me.btn_New.UseVisualStyleBackColor = False
        '
        'btn_Checkout
        '
        Me.btn_Checkout.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Checkout.ForeColor = System.Drawing.Color.White
        Me.btn_Checkout.Location = New System.Drawing.Point(3, 164)
        Me.btn_Checkout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(288, 152)
        Me.btn_Checkout.TabIndex = 36
        Me.btn_Checkout.Text = "[F5] Checkout"
        Me.btn_Checkout.UseVisualStyleBackColor = False
        '
        'btn_Load
        '
        Me.btn_Load.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Load.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load.ForeColor = System.Drawing.Color.White
        Me.btn_Load.Location = New System.Drawing.Point(3, 4)
        Me.btn_Load.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(288, 152)
        Me.btn_Load.TabIndex = 40
        Me.btn_Load.Text = "[F1] View Transactions"
        Me.btn_Load.UseVisualStyleBackColor = False
        '
        'pnl_settle_bal_Top
        '
        Me.pnl_settle_bal_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_settle_bal_Top.Controls.Add(Me.Label3)
        Me.pnl_settle_bal_Top.Controls.Add(Me.cbo_cb_Search)
        Me.pnl_settle_bal_Top.Controls.Add(Me.btn_load_Orders)
        Me.pnl_settle_bal_Top.Controls.Add(Me.dtp_cb_To)
        Me.pnl_settle_bal_Top.Controls.Add(Me.Label1)
        Me.pnl_settle_bal_Top.Controls.Add(Me.dtp_cb_From)
        Me.pnl_settle_bal_Top.Controls.Add(Me.lbl_customer_Id)
        Me.pnl_settle_bal_Top.Controls.Add(Me.lbl_Customer)
        Me.pnl_settle_bal_Top.Controls.Add(Me.Label4)
        Me.pnl_settle_bal_Top.Controls.Add(Me.tb_Name)
        Me.pnl_settle_bal_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_settle_bal_Top.Location = New System.Drawing.Point(3, 4)
        Me.pnl_settle_bal_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_settle_bal_Top.Name = "pnl_settle_bal_Top"
        Me.pnl_settle_bal_Top.Size = New System.Drawing.Size(1730, 169)
        Me.pnl_settle_bal_Top.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 26)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Search By:"
        '
        'cbo_cb_Search
        '
        Me.cbo_cb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cb_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_cb_Search.FormattingEnabled = True
        Me.cbo_cb_Search.Items.AddRange(New Object() {"Sale Date", "Input Date"})
        Me.cbo_cb_Search.Location = New System.Drawing.Point(221, 15)
        Me.cbo_cb_Search.Name = "cbo_cb_Search"
        Me.cbo_cb_Search.Size = New System.Drawing.Size(165, 40)
        Me.cbo_cb_Search.TabIndex = 47
        '
        'btn_load_Orders
        '
        Me.btn_load_Orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_Orders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_Orders.ForeColor = System.Drawing.Color.White
        Me.btn_load_Orders.Location = New System.Drawing.Point(1369, 63)
        Me.btn_load_Orders.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_Orders.Name = "btn_load_Orders"
        Me.btn_load_Orders.Size = New System.Drawing.Size(181, 58)
        Me.btn_load_Orders.TabIndex = 46
        Me.btn_load_Orders.Text = "Load Orders"
        Me.btn_load_Orders.UseVisualStyleBackColor = False
        '
        'dtp_cb_To
        '
        Me.dtp_cb_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cb_To.Location = New System.Drawing.Point(1140, 20)
        Me.dtp_cb_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cb_To.Name = "dtp_cb_To"
        Me.dtp_cb_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_cb_To.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Transaction Date (From-To):"
        '
        'dtp_cb_From
        '
        Me.dtp_cb_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cb_From.Location = New System.Drawing.Point(713, 20)
        Me.dtp_cb_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cb_From.Name = "dtp_cb_From"
        Me.dtp_cb_From.Size = New System.Drawing.Size(410, 35)
        Me.dtp_cb_From.TabIndex = 43
        '
        'lbl_customer_Id
        '
        Me.lbl_customer_Id.AutoSize = True
        Me.lbl_customer_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_Id.Location = New System.Drawing.Point(619, 113)
        Me.lbl_customer_Id.Name = "lbl_customer_Id"
        Me.lbl_customer_Id.Size = New System.Drawing.Size(0, 29)
        Me.lbl_customer_Id.TabIndex = 42
        Me.lbl_customer_Id.Visible = False
        '
        'lbl_Customer
        '
        Me.lbl_Customer.AutoSize = True
        Me.lbl_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer.Location = New System.Drawing.Point(216, 125)
        Me.lbl_Customer.Name = "lbl_Customer"
        Me.lbl_Customer.Size = New System.Drawing.Size(324, 26)
        Me.lbl_Customer.TabIndex = 41
        Me.lbl_Customer.Text = "[ Click here to search customer ]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Customer Name:"
        '
        'tb_Name
        '
        Me.tb_Name.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Name.Location = New System.Drawing.Point(221, 67)
        Me.tb_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_Name.Multiline = True
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.ReadOnly = True
        Me.tb_Name.Size = New System.Drawing.Size(1124, 54)
        Me.tb_Name.TabIndex = 34
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1736, 820)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payment History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dg_History)
        Me.Panel2.Controls.Add(Me.pnl_history_Bottom)
        Me.Panel2.Controls.Add(Me.pnl_history_Left)
        Me.Panel2.Controls.Add(Me.pnl_history_Right)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1730, 812)
        Me.Panel2.TabIndex = 0
        '
        'dg_History
        '
        Me.dg_History.AllowUserToAddRows = False
        Me.dg_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_History.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.Column1})
        Me.dg_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_History.Location = New System.Drawing.Point(11, 165)
        Me.dg_History.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dg_History.Name = "dg_History"
        Me.dg_History.RowHeadersVisible = False
        Me.dg_History.RowHeadersWidth = 51
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dg_History.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dg_History.RowTemplate.Height = 24
        Me.dg_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_History.Size = New System.Drawing.Size(1708, 632)
        Me.dg_History.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Receipt No"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "Transaction Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "Payment Amount"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 209
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column1.HeaderText = "Cashier Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pnl_history_Bottom
        '
        Me.pnl_history_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_history_Bottom.Location = New System.Drawing.Point(11, 797)
        Me.pnl_history_Bottom.Name = "pnl_history_Bottom"
        Me.pnl_history_Bottom.Size = New System.Drawing.Size(1708, 15)
        Me.pnl_history_Bottom.TabIndex = 27
        '
        'pnl_history_Left
        '
        Me.pnl_history_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_history_Left.Location = New System.Drawing.Point(0, 165)
        Me.pnl_history_Left.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_history_Left.Name = "pnl_history_Left"
        Me.pnl_history_Left.Size = New System.Drawing.Size(11, 647)
        Me.pnl_history_Left.TabIndex = 26
        '
        'pnl_history_Right
        '
        Me.pnl_history_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_history_Right.Location = New System.Drawing.Point(1719, 165)
        Me.pnl_history_Right.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_history_Right.Name = "pnl_history_Right"
        Me.pnl_history_Right.Size = New System.Drawing.Size(11, 647)
        Me.pnl_history_Right.TabIndex = 24
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.lbl_custSearch)
        Me.Panel5.Controls.Add(Me.lbl_custId)
        Me.Panel5.Controls.Add(Me.dtp_To)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.tb_CustName)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.dtp_From)
        Me.Panel5.Controls.Add(Me.btn_load_History)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1730, 165)
        Me.Panel5.TabIndex = 2
        '
        'lbl_custSearch
        '
        Me.lbl_custSearch.AutoSize = True
        Me.lbl_custSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custSearch.Location = New System.Drawing.Point(327, 118)
        Me.lbl_custSearch.Name = "lbl_custSearch"
        Me.lbl_custSearch.Size = New System.Drawing.Size(324, 26)
        Me.lbl_custSearch.TabIndex = 42
        Me.lbl_custSearch.Text = "[ Click here to search customer ]"
        '
        'lbl_custId
        '
        Me.lbl_custId.AutoSize = True
        Me.lbl_custId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custId.Location = New System.Drawing.Point(1216, 17)
        Me.lbl_custId.Name = "lbl_custId"
        Me.lbl_custId.Size = New System.Drawing.Size(178, 26)
        Me.lbl_custId.TabIndex = 21
        Me.lbl_custId.Text = "Customer Name:"
        Me.lbl_custId.Visible = False
        '
        'dtp_To
        '
        Me.dtp_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_To.Location = New System.Drawing.Point(761, 17)
        Me.dtp_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_To.Name = "dtp_To"
        Me.dtp_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_To.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 26)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Customer Name:"
        '
        'tb_CustName
        '
        Me.tb_CustName.BackColor = System.Drawing.SystemColors.Window
        Me.tb_CustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_CustName.Location = New System.Drawing.Point(332, 60)
        Me.tb_CustName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_CustName.Multiline = True
        Me.tb_CustName.Name = "tb_CustName"
        Me.tb_CustName.ReadOnly = True
        Me.tb_CustName.Size = New System.Drawing.Size(856, 54)
        Me.tb_CustName.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 26)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Transaction Date (From-To):"
        '
        'dtp_From
        '
        Me.dtp_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_From.Location = New System.Drawing.Point(332, 17)
        Me.dtp_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_From.Name = "dtp_From"
        Me.dtp_From.Size = New System.Drawing.Size(410, 35)
        Me.dtp_From.TabIndex = 15
        '
        'btn_load_History
        '
        Me.btn_load_History.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_History.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_History.ForeColor = System.Drawing.Color.White
        Me.btn_load_History.Location = New System.Drawing.Point(1204, 56)
        Me.btn_load_History.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_History.Name = "btn_load_History"
        Me.btn_load_History.Size = New System.Drawing.Size(181, 58)
        Me.btn_load_History.TabIndex = 5
        Me.btn_load_History.Text = "Load History"
        Me.btn_load_History.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column8.HeaderText = "Input Date"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.Width = 157
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Sale Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 154
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Initial Payment"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 204
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Total"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 104
        '
        'frmCreditPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1744, 922)
        Me.Controls.Add(Me.tc_Credit)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreditPay"
        Me.Text = "frmCreditPay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tc_Credit.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg_Transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_settle_bal_Bottom.ResumeLayout(False)
        Me.pnl_settle_bal_Balance.ResumeLayout(False)
        Me.pnl_settle_bal_Balance.PerformLayout()
        Me.tbl_Buttons.ResumeLayout(False)
        Me.pnl_settle_bal_Top.ResumeLayout(False)
        Me.pnl_settle_bal_Top.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dg_History, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lbl_Header As Label
    Friend WithEvents tc_Credit As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dg_Transactions As DataGridView
    Friend WithEvents pnl_settle_bal_Bottom As Panel
    Friend WithEvents pnl_settle_bal_Balance As Panel
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl_settle_bal_Left As Panel
    Friend WithEvents pnl_settle_bal_Right As Panel
    Friend WithEvents tbl_Buttons As TableLayoutPanel
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Checkout As Button
    Friend WithEvents btn_Load As Button
    Friend WithEvents pnl_settle_bal_Top As Panel
    Friend WithEvents lbl_customer_Id As Label
    Friend WithEvents lbl_Customer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_custSearch As Label
    Friend WithEvents lbl_custId As Label
    Friend WithEvents dtp_To As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_CustName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_From As DateTimePicker
    Friend WithEvents btn_load_History As Button
    Friend WithEvents pnl_history_Right As Panel
    Friend WithEvents pnl_history_Left As Panel
    Friend WithEvents pnl_history_Bottom As Panel
    Friend WithEvents dg_History As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dtp_cb_To As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_cb_From As DateTimePicker
    Friend WithEvents btn_load_Orders As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_cb_Search As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
