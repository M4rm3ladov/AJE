Public Class frmOrderTransacs
    Dim void As New clsVoid
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

    Private Sub frmOrderTransacs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim orderId = frmVoid.dg_Search.Item(0, frmVoid.dg_Search.CurrentRow.Index).Value
        void.SetOrderId(orderId)
        void.loadTransactions()
        lbl_due_Total.Text = Format(void.loadOrderTotal(), "0.00")
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim orderId = frmVoid.dg_Search.Item(0, frmVoid.dg_Search.CurrentRow.Index).Value
        void.SetOrderId(orderId)
        void.loadTransactions()
    End Sub
End Class