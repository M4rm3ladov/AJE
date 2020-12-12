Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_cash_From.Value = DateTime.Now
        dtp_cash_To.Value = DateTime.Now
        dtp_credit_From.Value = DateTime.Now
        dtp_credit_To.Value = DateTime.Now
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_Cash.Reset()
        rv_Credit.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_cash_Report_Click_1(sender As Object, e As EventArgs) Handles btn_load_cash_Report.Click
        Dim rptDs As ReportDataSource
        Me.rv_Cash.RefreshReport()
        Try
            With rv_Cash.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_cash_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_cash_To.Value.ToString("MM/dd/yy")))
            rv_Cash.LocalReport.SetParameters(rptParameter)

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, receipt, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_cash_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND trans_date BETWEEN '" & dtp_cash_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cash_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_cash_Sales"))
            DisconnectDatabase()

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
        Me.rv_Credit.RefreshReport()
        Try
            With rv_Credit.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Report2.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, Customers, invoice, Description, Category, Unit, price, qty, line_total, Cashiers FROM vw_credit_sales WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND trans_date BETWEEN '" & dtp_credit_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_credit_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_credit_Sales"))
            DisconnectDatabase()

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
End Class