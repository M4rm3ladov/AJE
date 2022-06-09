Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class frmVoidReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_load_void_Report_Click(sender As Object, e As EventArgs) Handles btn_load_void_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_Void.LocalReport
                .ReportEmbeddedResource = "AJE.ReportVoid.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportRefund.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_Void.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_void_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_void_To.Value.ToString("MM/dd/yy")))
            rv_Void.LocalReport.SetParameters(rptParameter)

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, receipt, Description, Category, Unit, price, qty, line_total, Cashiers, Managers, remarks FROM vw_void_cash WHERE trans_date BETWEEN '" & dtp_void_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_void_To.Value.ToString("yyyy-MM-dd") & "' AND branch_id = '" & frmMain.lbl_branch_Id.Text & "'", con)
            da.Fill(ds.Tables("dt_cash_void"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_cash_void"))
            rv_Void.LocalReport.DataSources.Add(rptDs)
            rv_Void.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Void.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmRefundReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_void_From.Value = DateTime.Now
        dtp_void_To.Value = DateTime.Now
        dtp_credit_From.Value = DateTime.Now
        dtp_credit_To.Value = DateTime.Now
    End Sub

    Private Sub btn_load_credit_Report_Click(sender As Object, e As EventArgs) Handles btn_load_credit_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_credit_void.LocalReport
                .ReportEmbeddedResource = "AJE.ReportCreditVoid.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportRefund.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_credit_void.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_credit_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_credit_To.Value.ToString("MM/dd/yy")))
            rv_credit_void.LocalReport.SetParameters(rptParameter)

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, invoice, Description, Category, Unit, price, qty, line_total, Cashiers, Managers, remarks FROM vw_void_credit WHERE trans_date BETWEEN '" & dtp_credit_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_credit_To.Value.ToString("yyyy-MM-dd") & "' AND branch_id = '" & frmMain.lbl_branch_Id.Text & "'", con)
            da.Fill(ds.Tables("dt_credit_void"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_credit_void"))
            rv_credit_void.LocalReport.DataSources.Add(rptDs)
            rv_credit_void.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_credit_void.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class