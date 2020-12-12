<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerTransacs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerTransacs))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tc_Customer = New System.Windows.Forms.TabControl()
        Me.tp_total_Balance = New System.Windows.Forms.TabPage()
        Me.tp_customer_Transac = New System.Windows.Forms.TabPage()
        Me.rv_Transac = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_transac_Right = New System.Windows.Forms.Panel()
        Me.pnl_transac_Left = New System.Windows.Forms.Panel()
        Me.pnl_transac_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_transac_Top = New System.Windows.Forms.Panel()
        Me.lbl_transac_customer_Id = New System.Windows.Forms.Label()
        Me.lbl_transac_Customer = New System.Windows.Forms.Label()
        Me.tb_transac_Customer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_transac_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_transac_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_transac_From = New System.Windows.Forms.DateTimePicker()
        Me.tp_pay_History = New System.Windows.Forms.TabPage()
        Me.rv_History = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_history_Right = New System.Windows.Forms.Panel()
        Me.pnl_history_Left = New System.Windows.Forms.Panel()
        Me.pnl_history_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_history_Top = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_history_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_history_load_Report = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_history_From = New System.Windows.Forms.DateTimePicker()
        Me.pnl_bal_Right = New System.Windows.Forms.Panel()
        Me.pnl_bal_Left = New System.Windows.Forms.Panel()
        Me.pnl_bal_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_bal_Top = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_bal_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_Bal = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_bal_From = New System.Windows.Forms.DateTimePicker()
        Me.rv_Balance = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel3.SuspendLayout()
        Me.tc_Customer.SuspendLayout()
        Me.tp_total_Balance.SuspendLayout()
        Me.tp_customer_Transac.SuspendLayout()
        Me.pnl_transac_Top.SuspendLayout()
        Me.tp_pay_History.SuspendLayout()
        Me.pnl_history_Top.SuspendLayout()
        Me.pnl_bal_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_Close)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1500, 55)
        Me.Panel3.TabIndex = 21
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(1442, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(58, 55)
        Me.btn_Close.TabIndex = 54
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Customer Report"
        '
        'tc_Customer
        '
        Me.tc_Customer.Controls.Add(Me.tp_total_Balance)
        Me.tc_Customer.Controls.Add(Me.tp_customer_Transac)
        Me.tc_Customer.Controls.Add(Me.tp_pay_History)
        Me.tc_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_Customer.Location = New System.Drawing.Point(0, 55)
        Me.tc_Customer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tc_Customer.Name = "tc_Customer"
        Me.tc_Customer.SelectedIndex = 0
        Me.tc_Customer.Size = New System.Drawing.Size(1500, 539)
        Me.tc_Customer.TabIndex = 22
        '
        'tp_total_Balance
        '
        Me.tp_total_Balance.Controls.Add(Me.rv_Balance)
        Me.tp_total_Balance.Controls.Add(Me.pnl_bal_Right)
        Me.tp_total_Balance.Controls.Add(Me.pnl_bal_Left)
        Me.tp_total_Balance.Controls.Add(Me.pnl_bal_Bottom)
        Me.tp_total_Balance.Controls.Add(Me.pnl_bal_Top)
        Me.tp_total_Balance.Location = New System.Drawing.Point(4, 34)
        Me.tp_total_Balance.Name = "tp_total_Balance"
        Me.tp_total_Balance.Size = New System.Drawing.Size(1492, 501)
        Me.tp_total_Balance.TabIndex = 2
        Me.tp_total_Balance.Text = "Customer Balance"
        Me.tp_total_Balance.UseVisualStyleBackColor = True
        '
        'tp_customer_Transac
        '
        Me.tp_customer_Transac.Controls.Add(Me.rv_Transac)
        Me.tp_customer_Transac.Controls.Add(Me.pnl_transac_Right)
        Me.tp_customer_Transac.Controls.Add(Me.pnl_transac_Left)
        Me.tp_customer_Transac.Controls.Add(Me.pnl_transac_Bottom)
        Me.tp_customer_Transac.Controls.Add(Me.pnl_transac_Top)
        Me.tp_customer_Transac.Location = New System.Drawing.Point(4, 34)
        Me.tp_customer_Transac.Name = "tp_customer_Transac"
        Me.tp_customer_Transac.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_customer_Transac.Size = New System.Drawing.Size(1492, 501)
        Me.tp_customer_Transac.TabIndex = 0
        Me.tp_customer_Transac.Text = "Customer Transactions"
        '
        'rv_Transac
        '
        Me.rv_Transac.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Nothing
        Me.rv_Transac.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_Transac.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_Transac.Location = New System.Drawing.Point(19, 131)
        Me.rv_Transac.Name = "rv_Transac"
        Me.rv_Transac.Size = New System.Drawing.Size(1454, 351)
        Me.rv_Transac.TabIndex = 30
        '
        'pnl_transac_Right
        '
        Me.pnl_transac_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_transac_Right.Location = New System.Drawing.Point(1473, 131)
        Me.pnl_transac_Right.Name = "pnl_transac_Right"
        Me.pnl_transac_Right.Size = New System.Drawing.Size(16, 351)
        Me.pnl_transac_Right.TabIndex = 29
        '
        'pnl_transac_Left
        '
        Me.pnl_transac_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_transac_Left.Location = New System.Drawing.Point(3, 131)
        Me.pnl_transac_Left.Name = "pnl_transac_Left"
        Me.pnl_transac_Left.Size = New System.Drawing.Size(16, 351)
        Me.pnl_transac_Left.TabIndex = 28
        '
        'pnl_transac_Bottom
        '
        Me.pnl_transac_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_transac_Bottom.Location = New System.Drawing.Point(3, 482)
        Me.pnl_transac_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_transac_Bottom.Name = "pnl_transac_Bottom"
        Me.pnl_transac_Bottom.Size = New System.Drawing.Size(1486, 16)
        Me.pnl_transac_Bottom.TabIndex = 27
        '
        'pnl_transac_Top
        '
        Me.pnl_transac_Top.Controls.Add(Me.lbl_transac_customer_Id)
        Me.pnl_transac_Top.Controls.Add(Me.lbl_transac_Customer)
        Me.pnl_transac_Top.Controls.Add(Me.tb_transac_Customer)
        Me.pnl_transac_Top.Controls.Add(Me.Label7)
        Me.pnl_transac_Top.Controls.Add(Me.Label2)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_transac_To)
        Me.pnl_transac_Top.Controls.Add(Me.btn_load_transac_Report)
        Me.pnl_transac_Top.Controls.Add(Me.Label19)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_transac_From)
        Me.pnl_transac_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_transac_Top.Location = New System.Drawing.Point(3, 3)
        Me.pnl_transac_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_transac_Top.Name = "pnl_transac_Top"
        Me.pnl_transac_Top.Size = New System.Drawing.Size(1486, 128)
        Me.pnl_transac_Top.TabIndex = 4
        '
        'lbl_transac_customer_Id
        '
        Me.lbl_transac_customer_Id.AutoSize = True
        Me.lbl_transac_customer_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transac_customer_Id.Location = New System.Drawing.Point(1301, 15)
        Me.lbl_transac_customer_Id.Name = "lbl_transac_customer_Id"
        Me.lbl_transac_customer_Id.Size = New System.Drawing.Size(138, 29)
        Me.lbl_transac_customer_Id.TabIndex = 46
        Me.lbl_transac_customer_Id.Text = "customer Id"
        Me.lbl_transac_customer_Id.Visible = False
        '
        'lbl_transac_Customer
        '
        Me.lbl_transac_Customer.AutoSize = True
        Me.lbl_transac_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transac_Customer.Location = New System.Drawing.Point(920, 20)
        Me.lbl_transac_Customer.Name = "lbl_transac_Customer"
        Me.lbl_transac_Customer.Size = New System.Drawing.Size(324, 26)
        Me.lbl_transac_Customer.TabIndex = 45
        Me.lbl_transac_Customer.Text = "[ Click here to search customer ]"
        '
        'tb_transac_Customer
        '
        Me.tb_transac_Customer.Enabled = False
        Me.tb_transac_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_transac_Customer.Location = New System.Drawing.Point(225, 14)
        Me.tb_transac_Customer.Name = "tb_transac_Customer"
        Me.tb_transac_Customer.Size = New System.Drawing.Size(689, 35)
        Me.tb_transac_Customer.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 29)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(610, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_transac_To
        '
        Me.dtp_transac_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_transac_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_transac_To.Location = New System.Drawing.Point(728, 66)
        Me.dtp_transac_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_transac_To.Name = "dtp_transac_To"
        Me.dtp_transac_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_transac_To.TabIndex = 21
        Me.dtp_transac_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_transac_Report
        '
        Me.btn_load_transac_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_transac_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_transac_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_transac_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_transac_Report.Location = New System.Drawing.Point(1164, 52)
        Me.btn_load_transac_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_transac_Report.Name = "btn_load_transac_Report"
        Me.btn_load_transac_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_load_transac_Report.TabIndex = 20
        Me.btn_load_transac_Report.Text = "Load Report"
        Me.btn_load_transac_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 29)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_transac_From
        '
        Me.dtp_transac_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_transac_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_transac_From.Location = New System.Drawing.Point(171, 66)
        Me.dtp_transac_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_transac_From.Name = "dtp_transac_From"
        Me.dtp_transac_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_transac_From.TabIndex = 18
        Me.dtp_transac_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'tp_pay_History
        '
        Me.tp_pay_History.Controls.Add(Me.rv_History)
        Me.tp_pay_History.Controls.Add(Me.pnl_history_Right)
        Me.tp_pay_History.Controls.Add(Me.pnl_history_Left)
        Me.tp_pay_History.Controls.Add(Me.pnl_history_Bottom)
        Me.tp_pay_History.Controls.Add(Me.pnl_history_Top)
        Me.tp_pay_History.Location = New System.Drawing.Point(4, 34)
        Me.tp_pay_History.Name = "tp_pay_History"
        Me.tp_pay_History.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_pay_History.Size = New System.Drawing.Size(1492, 501)
        Me.tp_pay_History.TabIndex = 1
        Me.tp_pay_History.Text = "Customer Payment History"
        Me.tp_pay_History.UseVisualStyleBackColor = True
        '
        'rv_History
        '
        Me.rv_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_History.Location = New System.Drawing.Point(19, 86)
        Me.rv_History.Name = "rv_History"
        Me.rv_History.Size = New System.Drawing.Size(1454, 396)
        Me.rv_History.TabIndex = 32
        '
        'pnl_history_Right
        '
        Me.pnl_history_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_history_Right.Location = New System.Drawing.Point(1473, 86)
        Me.pnl_history_Right.Name = "pnl_history_Right"
        Me.pnl_history_Right.Size = New System.Drawing.Size(16, 396)
        Me.pnl_history_Right.TabIndex = 31
        '
        'pnl_history_Left
        '
        Me.pnl_history_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_history_Left.Location = New System.Drawing.Point(3, 86)
        Me.pnl_history_Left.Name = "pnl_history_Left"
        Me.pnl_history_Left.Size = New System.Drawing.Size(16, 396)
        Me.pnl_history_Left.TabIndex = 30
        '
        'pnl_history_Bottom
        '
        Me.pnl_history_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_history_Bottom.Location = New System.Drawing.Point(3, 482)
        Me.pnl_history_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_history_Bottom.Name = "pnl_history_Bottom"
        Me.pnl_history_Bottom.Size = New System.Drawing.Size(1486, 16)
        Me.pnl_history_Bottom.TabIndex = 28
        '
        'pnl_history_Top
        '
        Me.pnl_history_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_history_Top.Controls.Add(Me.Label1)
        Me.pnl_history_Top.Controls.Add(Me.dtp_history_To)
        Me.pnl_history_Top.Controls.Add(Me.btn_history_load_Report)
        Me.pnl_history_Top.Controls.Add(Me.Label3)
        Me.pnl_history_Top.Controls.Add(Me.dtp_history_From)
        Me.pnl_history_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_history_Top.Location = New System.Drawing.Point(3, 3)
        Me.pnl_history_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_history_Top.Name = "pnl_history_Top"
        Me.pnl_history_Top.Size = New System.Drawing.Size(1486, 83)
        Me.pnl_history_Top.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(610, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date To:"
        '
        'dtp_history_To
        '
        Me.dtp_history_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_history_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_history_To.Location = New System.Drawing.Point(728, 22)
        Me.dtp_history_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_history_To.Name = "dtp_history_To"
        Me.dtp_history_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_history_To.TabIndex = 21
        Me.dtp_history_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_history_load_Report
        '
        Me.btn_history_load_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_history_load_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history_load_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history_load_Report.ForeColor = System.Drawing.Color.White
        Me.btn_history_load_Report.Location = New System.Drawing.Point(1162, 8)
        Me.btn_history_load_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_history_load_Report.Name = "btn_history_load_Report"
        Me.btn_history_load_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_history_load_Report.TabIndex = 20
        Me.btn_history_load_Report.Text = "Load Report"
        Me.btn_history_load_Report.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date From:"
        '
        'dtp_history_From
        '
        Me.dtp_history_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_history_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_history_From.Location = New System.Drawing.Point(171, 22)
        Me.dtp_history_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_history_From.Name = "dtp_history_From"
        Me.dtp_history_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_history_From.TabIndex = 18
        Me.dtp_history_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'pnl_bal_Right
        '
        Me.pnl_bal_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_bal_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_bal_Right.Location = New System.Drawing.Point(1476, 83)
        Me.pnl_bal_Right.Name = "pnl_bal_Right"
        Me.pnl_bal_Right.Size = New System.Drawing.Size(16, 402)
        Me.pnl_bal_Right.TabIndex = 35
        '
        'pnl_bal_Left
        '
        Me.pnl_bal_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_bal_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_bal_Left.Location = New System.Drawing.Point(0, 83)
        Me.pnl_bal_Left.Name = "pnl_bal_Left"
        Me.pnl_bal_Left.Size = New System.Drawing.Size(16, 402)
        Me.pnl_bal_Left.TabIndex = 34
        '
        'pnl_bal_Bottom
        '
        Me.pnl_bal_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_bal_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bal_Bottom.Location = New System.Drawing.Point(0, 485)
        Me.pnl_bal_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_bal_Bottom.Name = "pnl_bal_Bottom"
        Me.pnl_bal_Bottom.Size = New System.Drawing.Size(1492, 16)
        Me.pnl_bal_Bottom.TabIndex = 33
        '
        'pnl_bal_Top
        '
        Me.pnl_bal_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_bal_Top.Controls.Add(Me.Label5)
        Me.pnl_bal_Top.Controls.Add(Me.dtp_bal_To)
        Me.pnl_bal_Top.Controls.Add(Me.btn_load_Bal)
        Me.pnl_bal_Top.Controls.Add(Me.Label6)
        Me.pnl_bal_Top.Controls.Add(Me.dtp_bal_From)
        Me.pnl_bal_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_bal_Top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_bal_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_bal_Top.Name = "pnl_bal_Top"
        Me.pnl_bal_Top.Size = New System.Drawing.Size(1492, 83)
        Me.pnl_bal_Top.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(610, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Date To:"
        '
        'dtp_bal_To
        '
        Me.dtp_bal_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_bal_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bal_To.Location = New System.Drawing.Point(728, 22)
        Me.dtp_bal_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_bal_To.Name = "dtp_bal_To"
        Me.dtp_bal_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_bal_To.TabIndex = 21
        Me.dtp_bal_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_Bal
        '
        Me.btn_load_Bal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_Bal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_Bal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_Bal.ForeColor = System.Drawing.Color.White
        Me.btn_load_Bal.Location = New System.Drawing.Point(1162, 8)
        Me.btn_load_Bal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_Bal.Name = "btn_load_Bal"
        Me.btn_load_Bal.Size = New System.Drawing.Size(148, 63)
        Me.btn_load_Bal.TabIndex = 20
        Me.btn_load_Bal.Text = "Load Report"
        Me.btn_load_Bal.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 29)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Date From:"
        '
        'dtp_bal_From
        '
        Me.dtp_bal_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_bal_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bal_From.Location = New System.Drawing.Point(171, 22)
        Me.dtp_bal_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_bal_From.Name = "dtp_bal_From"
        Me.dtp_bal_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_bal_From.TabIndex = 18
        Me.dtp_bal_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'rv_Balance
        '
        Me.rv_Balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_Balance.Location = New System.Drawing.Point(16, 83)
        Me.rv_Balance.Name = "rv_Balance"
        Me.rv_Balance.Size = New System.Drawing.Size(1460, 402)
        Me.rv_Balance.TabIndex = 36
        '
        'frmCustomerTransacs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 594)
        Me.Controls.Add(Me.tc_Customer)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerTransacs"
        Me.Text = "frmCustomerTransacs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tc_Customer.ResumeLayout(False)
        Me.tp_total_Balance.ResumeLayout(False)
        Me.tp_customer_Transac.ResumeLayout(False)
        Me.pnl_transac_Top.ResumeLayout(False)
        Me.pnl_transac_Top.PerformLayout()
        Me.tp_pay_History.ResumeLayout(False)
        Me.pnl_history_Top.ResumeLayout(False)
        Me.pnl_history_Top.PerformLayout()
        Me.pnl_bal_Top.ResumeLayout(False)
        Me.pnl_bal_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tc_Customer As TabControl
    Friend WithEvents tp_customer_Transac As TabPage
    Friend WithEvents rv_Transac As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_transac_Right As Panel
    Friend WithEvents pnl_transac_Left As Panel
    Friend WithEvents pnl_transac_Bottom As Panel
    Friend WithEvents pnl_transac_Top As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_transac_To As DateTimePicker
    Friend WithEvents btn_load_transac_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_transac_From As DateTimePicker
    Friend WithEvents tp_pay_History As TabPage
    Friend WithEvents rv_History As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_history_Right As Panel
    Friend WithEvents pnl_history_Left As Panel
    Friend WithEvents pnl_history_Bottom As Panel
    Friend WithEvents pnl_history_Top As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_history_To As DateTimePicker
    Friend WithEvents btn_history_load_Report As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_history_From As DateTimePicker
    Friend WithEvents lbl_transac_Customer As Label
    Friend WithEvents tb_transac_Customer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_transac_customer_Id As Label
    Friend WithEvents tp_total_Balance As TabPage
    Friend WithEvents rv_Balance As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_bal_Right As Panel
    Friend WithEvents pnl_bal_Left As Panel
    Friend WithEvents pnl_bal_Bottom As Panel
    Friend WithEvents pnl_bal_Top As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_bal_To As DateTimePicker
    Friend WithEvents btn_load_Bal As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_bal_From As DateTimePicker
End Class
