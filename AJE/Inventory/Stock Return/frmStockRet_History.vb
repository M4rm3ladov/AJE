Public Class frmStockRet_History
    Dim stockRetHistory As New clsStockHistory
    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockRetHistory.SetBranch(frmStock.tb_branch_sR.Text)
        stockRetHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockRetHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockRetHistory.loadStockRetHistory()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        dg_stock_History.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frmStockRet_History_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_From.Value = DateTime.Now
        dtp_To.Value = DateTime.Now
    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        frmStockReturnReport.ShowDialog()
    End Sub
End Class