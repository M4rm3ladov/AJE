﻿Public Class frmSupplierEntry
    Dim supplier As New clsSupplier
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Me.tb_Name.Text.Trim = vbNullString Or Me.tb_Address.Text.Trim = vbNullString Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            supplier.SupplierName = Trim(Me.tb_Name.Text)
            supplier.SupplierAddress = Trim(Me.tb_Address.Text)
            If supplier.checkSupplierDuplicate("save") = True Then
                MsgBox("Supplier name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                supplier.SupplierName = Trim(Me.tb_Name.Text)
                supplier.SupplierAddress = Trim(Me.tb_Address.Text)
                If supplier.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    tb_Name.Clear()
                    tb_Address.Clear()
                    lbl_Id.Text = vbNullString
                    tb_Address.Focus()
                    frmSupplier.tb_Search.Text = vbNullString
                    supplier.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
            supplier.SupplierName = Trim(Me.tb_Name.Text)
            supplier.SupplierAddress = Trim(Me.tb_Address.Text)
            supplier.SupplierId = Trim(Me.lbl_Id.Text)
            If supplier.checkSupplierDuplicate("update") = True Then
                MsgBox("Supplier name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                supplier.SupplierId = Me.lbl_Id.Text
                supplier.SupplierName = Trim(Me.tb_Name.Text)
                supplier.SupplierAddress = Trim(Me.tb_Address.Text)
                If supplier.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    frmSupplier.tb_Search.Clear()
                    supplier.loadRecord()
                End If
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_Address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Address.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

End Class