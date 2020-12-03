Public Class frmBranchEntry
    Dim branch As New clsBranch
    Dim item As New clsItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Me.tb_Address.Text.Trim = vbNullString Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            branch.BranchName = Trim(Me.tb_Address.Text)
            If branch.checkBranchDuplicate = True Then
                MsgBox("Branch name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                branch.BranchName = Trim(Me.tb_Address.Text)
                If branch.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    tb_Address.Clear()
                    lbl_Id.Text = vbNullString
                    tb_Address.Focus()
                    frmBranch.tb_Search.Text = vbNullString
                    branch.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
            branch.BranchName = Trim(Me.tb_Address.Text)
            branch.BranchId = lbl_Id.Text
            If branch.checkBranchDuplicate = True Then
                MsgBox("Branch name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                branch.BranchId = Me.lbl_Id.Text
                branch.BranchName = Trim(Me.tb_Address.Text)
                If branch.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    frmBranch.tb_Search.Clear()
                    branch.loadRecord()
                    item.loadRecord()
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

    Private Sub frmBranchEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_Address.Focus()
    End Sub
End Class