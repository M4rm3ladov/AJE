Imports Microsoft.Reporting.WinForms
Public Class frmStockAdjustReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_Adjust.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_stock_adjust_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_adjust_Report.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_Adjust")

        For i = 0 To frmStockAdj_History.dg_stock_History.Rows.Count - 1
            dt.Rows.Add(frmStockAdj_History.dg_stock_History.Rows(i).Cells(1).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(2).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(4).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(5).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(6).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(7).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(8).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(9).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(10).Value,
                        frmStockAdj_History.dg_stock_History.Rows(i).Cells(11).Value)
        Next

        With rv_stock_Adjust.LocalReport
            .ReportPath = Application.StartupPath & "\Report\ReportStockAdjustment.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Dim rptParameter As ReportParameterCollection
        rptParameter = New ReportParameterCollection
        rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
        rptParameter.Add(New ReportParameter("DateFrom", dtp_stock_adjust_From.Value.ToString("MM/dd/yy")))
        rptParameter.Add(New ReportParameter("DateTill", dtp_stock_adjust_To.Value.ToString("MM/dd/yy")))
        rv_stock_Adjust.LocalReport.SetParameters(rptParameter)

        rv_stock_Adjust.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Adjust.ZoomMode = ZoomMode.PageWidth

        rv_stock_Adjust.RefreshReport()
    End Sub

    Private Sub frmStockAdjustReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_stock_adjust_From.Value = DateTime.Now
        dtp_stock_adjust_To.Value = DateTime.Now
    End Sub
End Class