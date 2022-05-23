Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_cash_From.Value = DateTime.Now
        dtp_cash_To.Value = DateTime.Now
        dtp_credit_From.Value = DateTime.Now
        dtp_credit_To.Value = DateTime.Now
        dtp_all_From.Value = DateTime.Now
        dtp_all_To.Value = DateTime.Now
        cbo_search_All.SelectedIndex = 0
        cbo_search_Cash.SelectedIndex = 0
        cbo_search_Credit.SelectedIndex = 0
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_All.Reset()
        rv_Cash.Reset()
        rv_Credit.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_cash_Report_Click_1(sender As Object, e As EventArgs) Handles btn_load_cash_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_Cash.LocalReport
                .ReportEmbeddedResource = "AJE.Report1.rdlc" '.ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_Cash.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_cash_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_cash_To.Value.ToString("MM/dd/yy")))
            rv_Cash.LocalReport.SetParameters(rptParameter)

            ConnectDatabase()
            Dim query As String
            If cbo_search_Cash.SelectedIndex = 0 Then
                query = "SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, receipt, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_cash_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND transDate BETWEEN '" & dtp_cash_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cash_To.Value.ToString("yyyy-MM-dd") & "'"
                da.SelectCommand = New MySqlCommand(query, con)
                da.Fill(ds.Tables("dt_cash_Sales"))
                DisconnectDatabase()
            ElseIf cbo_search_Cash.SelectedIndex = 1 Then
                query = "SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, receipt, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_cash_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND DateInputed BETWEEN '" & dtp_cash_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cash_To.Value.ToString("yyyy-MM-dd") & "'"
                da.SelectCommand = New MySqlCommand(query, con)
                da.Fill(ds.Tables("dt_cash_Sales"))
                DisconnectDatabase()
            End If
            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_cash_Sales"))
            rv_Cash.LocalReport.DataSources.Add(rptDs)
            rv_Cash.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Cash.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_credit_load_Report_Click(sender As Object, e As EventArgs) Handles btn_credit_load_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_Credit.LocalReport
                .ReportEmbeddedResource = "AJE.Report2.rdlc" '.ReportPath = Application.StartupPath & "\Report\Report2.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_Credit.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cbo_search_Credit.SelectedIndex = 0 Then
                ConnectDatabase()
                da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, Customers, invoice, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_credit_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND transDate BETWEEN '" & dtp_credit_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_credit_To.Value.ToString("yyyy-MM-dd") & "'", con)
                da.Fill(ds.Tables("dt_credit_Sales"))
                DisconnectDatabase()
            ElseIf cbo_search_Credit.SelectedIndex = 1 Then
                ConnectDatabase()
                da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, Customers, invoice, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_credit_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND DateInputed BETWEEN '" & dtp_credit_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_credit_To.Value.ToString("yyyy-MM-dd") & "'", con)
                da.Fill(ds.Tables("dt_credit_Sales"))
                DisconnectDatabase()
            End If

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_credit_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_credit_To.Value.ToString("MM/dd/yy")))
            rv_Credit.LocalReport.SetParameters(rptParameter)

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_credit_Sales"))
            rv_Credit.LocalReport.DataSources.Add(rptDs)
            rv_Credit.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Credit.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_all_load_Report_Click(sender As Object, e As EventArgs) Handles btn_all_load_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_All.LocalReport
                .ReportEmbeddedResource = "AJE.ReportAllSales.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportAllSales.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_All.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cbo_search_All.SelectedIndex = 0 Then
                ConnectDatabase()
                da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, Customers, invoice, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_all_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND transDate BETWEEN '" & dtp_all_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_all_To.Value.ToString("yyyy-MM-dd") & "'", con)
                da.Fill(ds.Tables("dt_all_Sales"))
                DisconnectDatabase()
            ElseIf cbo_search_All.SelectedIndex = 1 Then
                ConnectDatabase()
                da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, Customers, invoice, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_all_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND DateInputed BETWEEN '" & dtp_all_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_all_To.Value.ToString("yyyy-MM-dd") & "'", con)
                da.Fill(ds.Tables("dt_all_Sales"))
                DisconnectDatabase()
            End If

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_all_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_all_To.Value.ToString("MM/dd/yy")))
            rv_All.LocalReport.SetParameters(rptParameter)

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_all_Sales"))
            rv_All.LocalReport.DataSources.Add(rptDs)
            rv_All.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_All.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class