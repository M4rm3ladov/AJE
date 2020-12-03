Imports Microsoft.Reporting.WinForms
Public Class frmStockReturnReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_Return.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_stock_in_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_return_Report.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_Return")

        For i = 0 To frmStockRet_History.dg_stock_History.Rows.Count - 1
            dt.Rows.Add(frmStockRet_History.dg_stock_History.Rows(i).Cells(1).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(2).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(4).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(5).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(6).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(7).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(8).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(9).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(10).Value,
                        frmStockRet_History.dg_stock_History.Rows(i).Cells(11).Value)
        Next

        With rv_stock_Return.LocalReport
            .ReportPath = Application.StartupPath & "\Report\ReportStockReturn.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        rv_stock_Return.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Return.ZoomMode = ZoomMode.PageWidth

        rv_stock_Return.RefreshReport()
    End Sub

End Class