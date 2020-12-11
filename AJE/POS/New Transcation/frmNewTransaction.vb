Public Class frmNewTransaction
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
    Private Sub btn_Cash_Click(sender As Object, e As EventArgs) Handles btn_Cash.Click
        frmPos.lbl_pay_Type.Text = "Cash"
        frmPos.dg_Order.Rows.Clear()
        frmPos.lbl_due_Total.Text = "0.00"
        frmPos.lbl_customer_Id.Text = vbNullString
        frmPos.tb_customer_Name.Text = vbNullString
        frmPos.lbl_Customer.Enabled = False
        Me.Close()
    End Sub

    Private Sub btn_Credit_Click(sender As Object, e As EventArgs) Handles btn_Credit.Click
        frmPos.lbl_pay_Type.Text = "Credit"
        frmPos.dg_Order.Rows.Clear()
        frmPos.lbl_due_Total.Text = "0.00"
        frmPos.lbl_customer_Id.Text = vbNullString
        frmPos.tb_customer_Name.Text = vbNullString
        frmPos.lbl_Customer.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class