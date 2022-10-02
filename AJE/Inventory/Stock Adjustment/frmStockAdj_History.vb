Public Class frmStockAdj_History
    Dim stockAdjHistory As New clsStockHistory
    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockAdjHistory.SetBranch(frmStock.tb_branch_sA.Text)
        stockAdjHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockAdjHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockAdjHistory.loadStockAdjustHistory()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        dg_stock_History.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frmStockAdj_History_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_From.Value = DateTime.Now
        dtp_To.Value = DateTime.Now
    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        Try
            frmStockAdjustReport.ShowDialog()
        Catch ex As Exception
            MsgBox("Could not load Report with exception: " & ex.ToString, vbCritical)
        End Try
    End Sub
End Class