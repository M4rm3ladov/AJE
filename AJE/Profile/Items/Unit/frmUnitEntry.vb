Public Class frmUnitEntry
    Dim unit As New clsUnit
    Dim item As New clsItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Me.tb_Unit.Text.Trim = vbNullString Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            unit.SetUnitName(Trim(Me.tb_Unit.Text))
            If unit.checkUnitDuplicate = True Then
                MsgBox("Unit name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                unit.SetUnitName(Trim(Me.tb_Unit.Text))
                If unit.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    tb_Unit.Clear()
                    tb_Unit.Focus()
                    frmItem.tb_search_Unit.Text = vbNullString
                    unit.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
            unit.SetUnitName(Trim(Me.tb_Unit.Text))
            unit.SetUnitId(lbl_Id.Text)
            If unit.checkUnitDuplicate = True Then
                MsgBox("Unit name is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                unit.SetUnitId(Me.lbl_Id.Text)
                unit.SetUnitName(Trim(Me.tb_Unit.Text))
                If unit.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    frmItem.tb_search_Unit.Clear()
                    unit.loadRecord()
                    item.loadRecord()
                End If
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class