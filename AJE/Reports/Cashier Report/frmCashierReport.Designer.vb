<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashierReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashierReport))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tc_Cashier = New System.Windows.Forms.TabControl()
        Me.tp_cashier_Log = New System.Windows.Forms.TabPage()
        Me.rv_Log = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_log_Right = New System.Windows.Forms.Panel()
        Me.pnl_log_Left = New System.Windows.Forms.Panel()
        Me.pnl_log_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_log_Top = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_log_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_log_Report = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_log_From = New System.Windows.Forms.DateTimePicker()
        Me.tp_cash_In = New System.Windows.Forms.TabPage()
        Me.rv_cash_In = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_cash_in_Right = New System.Windows.Forms.Panel()
        Me.pnl_cash_in_Left = New System.Windows.Forms.Panel()
        Me.pnl_cash_in_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_cash_in_Top = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_cash_in_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_cash_in_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_cash_in_From = New System.Windows.Forms.DateTimePicker()
        Me.tp_cash_Out = New System.Windows.Forms.TabPage()
        Me.rv_cash_Out = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_cash_out_Right = New System.Windows.Forms.Panel()
        Me.pnl_cash_out_Left = New System.Windows.Forms.Panel()
        Me.pnl_cash_out_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_cash_out_Top = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_cash_out_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_cash_out_Report = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_cash_out_From = New System.Windows.Forms.DateTimePicker()
        Me.Panel3.SuspendLayout()
        Me.tc_Cashier.SuspendLayout()
        Me.tp_cashier_Log.SuspendLayout()
        Me.pnl_log_Top.SuspendLayout()
        Me.tp_cash_In.SuspendLayout()
        Me.pnl_cash_in_Top.SuspendLayout()
        Me.tp_cash_Out.SuspendLayout()
        Me.pnl_cash_out_Top.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(1449, 55)
        Me.Panel3.TabIndex = 21
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(1391, 0)
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
        Me.Label4.Size = New System.Drawing.Size(158, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cashier Report"
        '
        'tc_Cashier
        '
        Me.tc_Cashier.Controls.Add(Me.tp_cashier_Log)
        Me.tc_Cashier.Controls.Add(Me.tp_cash_In)
        Me.tc_Cashier.Controls.Add(Me.tp_cash_Out)
        Me.tc_Cashier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Cashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_Cashier.Location = New System.Drawing.Point(0, 55)
        Me.tc_Cashier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tc_Cashier.Name = "tc_Cashier"
        Me.tc_Cashier.SelectedIndex = 0
        Me.tc_Cashier.Size = New System.Drawing.Size(1449, 607)
        Me.tc_Cashier.TabIndex = 22
        '
        'tp_cashier_Log
        '
        Me.tp_cashier_Log.Controls.Add(Me.rv_Log)
        Me.tp_cashier_Log.Controls.Add(Me.pnl_log_Right)
        Me.tp_cashier_Log.Controls.Add(Me.pnl_log_Left)
        Me.tp_cashier_Log.Controls.Add(Me.pnl_log_Bottom)
        Me.tp_cashier_Log.Controls.Add(Me.pnl_log_Top)
        Me.tp_cashier_Log.Location = New System.Drawing.Point(4, 34)
        Me.tp_cashier_Log.Name = "tp_cashier_Log"
        Me.tp_cashier_Log.Size = New System.Drawing.Size(1441, 569)
        Me.tp_cashier_Log.TabIndex = 2
        Me.tp_cashier_Log.Text = "Cashier Log Report"
        Me.tp_cashier_Log.UseVisualStyleBackColor = True
        '
        'rv_Log
        '
        Me.rv_Log.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Nothing
        Me.rv_Log.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rv_Log.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_Log.Location = New System.Drawing.Point(16, 84)
        Me.rv_Log.Name = "rv_Log"
        Me.rv_Log.Size = New System.Drawing.Size(1409, 469)
        Me.rv_Log.TabIndex = 34
        '
        'pnl_log_Right
        '
        Me.pnl_log_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_log_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_log_Right.Location = New System.Drawing.Point(1425, 84)
        Me.pnl_log_Right.Name = "pnl_log_Right"
        Me.pnl_log_Right.Size = New System.Drawing.Size(16, 469)
        Me.pnl_log_Right.TabIndex = 33
        '
        'pnl_log_Left
        '
        Me.pnl_log_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_log_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_log_Left.Location = New System.Drawing.Point(0, 84)
        Me.pnl_log_Left.Name = "pnl_log_Left"
        Me.pnl_log_Left.Size = New System.Drawing.Size(16, 469)
        Me.pnl_log_Left.TabIndex = 32
        '
        'pnl_log_Bottom
        '
        Me.pnl_log_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_log_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_log_Bottom.Location = New System.Drawing.Point(0, 553)
        Me.pnl_log_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_log_Bottom.Name = "pnl_log_Bottom"
        Me.pnl_log_Bottom.Size = New System.Drawing.Size(1441, 16)
        Me.pnl_log_Bottom.TabIndex = 31
        '
        'pnl_log_Top
        '
        Me.pnl_log_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_log_Top.Controls.Add(Me.Label5)
        Me.pnl_log_Top.Controls.Add(Me.dtp_log_To)
        Me.pnl_log_Top.Controls.Add(Me.btn_load_log_Report)
        Me.pnl_log_Top.Controls.Add(Me.Label6)
        Me.pnl_log_Top.Controls.Add(Me.dtp_log_From)
        Me.pnl_log_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_log_Top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_log_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_log_Top.Name = "pnl_log_Top"
        Me.pnl_log_Top.Size = New System.Drawing.Size(1441, 84)
        Me.pnl_log_Top.TabIndex = 5
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
        'dtp_log_To
        '
        Me.dtp_log_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_log_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_log_To.Location = New System.Drawing.Point(728, 22)
        Me.dtp_log_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_log_To.Name = "dtp_log_To"
        Me.dtp_log_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_log_To.TabIndex = 21
        Me.dtp_log_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_log_Report
        '
        Me.btn_load_log_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_log_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_log_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_log_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_log_Report.Location = New System.Drawing.Point(1164, 8)
        Me.btn_load_log_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_log_Report.Name = "btn_load_log_Report"
        Me.btn_load_log_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_load_log_Report.TabIndex = 20
        Me.btn_load_log_Report.Text = "Load Report"
        Me.btn_load_log_Report.UseVisualStyleBackColor = False
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
        'dtp_log_From
        '
        Me.dtp_log_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_log_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_log_From.Location = New System.Drawing.Point(171, 22)
        Me.dtp_log_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_log_From.Name = "dtp_log_From"
        Me.dtp_log_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_log_From.TabIndex = 18
        Me.dtp_log_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'tp_cash_In
        '
        Me.tp_cash_In.Controls.Add(Me.rv_cash_In)
        Me.tp_cash_In.Controls.Add(Me.pnl_cash_in_Right)
        Me.tp_cash_In.Controls.Add(Me.pnl_cash_in_Left)
        Me.tp_cash_In.Controls.Add(Me.pnl_cash_in_Bottom)
        Me.tp_cash_In.Controls.Add(Me.pnl_cash_in_Top)
        Me.tp_cash_In.Location = New System.Drawing.Point(4, 34)
        Me.tp_cash_In.Name = "tp_cash_In"
        Me.tp_cash_In.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_cash_In.Size = New System.Drawing.Size(1441, 569)
        Me.tp_cash_In.TabIndex = 0
        Me.tp_cash_In.Text = "Cash In Report"
        '
        'rv_cash_In
        '
        Me.rv_cash_In.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Nothing
        Me.rv_cash_In.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rv_cash_In.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_cash_In.Location = New System.Drawing.Point(19, 87)
        Me.rv_cash_In.Name = "rv_cash_In"
        Me.rv_cash_In.Size = New System.Drawing.Size(1403, 463)
        Me.rv_cash_In.TabIndex = 30
        '
        'pnl_cash_in_Right
        '
        Me.pnl_cash_in_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_cash_in_Right.Location = New System.Drawing.Point(1422, 87)
        Me.pnl_cash_in_Right.Name = "pnl_cash_in_Right"
        Me.pnl_cash_in_Right.Size = New System.Drawing.Size(16, 463)
        Me.pnl_cash_in_Right.TabIndex = 29
        '
        'pnl_cash_in_Left
        '
        Me.pnl_cash_in_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_cash_in_Left.Location = New System.Drawing.Point(3, 87)
        Me.pnl_cash_in_Left.Name = "pnl_cash_in_Left"
        Me.pnl_cash_in_Left.Size = New System.Drawing.Size(16, 463)
        Me.pnl_cash_in_Left.TabIndex = 28
        '
        'pnl_cash_in_Bottom
        '
        Me.pnl_cash_in_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_cash_in_Bottom.Location = New System.Drawing.Point(3, 550)
        Me.pnl_cash_in_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_cash_in_Bottom.Name = "pnl_cash_in_Bottom"
        Me.pnl_cash_in_Bottom.Size = New System.Drawing.Size(1435, 16)
        Me.pnl_cash_in_Bottom.TabIndex = 27
        '
        'pnl_cash_in_Top
        '
        Me.pnl_cash_in_Top.Controls.Add(Me.Label2)
        Me.pnl_cash_in_Top.Controls.Add(Me.dtp_cash_in_To)
        Me.pnl_cash_in_Top.Controls.Add(Me.btn_load_cash_in_Report)
        Me.pnl_cash_in_Top.Controls.Add(Me.Label19)
        Me.pnl_cash_in_Top.Controls.Add(Me.dtp_cash_in_From)
        Me.pnl_cash_in_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cash_in_Top.Location = New System.Drawing.Point(3, 3)
        Me.pnl_cash_in_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_cash_in_Top.Name = "pnl_cash_in_Top"
        Me.pnl_cash_in_Top.Size = New System.Drawing.Size(1435, 84)
        Me.pnl_cash_in_Top.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(607, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_cash_in_To
        '
        Me.dtp_cash_in_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_in_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_in_To.Location = New System.Drawing.Point(725, 23)
        Me.dtp_cash_in_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cash_in_To.Name = "dtp_cash_in_To"
        Me.dtp_cash_in_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_cash_in_To.TabIndex = 21
        Me.dtp_cash_in_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_cash_in_Report
        '
        Me.btn_load_cash_in_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_cash_in_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_cash_in_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_cash_in_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_cash_in_Report.Location = New System.Drawing.Point(1161, 9)
        Me.btn_load_cash_in_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_cash_in_Report.Name = "btn_load_cash_in_Report"
        Me.btn_load_cash_in_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_load_cash_in_Report.TabIndex = 20
        Me.btn_load_cash_in_Report.Text = "Load Report"
        Me.btn_load_cash_in_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(22, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 29)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_cash_in_From
        '
        Me.dtp_cash_in_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_in_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_in_From.Location = New System.Drawing.Point(168, 23)
        Me.dtp_cash_in_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cash_in_From.Name = "dtp_cash_in_From"
        Me.dtp_cash_in_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_cash_in_From.TabIndex = 18
        Me.dtp_cash_in_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'tp_cash_Out
        '
        Me.tp_cash_Out.Controls.Add(Me.rv_cash_Out)
        Me.tp_cash_Out.Controls.Add(Me.pnl_cash_out_Right)
        Me.tp_cash_Out.Controls.Add(Me.pnl_cash_out_Left)
        Me.tp_cash_Out.Controls.Add(Me.pnl_cash_out_Bottom)
        Me.tp_cash_Out.Controls.Add(Me.pnl_cash_out_Top)
        Me.tp_cash_Out.Location = New System.Drawing.Point(4, 34)
        Me.tp_cash_Out.Name = "tp_cash_Out"
        Me.tp_cash_Out.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_cash_Out.Size = New System.Drawing.Size(1441, 569)
        Me.tp_cash_Out.TabIndex = 1
        Me.tp_cash_Out.Text = "Cash Out Report"
        Me.tp_cash_Out.UseVisualStyleBackColor = True
        '
        'rv_cash_Out
        '
        Me.rv_cash_Out.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_cash_Out.Location = New System.Drawing.Point(19, 87)
        Me.rv_cash_Out.Name = "rv_cash_Out"
        Me.rv_cash_Out.Size = New System.Drawing.Size(1403, 463)
        Me.rv_cash_Out.TabIndex = 32
        '
        'pnl_cash_out_Right
        '
        Me.pnl_cash_out_Right.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_cash_out_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_cash_out_Right.Location = New System.Drawing.Point(1422, 87)
        Me.pnl_cash_out_Right.Name = "pnl_cash_out_Right"
        Me.pnl_cash_out_Right.Size = New System.Drawing.Size(16, 463)
        Me.pnl_cash_out_Right.TabIndex = 31
        '
        'pnl_cash_out_Left
        '
        Me.pnl_cash_out_Left.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_cash_out_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_cash_out_Left.Location = New System.Drawing.Point(3, 87)
        Me.pnl_cash_out_Left.Name = "pnl_cash_out_Left"
        Me.pnl_cash_out_Left.Size = New System.Drawing.Size(16, 463)
        Me.pnl_cash_out_Left.TabIndex = 30
        '
        'pnl_cash_out_Bottom
        '
        Me.pnl_cash_out_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_cash_out_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_cash_out_Bottom.Location = New System.Drawing.Point(3, 550)
        Me.pnl_cash_out_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_cash_out_Bottom.Name = "pnl_cash_out_Bottom"
        Me.pnl_cash_out_Bottom.Size = New System.Drawing.Size(1435, 16)
        Me.pnl_cash_out_Bottom.TabIndex = 28
        '
        'pnl_cash_out_Top
        '
        Me.pnl_cash_out_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_cash_out_Top.Controls.Add(Me.Label1)
        Me.pnl_cash_out_Top.Controls.Add(Me.dtp_cash_out_To)
        Me.pnl_cash_out_Top.Controls.Add(Me.btn_cash_out_Report)
        Me.pnl_cash_out_Top.Controls.Add(Me.Label3)
        Me.pnl_cash_out_Top.Controls.Add(Me.dtp_cash_out_From)
        Me.pnl_cash_out_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cash_out_Top.Location = New System.Drawing.Point(3, 3)
        Me.pnl_cash_out_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_cash_out_Top.Name = "pnl_cash_out_Top"
        Me.pnl_cash_out_Top.Size = New System.Drawing.Size(1435, 84)
        Me.pnl_cash_out_Top.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(607, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date To:"
        '
        'dtp_cash_out_To
        '
        Me.dtp_cash_out_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_out_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_out_To.Location = New System.Drawing.Point(725, 24)
        Me.dtp_cash_out_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cash_out_To.Name = "dtp_cash_out_To"
        Me.dtp_cash_out_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_cash_out_To.TabIndex = 21
        Me.dtp_cash_out_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_cash_out_Report
        '
        Me.btn_cash_out_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_cash_out_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cash_out_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cash_out_Report.ForeColor = System.Drawing.Color.White
        Me.btn_cash_out_Report.Location = New System.Drawing.Point(1161, 10)
        Me.btn_cash_out_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cash_out_Report.Name = "btn_cash_out_Report"
        Me.btn_cash_out_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_cash_out_Report.TabIndex = 20
        Me.btn_cash_out_Report.Text = "Load Report"
        Me.btn_cash_out_Report.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date From:"
        '
        'dtp_cash_out_From
        '
        Me.dtp_cash_out_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_out_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_out_From.Location = New System.Drawing.Point(168, 24)
        Me.dtp_cash_out_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_cash_out_From.Name = "dtp_cash_out_From"
        Me.dtp_cash_out_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_cash_out_From.TabIndex = 18
        Me.dtp_cash_out_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'frmCashierReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 662)
        Me.Controls.Add(Me.tc_Cashier)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCashierReport"
        Me.Text = "frmCashierReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tc_Cashier.ResumeLayout(False)
        Me.tp_cashier_Log.ResumeLayout(False)
        Me.pnl_log_Top.ResumeLayout(False)
        Me.pnl_log_Top.PerformLayout()
        Me.tp_cash_In.ResumeLayout(False)
        Me.pnl_cash_in_Top.ResumeLayout(False)
        Me.pnl_cash_in_Top.PerformLayout()
        Me.tp_cash_Out.ResumeLayout(False)
        Me.pnl_cash_out_Top.ResumeLayout(False)
        Me.pnl_cash_out_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tc_Cashier As TabControl
    Friend WithEvents tp_cash_In As TabPage
    Friend WithEvents rv_cash_In As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_cash_in_Right As Panel
    Friend WithEvents pnl_cash_in_Left As Panel
    Friend WithEvents pnl_cash_in_Bottom As Panel
    Friend WithEvents pnl_cash_in_Top As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_cash_in_To As DateTimePicker
    Friend WithEvents btn_load_cash_in_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_cash_in_From As DateTimePicker
    Friend WithEvents tp_cash_Out As TabPage
    Friend WithEvents rv_cash_Out As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_cash_out_Right As Panel
    Friend WithEvents pnl_cash_out_Left As Panel
    Friend WithEvents pnl_cash_out_Bottom As Panel
    Friend WithEvents pnl_cash_out_Top As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_cash_out_To As DateTimePicker
    Friend WithEvents btn_cash_out_Report As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_cash_out_From As DateTimePicker
    Friend WithEvents tp_cashier_Log As TabPage
    Friend WithEvents pnl_log_Top As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_log_To As DateTimePicker
    Friend WithEvents btn_load_log_Report As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_log_From As DateTimePicker
    Friend WithEvents rv_Log As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_log_Right As Panel
    Friend WithEvents pnl_log_Left As Panel
    Friend WithEvents pnl_log_Bottom As Panel
End Class
