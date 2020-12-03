Imports Microsoft.Reporting.WinForms
Public Class frmStockTransferReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_Transfer.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_stock_in_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_trans_Report.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_Transfer")

        For i = 0 To frmStockTrans_History.dg_stock_History.Rows.Count - 1
            dt.Rows.Add(frmStockTrans_History.dg_stock_History.Rows(i).Cells(1).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(2).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(4).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(5).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(6).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(7).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(8).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(9).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(10).Value,
                        frmStockTrans_History.dg_stock_History.Rows(i).Cells(11).Value)
        Next

        With rv_stock_Transfer.LocalReport
            .ReportPath = Application.StartupPath & "\Report\ReportStockTransfer.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        rv_stock_Transfer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Transfer.ZoomMode = ZoomMode.PageWidth

        rv_stock_Transfer.RefreshReport()
    End Sub

End Class