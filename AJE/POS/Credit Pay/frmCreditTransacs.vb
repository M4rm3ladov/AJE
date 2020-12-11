Public Class frmCreditTransacs
    Dim credPay As New clsCreditPay

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseDown, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseMove, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseUp, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frmCreditTransacs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        credPay.loadTransactions(orderId)
        lbl_due_Total.Text = Format(credPay.loadOrderTotal(orderId), "0.00")
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        credPay.loadTransactions(orderId)
    End Sub
End Class