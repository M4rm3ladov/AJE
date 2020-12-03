Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmStockCountReport
    Private Sub btn_load_stock_count_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_count_Report.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_list")

        For i = 0 To frmStock.dg_stock_List.Rows.Count - 1
            dt.Rows.Add(frmStock.dg_stock_List.Rows(i).Cells(3).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(4).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(5).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(6).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(7).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(8).Value,
                        frmStock.dg_stock_List.Rows(i).Cells(9).Value)
        Next

        With rv_stock_Count.LocalReport
            .ReportPath = Application.StartupPath & "\Report\ReportCountStock.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        rv_stock_Count.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Count.ZoomMode = ZoomMode.PageWidth

        rv_stock_Count.RefreshReport()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_Count.Reset()
        Me.Close()
    End Sub
End Class