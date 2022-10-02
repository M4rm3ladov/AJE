Imports Microsoft.Reporting.WinForms
Public Class frmStockInReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_stock_In.Reset()
        Me.Close()
    End Sub

    Private Sub btn_load_stock_in_Report_Click(sender As Object, e As EventArgs) Handles btn_load_stock_in_Report.Click
        'Dim ds As New DataSet1
        'Dim dt As New DataTable

        'dt = ds.Tables("dt_stock_In")

        'For i = 0 To frmStockIn_History.dg_stock_History.Rows.Count - 1
        '    dt.Rows.Add(frmStockIn_History.dg_stock_History.Rows(i).Cells(1).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(2).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(4).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(5).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(6).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(7).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(8).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(9).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(10).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(11).Value,
        '                frmStockIn_History.dg_stock_History.Rows(i).Cells(12).Value)
        'Next

        'With rv_stock_In.LocalReport
        '    .ReportEmbeddedResource = "AJE.ReportStockIn.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportStockIn.rdlc"
        '    .DataSources.Clear()
        '    .DataSources.Add(New ReportDataSource("DataSet1", dt))
        'End With

        'Dim rptParameter As ReportParameterCollection
        'rptParameter = New ReportParameterCollection
        'rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
        'rptParameter.Add(New ReportParameter("DateFrom", dtp_stock_in_From.Value.ToString("MM/dd/yy")))
        'rptParameter.Add(New ReportParameter("DateTill", dtp_stock_in_To.Value.ToString("MM/dd/yy")))
        'rv_stock_In.LocalReport.SetParameters(rptParameter)

        'rv_stock_In.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'rv_stock_In.ZoomMode = ZoomMode.PageWidth

        'rv_stock_In.RefreshReport()
    End Sub

    Private Sub frmStockInReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        'dtp_stock_in_From.Value = DateTime.Now
        'dtp_stock_in_To.Value = DateTime.Now
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("dt_stock_In")

        For i = 0 To frmStockIn_History.dg_stock_History.Rows.Count - 1
            dt.Rows.Add(frmStockIn_History.dg_stock_History.Rows(i).Cells(1).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(2).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(4).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(5).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(6).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(7).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(8).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(9).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(10).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(11).Value,
                        frmStockIn_History.dg_stock_History.Rows(i).Cells(12).Value)
        Next

        With rv_stock_In.LocalReport
            .ReportEmbeddedResource = "AJE.ReportStockIn.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportStockIn.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Dim rptParameter As ReportParameterCollection
        rptParameter = New ReportParameterCollection
        rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
        rptParameter.Add(New ReportParameter("DateFrom", frmStockIn_History.dtp_From.Value.ToString("MM/dd/yy")))
        rptParameter.Add(New ReportParameter("DateTill", frmStockIn_History.dtp_To.Value.ToString("MM/dd/yy")))
        rv_stock_In.LocalReport.SetParameters(rptParameter)

        rv_stock_In.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rv_stock_In.ZoomMode = ZoomMode.PageWidth

        rv_stock_In.RefreshReport()
    End Sub
End Class