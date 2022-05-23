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
            .ReportEmbeddedResource = "AJE.ReportStockTransfer.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportStockTransfer.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Dim rptParameter As ReportParameterCollection
        rptParameter = New ReportParameterCollection
        rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
        rptParameter.Add(New ReportParameter("DateFrom", dtp_stock_trans_From.Value.ToString("MM/dd/yy")))
        rptParameter.Add(New ReportParameter("DateTill", dtp_stock_trans_To.Value.ToString("MM/dd/yy")))
        rv_stock_Transfer.LocalReport.SetParameters(rptParameter)

        rv_stock_Transfer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_Transfer.ZoomMode = ZoomMode.PageWidth

        rv_stock_Transfer.RefreshReport()
    End Sub

    Private Sub frmStockTransferReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_stock_trans_From.Value = DateTime.Now
        dtp_stock_trans_To.Value = DateTime.Now
    End Sub
End Class