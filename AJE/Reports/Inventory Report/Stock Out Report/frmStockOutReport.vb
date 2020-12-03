Imports Microsoft.Reporting.WinForms
Public Class frmStockOutReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_Out.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_stock_out_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_out_Report.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_Out")

        For i = 0 To frmStockOut_History.dg_stock_History.Rows.Count - 1
            dt.Rows.Add(frmStockOut_History.dg_stock_History.Rows(i).Cells(1).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(2).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(4).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(5).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(6).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(7).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(8).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(9).Value,
                        frmStockOut_History.dg_stock_History.Rows(i).Cells(10).Value)
        Next

        With rv_stock_Out.LocalReport
            .ReportPath = Application.StartupPath & "\Report\ReportStockOut.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Dim rptParameter As ReportParameterCollection
        rptParameter = New ReportParameterCollection
        rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
        rptParameter.Add(New ReportParameter("DateFrom", dtp_stock_out_From.Value.ToString("MM/dd/yy")))
        rptParameter.Add(New ReportParameter("DateTill", dtp_stock_out_To.Value.ToString("MM/dd/yy")))
        rv_stock_Out.LocalReport.SetParameters(rptParameter)

        rv_stock_Out.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Out.ZoomMode = ZoomMode.PageWidth

        rv_stock_Out.RefreshReport()
    End Sub

    Private Sub frmStockOutReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_stock_out_From.Value = DateTime.Now
        dtp_stock_out_To.Value = DateTime.Now
    End Sub
End Class