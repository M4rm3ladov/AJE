Public Class frmBrandCat
    Dim category As New clsCategory
    Dim brand As New clsBrand
    Dim item As New clsItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tb_brand_Cat.Clear()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If tb_brand_Cat.Text.Trim = vbNullString Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If lbl_Header.Text = "Category" Then
            Try
                Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
                category.SetCategoryName(Trim(Me.tb_brand_Cat.Text))
                If category.checkCategoryDuplicate = True Then
                    MsgBox("Branch name is already existing.", vbInformation)
                    Exit Sub
                End If
                If result = vbYes Then
                    category.SetCategoryName(Trim(Me.tb_brand_Cat.Text))
                    If category.save = True Then
                        MsgBox("Record has been successfully saved.", vbInformation)
                        tb_brand_Cat.Clear()
                        tb_brand_Cat.Focus()
                        frmItem.tb_search_Category.Text = vbNullString
                        category.loadRecord()
                    End If
                End If
            Catch ex As Exception

            End Try
        ElseIf lbl_Header.Text = "Brand" Then
            Try
                Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
                brand.SetBrandName(Trim(Me.tb_brand_Cat.Text))
                If brand.checkBrandDuplicate = True Then
                    MsgBox("Branch name is already existing.", vbInformation)
                    Exit Sub
                End If
                If result = vbYes Then
                    brand.SetBrandName(Trim(Me.tb_brand_Cat.Text))
                    If brand.save = True Then
                        MsgBox("Record has been successfully saved.", vbInformation)
                        tb_brand_Cat.Clear()
                        tb_brand_Cat.Focus()
                        frmItem.tb_search_Brand.Text = vbNullString
                        brand.loadRecord()
                    End If
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If lbl_Header.Text = "Category" Then
            Try
                Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
                category.SetCategoryName(Trim(tb_brand_Cat.Text))
                category.SetCategoryId(lbl_brand_Cat.Text)
                If category.checkCategoryDuplicate = True Then
                    MsgBox("Branch name is already existing.", vbInformation)
                    Exit Sub
                End If
                If result = vbYes Then
                    category.SetCategoryId(Me.lbl_brand_Cat.Text)
                    category.SetCategoryName(Trim(Me.tb_brand_Cat.Text))
                    If category.edit = True Then
                        MsgBox("Record has been successfully updated.", vbInformation)
                        tb_brand_Cat.Clear()
                        tb_brand_Cat.Focus()
                        frmItem.tb_search_Category.Clear()
                        category.loadRecord()
                    End If
                    Me.Close()
                End If
            Catch ex As Exception

            End Try
        ElseIf lbl_Header.Text = "Brand" Then
            Try
                Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
                brand.SetBrandName(Trim(tb_brand_Cat.Text))
                brand.SetBrandId(lbl_brand_Cat.Text)
                If brand.checkBrandDuplicate = True Then
                    MsgBox("Brand name is already existing.", vbInformation)
                    Exit Sub
                End If
                If result = vbYes Then
                    brand.SetBrandId(Me.lbl_brand_Cat.Text)
                    brand.SetBrandName(Trim(Me.tb_brand_Cat.Text))
                    If brand.edit = True Then
                        MsgBox("Record has been successfully updated.", vbInformation)
                        tb_brand_Cat.Clear()
                        tb_brand_Cat.Focus()
                        frmItem.tb_search_Brand.Clear()
                        brand.loadRecord()
                        item.loadRecord()
                    End If
                    Me.Close()
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    'Private Sub tb_brand_Cat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_brand_Cat.KeyPress
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
    '        If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

End Class