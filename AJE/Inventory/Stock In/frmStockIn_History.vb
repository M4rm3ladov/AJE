Public Class frmStockIn_History
    Dim stockInHistory As New clsStockHistory
    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockInHistory.SetBranch(frmStock.tb_branch_stock_In.Text)
        stockInHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockInHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockInHistory.loadStockHistory()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        dg_stock_History.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frmStockIn_History_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_From.Value = DateTime.Now
        dtp_To.Value = DateTime.Now
    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        frmStockInReport.ShowDialog()
    End Sub
End Class