﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tc_Sales = New System.Windows.Forms.TabControl()
        Me.tp_All = New System.Windows.Forms.TabPage()
        Me.rv_All = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_all_Right = New System.Windows.Forms.Panel()
        Me.pnl_all_Left = New System.Windows.Forms.Panel()
        Me.pnl_all_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_all_Top = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_search_All = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_all_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_all_load_Report = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_all_From = New System.Windows.Forms.DateTimePicker()
        Me.tp_Cash = New System.Windows.Forms.TabPage()
        Me.rv_Cash = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_Cash_Right = New System.Windows.Forms.Panel()
        Me.pnl_cash_Left = New System.Windows.Forms.Panel()
        Me.pnl_cash_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_cash_Top = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_search_Cash = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_cash_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_cash_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_cash_From = New System.Windows.Forms.DateTimePicker()
        Me.tp_Credit = New System.Windows.Forms.TabPage()
        Me.rv_Credit = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnl_credit_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_credit_Top = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_search_Credit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_credit_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_credit_load_Report = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_credit_From = New System.Windows.Forms.DateTimePicker()
        Me.Panel3.SuspendLayout()
        Me.tc_Sales.SuspendLayout()
        Me.tp_All.SuspendLayout()
        Me.pnl_all_Top.SuspendLayout()
        Me.tp_Cash.SuspendLayout()
        Me.pnl_cash_Top.SuspendLayout()
        Me.tp_Credit.SuspendLayout()
        Me.pnl_credit_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_Close)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(924, 36)
        Me.Panel3.TabIndex = 20
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(885, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(39, 36)
        Me.btn_Close.TabIndex = 54
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sales Report"
        '
        'tc_Sales
        '
        Me.tc_Sales.Controls.Add(Me.tp_All)
        Me.tc_Sales.Controls.Add(Me.tp_Cash)
        Me.tc_Sales.Controls.Add(Me.tp_Credit)
        Me.tc_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_Sales.Location = New System.Drawing.Point(0, 36)
        Me.tc_Sales.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tc_Sales.Name = "tc_Sales"
        Me.tc_Sales.SelectedIndex = 0
        Me.tc_Sales.Size = New System.Drawing.Size(924, 366)
        Me.tc_Sales.TabIndex = 21
        '
        'tp_All
        '
        Me.tp_All.BackColor = System.Drawing.SystemColors.Control
        Me.tp_All.Controls.Add(Me.rv_All)
        Me.tp_All.Controls.Add(Me.pnl_all_Right)
        Me.tp_All.Controls.Add(Me.pnl_all_Left)
        Me.tp_All.Controls.Add(Me.pnl_all_Bottom)
        Me.tp_All.Controls.Add(Me.pnl_all_Top)
        Me.tp_All.Location = New System.Drawing.Point(4, 25)
        Me.tp_All.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tp_All.Name = "tp_All"
        Me.tp_All.Size = New System.Drawing.Size(916, 337)
        Me.tp_All.TabIndex = 2
        Me.tp_All.Text = "All Sales"
        '
        'rv_All
        '
        Me.rv_All.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.rv_All.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_All.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_All.Location = New System.Drawing.Point(11, 55)
        Me.rv_All.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rv_All.Name = "rv_All"
        Me.rv_All.Size = New System.Drawing.Size(894, 272)
        Me.rv_All.TabIndex = 35
        '
        'pnl_all_Right
        '
        Me.pnl_all_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_all_Right.Location = New System.Drawing.Point(905, 55)
        Me.pnl_all_Right.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_all_Right.Name = "pnl_all_Right"
        Me.pnl_all_Right.Size = New System.Drawing.Size(11, 272)
        Me.pnl_all_Right.TabIndex = 34
        '
        'pnl_all_Left
        '
        Me.pnl_all_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_all_Left.Location = New System.Drawing.Point(0, 55)
        Me.pnl_all_Left.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_all_Left.Name = "pnl_all_Left"
        Me.pnl_all_Left.Size = New System.Drawing.Size(11, 272)
        Me.pnl_all_Left.TabIndex = 33
        '
        'pnl_all_Bottom
        '
        Me.pnl_all_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_all_Bottom.Location = New System.Drawing.Point(0, 327)
        Me.pnl_all_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_all_Bottom.Name = "pnl_all_Bottom"
        Me.pnl_all_Bottom.Size = New System.Drawing.Size(916, 10)
        Me.pnl_all_Bottom.TabIndex = 32
        '
        'pnl_all_Top
        '
        Me.pnl_all_Top.Controls.Add(Me.Label7)
        Me.pnl_all_Top.Controls.Add(Me.cbo_search_All)
        Me.pnl_all_Top.Controls.Add(Me.Label8)
        Me.pnl_all_Top.Controls.Add(Me.dtp_all_To)
        Me.pnl_all_Top.Controls.Add(Me.btn_all_load_Report)
        Me.pnl_all_Top.Controls.Add(Me.Label9)
        Me.pnl_all_Top.Controls.Add(Me.dtp_all_From)
        Me.pnl_all_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_all_Top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_all_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_all_Top.Name = "pnl_all_Top"
        Me.pnl_all_Top.Size = New System.Drawing.Size(916, 55)
        Me.pnl_all_Top.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Search By:"
        '
        'cbo_search_All
        '
        Me.cbo_search_All.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_All.FormattingEnabled = True
        Me.cbo_search_All.Items.AddRange(New Object() {"Sale Date", "Input Date"})
        Me.cbo_search_All.Location = New System.Drawing.Point(106, 15)
        Me.cbo_search_All.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_search_All.Name = "cbo_search_All"
        Me.cbo_search_All.Size = New System.Drawing.Size(113, 28)
        Me.cbo_search_All.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(623, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Date To:"
        '
        'dtp_all_To
        '
        Me.dtp_all_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_all_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_all_To.Location = New System.Drawing.Point(701, 15)
        Me.dtp_all_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_all_To.Name = "dtp_all_To"
        Me.dtp_all_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_all_To.TabIndex = 21
        Me.dtp_all_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_all_load_Report
        '
        Me.btn_all_load_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_all_load_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_all_load_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all_load_Report.ForeColor = System.Drawing.Color.White
        Me.btn_all_load_Report.Location = New System.Drawing.Point(992, 6)
        Me.btn_all_load_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_all_load_Report.Name = "btn_all_load_Report"
        Me.btn_all_load_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_all_load_Report.TabIndex = 20
        Me.btn_all_load_Report.Text = "Load Report"
        Me.btn_all_load_Report.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(233, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Date From:"
        '
        'dtp_all_From
        '
        Me.dtp_all_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_all_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_all_From.Location = New System.Drawing.Point(330, 15)
        Me.dtp_all_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_all_From.Name = "dtp_all_From"
        Me.dtp_all_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_all_From.TabIndex = 18
        Me.dtp_all_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'tp_Cash
        '
        Me.tp_Cash.Controls.Add(Me.rv_Cash)
        Me.tp_Cash.Controls.Add(Me.pnl_Cash_Right)
        Me.tp_Cash.Controls.Add(Me.pnl_cash_Left)
        Me.tp_Cash.Controls.Add(Me.pnl_cash_Bottom)
        Me.tp_Cash.Controls.Add(Me.pnl_cash_Top)
        Me.tp_Cash.Location = New System.Drawing.Point(4, 25)
        Me.tp_Cash.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tp_Cash.Name = "tp_Cash"
        Me.tp_Cash.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tp_Cash.Size = New System.Drawing.Size(916, 337)
        Me.tp_Cash.TabIndex = 0
        Me.tp_Cash.Text = "Cash Sales"
        '
        'rv_Cash
        '
        Me.rv_Cash.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Nothing
        Me.rv_Cash.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_Cash.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_Cash.Location = New System.Drawing.Point(13, 57)
        Me.rv_Cash.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rv_Cash.Name = "rv_Cash"
        Me.rv_Cash.Size = New System.Drawing.Size(890, 268)
        Me.rv_Cash.TabIndex = 30
        '
        'pnl_Cash_Right
        '
        Me.pnl_Cash_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Cash_Right.Location = New System.Drawing.Point(903, 57)
        Me.pnl_Cash_Right.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_Cash_Right.Name = "pnl_Cash_Right"
        Me.pnl_Cash_Right.Size = New System.Drawing.Size(11, 268)
        Me.pnl_Cash_Right.TabIndex = 29
        '
        'pnl_cash_Left
        '
        Me.pnl_cash_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_cash_Left.Location = New System.Drawing.Point(2, 57)
        Me.pnl_cash_Left.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_cash_Left.Name = "pnl_cash_Left"
        Me.pnl_cash_Left.Size = New System.Drawing.Size(11, 268)
        Me.pnl_cash_Left.TabIndex = 28
        '
        'pnl_cash_Bottom
        '
        Me.pnl_cash_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_cash_Bottom.Location = New System.Drawing.Point(2, 325)
        Me.pnl_cash_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_cash_Bottom.Name = "pnl_cash_Bottom"
        Me.pnl_cash_Bottom.Size = New System.Drawing.Size(912, 10)
        Me.pnl_cash_Bottom.TabIndex = 27
        '
        'pnl_cash_Top
        '
        Me.pnl_cash_Top.Controls.Add(Me.Label5)
        Me.pnl_cash_Top.Controls.Add(Me.cbo_search_Cash)
        Me.pnl_cash_Top.Controls.Add(Me.Label2)
        Me.pnl_cash_Top.Controls.Add(Me.dtp_cash_To)
        Me.pnl_cash_Top.Controls.Add(Me.btn_load_cash_Report)
        Me.pnl_cash_Top.Controls.Add(Me.Label19)
        Me.pnl_cash_Top.Controls.Add(Me.dtp_cash_From)
        Me.pnl_cash_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cash_Top.Location = New System.Drawing.Point(2, 2)
        Me.pnl_cash_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_cash_Top.Name = "pnl_cash_Top"
        Me.pnl_cash_Top.Size = New System.Drawing.Size(912, 55)
        Me.pnl_cash_Top.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Search By:"
        '
        'cbo_search_Cash
        '
        Me.cbo_search_Cash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_Cash.FormattingEnabled = True
        Me.cbo_search_Cash.Items.AddRange(New Object() {"Sale Date", "Input Date"})
        Me.cbo_search_Cash.Location = New System.Drawing.Point(106, 15)
        Me.cbo_search_Cash.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_search_Cash.Name = "cbo_search_Cash"
        Me.cbo_search_Cash.Size = New System.Drawing.Size(113, 28)
        Me.cbo_search_Cash.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(623, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_cash_To
        '
        Me.dtp_cash_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_To.Location = New System.Drawing.Point(701, 15)
        Me.dtp_cash_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_cash_To.Name = "dtp_cash_To"
        Me.dtp_cash_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_cash_To.TabIndex = 21
        Me.dtp_cash_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_cash_Report
        '
        Me.btn_load_cash_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_cash_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_cash_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_cash_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_cash_Report.Location = New System.Drawing.Point(992, 6)
        Me.btn_load_cash_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load_cash_Report.Name = "btn_load_cash_Report"
        Me.btn_load_cash_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_load_cash_Report.TabIndex = 20
        Me.btn_load_cash_Report.Text = "Load Report"
        Me.btn_load_cash_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(233, 16)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_cash_From
        '
        Me.dtp_cash_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_cash_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cash_From.Location = New System.Drawing.Point(330, 15)
        Me.dtp_cash_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_cash_From.Name = "dtp_cash_From"
        Me.dtp_cash_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_cash_From.TabIndex = 18
        Me.dtp_cash_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'tp_Credit
        '
        Me.tp_Credit.Controls.Add(Me.rv_Credit)
        Me.tp_Credit.Controls.Add(Me.Panel1)
        Me.tp_Credit.Controls.Add(Me.Panel2)
        Me.tp_Credit.Controls.Add(Me.pnl_credit_Bottom)
        Me.tp_Credit.Controls.Add(Me.pnl_credit_Top)
        Me.tp_Credit.Location = New System.Drawing.Point(4, 25)
        Me.tp_Credit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tp_Credit.Name = "tp_Credit"
        Me.tp_Credit.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tp_Credit.Size = New System.Drawing.Size(916, 337)
        Me.tp_Credit.TabIndex = 1
        Me.tp_Credit.Text = "Credit Sales"
        Me.tp_Credit.UseVisualStyleBackColor = True
        '
        'rv_Credit
        '
        Me.rv_Credit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_Credit.Location = New System.Drawing.Point(13, 57)
        Me.rv_Credit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rv_Credit.Name = "rv_Credit"
        Me.rv_Credit.Size = New System.Drawing.Size(890, 268)
        Me.rv_Credit.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(903, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(11, 268)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(2, 57)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 268)
        Me.Panel2.TabIndex = 30
        '
        'pnl_credit_Bottom
        '
        Me.pnl_credit_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_credit_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_credit_Bottom.Location = New System.Drawing.Point(2, 325)
        Me.pnl_credit_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_credit_Bottom.Name = "pnl_credit_Bottom"
        Me.pnl_credit_Bottom.Size = New System.Drawing.Size(912, 10)
        Me.pnl_credit_Bottom.TabIndex = 28
        '
        'pnl_credit_Top
        '
        Me.pnl_credit_Top.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_credit_Top.Controls.Add(Me.Label6)
        Me.pnl_credit_Top.Controls.Add(Me.cbo_search_Credit)
        Me.pnl_credit_Top.Controls.Add(Me.Label1)
        Me.pnl_credit_Top.Controls.Add(Me.dtp_credit_To)
        Me.pnl_credit_Top.Controls.Add(Me.btn_credit_load_Report)
        Me.pnl_credit_Top.Controls.Add(Me.Label3)
        Me.pnl_credit_Top.Controls.Add(Me.dtp_credit_From)
        Me.pnl_credit_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_credit_Top.Location = New System.Drawing.Point(2, 2)
        Me.pnl_credit_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_credit_Top.Name = "pnl_credit_Top"
        Me.pnl_credit_Top.Size = New System.Drawing.Size(912, 55)
        Me.pnl_credit_Top.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Search By:"
        '
        'cbo_search_Credit
        '
        Me.cbo_search_Credit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_Credit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_Credit.FormattingEnabled = True
        Me.cbo_search_Credit.Items.AddRange(New Object() {"Sale Date", "Input Date"})
        Me.cbo_search_Credit.Location = New System.Drawing.Point(103, 14)
        Me.cbo_search_Credit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_search_Credit.Name = "cbo_search_Credit"
        Me.cbo_search_Credit.Size = New System.Drawing.Size(113, 28)
        Me.cbo_search_Credit.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(617, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date To:"
        '
        'dtp_credit_To
        '
        Me.dtp_credit_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_credit_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_credit_To.Location = New System.Drawing.Point(696, 15)
        Me.dtp_credit_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_credit_To.Name = "dtp_credit_To"
        Me.dtp_credit_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_credit_To.TabIndex = 21
        Me.dtp_credit_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_credit_load_Report
        '
        Me.btn_credit_load_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_credit_load_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_credit_load_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_credit_load_Report.ForeColor = System.Drawing.Color.White
        Me.btn_credit_load_Report.Location = New System.Drawing.Point(987, 6)
        Me.btn_credit_load_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_credit_load_Report.Name = "btn_credit_load_Report"
        Me.btn_credit_load_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_credit_load_Report.TabIndex = 20
        Me.btn_credit_load_Report.Text = "Load Report"
        Me.btn_credit_load_Report.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date From:"
        '
        'dtp_credit_From
        '
        Me.dtp_credit_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_credit_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_credit_From.Location = New System.Drawing.Point(325, 15)
        Me.dtp_credit_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_credit_From.Name = "dtp_credit_From"
        Me.dtp_credit_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_credit_From.TabIndex = 18
        Me.dtp_credit_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 402)
        Me.Controls.Add(Me.tc_Sales)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSales"
        Me.Text = "frmSales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tc_Sales.ResumeLayout(False)
        Me.tp_All.ResumeLayout(False)
        Me.pnl_all_Top.ResumeLayout(False)
        Me.pnl_all_Top.PerformLayout()
        Me.tp_Cash.ResumeLayout(False)
        Me.pnl_cash_Top.ResumeLayout(False)
        Me.pnl_cash_Top.PerformLayout()
        Me.tp_Credit.ResumeLayout(False)
        Me.pnl_credit_Top.ResumeLayout(False)
        Me.pnl_credit_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tc_Sales As TabControl
    Friend WithEvents tp_Cash As TabPage
    Friend WithEvents rv_Cash As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_Cash_Right As Panel
    Friend WithEvents pnl_cash_Left As Panel
    Friend WithEvents pnl_cash_Bottom As Panel
    Friend WithEvents pnl_cash_Top As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_cash_To As DateTimePicker
    Friend WithEvents btn_load_cash_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_cash_From As DateTimePicker
    Friend WithEvents tp_Credit As TabPage
    Friend WithEvents rv_Credit As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnl_credit_Bottom As Panel
    Friend WithEvents pnl_credit_Top As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_credit_To As DateTimePicker
    Friend WithEvents btn_credit_load_Report As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_credit_From As DateTimePicker
    Friend WithEvents cbo_search_Cash As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_search_Credit As ComboBox
    Friend WithEvents tp_All As TabPage
    Friend WithEvents rv_All As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_all_Right As Panel
    Friend WithEvents pnl_all_Left As Panel
    Friend WithEvents pnl_all_Bottom As Panel
    Friend WithEvents pnl_all_Top As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_search_All As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtp_all_To As DateTimePicker
    Friend WithEvents btn_all_load_Report As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_all_From As DateTimePicker
End Class
