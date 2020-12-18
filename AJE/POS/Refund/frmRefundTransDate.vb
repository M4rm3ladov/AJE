Public Class frmRefundTransDate
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        tb_Remarks.Clear()
        dtp_Date.Value = DateTime.Now
        Me.Close()
    End Sub

    Private Sub btn_Continue_Click(sender As Object, e As EventArgs) Handles btn_Continue.Click
        frmAuthenticate.btn_Ok.Text = "Ok"
        frmAuthenticate.lbl_Type.Text = 4
        frmAuthenticate.ShowDialog()
        tb_Remarks.Clear()
        dtp_Date.Value = DateTime.Now
        Me.Close()
    End Sub

    Private Sub frmRefundTransDate_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_Date.Value = DateTime.Now
    End Sub
End Class