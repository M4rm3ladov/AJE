Imports MySql.Data.MySqlClient
Public Class clsUser
    Public Property GName
    Public Property Mi
    Public Property Surname
    Public Property Suffix
    Public Property Username
    Public Property Password
    Public Property Salt
    Public Property UserType
    Public Property BranchId
    Public Property Branch
    Public Property Active
    Public Property Id
    Public Property UserSearch
    Public Function save()
        Dim _id As Integer
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO users (branch_id, username, password, salt, user_type, is_active) " &
                            "VALUES (@branch_id, @username, @password, @salt, @user_type, @is_active); " &
                            "SELECT LAST_INSERT_ID(); "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.Parameters.AddWithValue("@username", Username)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@salt", Salt)
            cm.Parameters.AddWithValue("@user_type", UserType)
            cm.Parameters.AddWithValue("@is_active", Active)
            _id = CInt(cm.ExecuteScalar)
            cm.Dispose()

            query = "INSERT INTO user_details (user_id, user_surname, user_gname, user_mi, user_suffix) " &
                "VALUES (" & _id & ", @user_surname, @user_gname, @user_mi, @user_suffix)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_surname", Surname)
            cm.Parameters.AddWithValue("@user_gname", GName)
            cm.Parameters.AddWithValue("@user_mi", Mi)
            cm.Parameters.AddWithValue("@user_suffix", Suffix)
            cm.ExecuteScalar()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function edit()
        Try
            ConnectDatabase()
            Dim query = "UPDATE users SET branch_id=@branch_id, is_active=@is_active WHERE user_id=@user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.Parameters.AddWithValue("@is_active", Active)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function delete()
        Try
            ConnectDatabase()
            Dim query = "DELETE FROM user_details WHERE user_id = @user_id
                        ;DELETE FROM users WHERE user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkUserExists() 'checks if item is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT COUNT(*) FROM cashier WHERE user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            Dim count = cm.ExecuteScalar()

            query = "SELECT COUNT(*) FROM manager WHERE user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            Dim count2 = count + cm.ExecuteScalar
            If count2 > 0 Then
                Return True
                DisconnectDatabase()
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function changePass()
        Try
            ConnectDatabase()
            Dim query = "UPDATE users SET password = @password, salt = @salt WHERE username = @username"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@salt", Salt)
            cm.Parameters.AddWithValue("@username", Username)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmUser.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS _username, user_type, is_active FROM users " &
                    "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                    "INNER JOIN branch ON branch.branch_id = users.branch_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("_username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_Count.Text = "(" & frmUser.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Function checkUserDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT username FROM users WHERE username = @username"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@username", Username)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                DisconnectDatabase()
                Return True
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadBranch()
        ConnectDatabase()
        Dim query = "SELECT branch_address FROM branch ORDER BY branch_address"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "branch_address")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With frmUserEntry.cbo_Branch
                .Items.Add(ds.Tables(0).Rows(i)("branch_address").ToString)
            End With
        Next
        DisconnectDatabase()
    End Sub
    Public Sub loadBranchId()
        ConnectDatabase()
        Dim query = "SELECT branch_id FROM branch WHERE branch_address=@branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", Branch)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                frmUserEntry.lbl_branch_Id.Text = dr(0).ToString
            End While
        End If
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Function loadPassword(_username As String)
        ConnectDatabase()
        Dim query = "SELECT CAST(password AS CHAR) FROM users WHERE username=@username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _username)
        Return cm.ExecuteScalar
    End Function
    Public Sub searchUser(query As String)
        Dim i As Integer
        frmUser.DataGridView1.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", UserSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_Count.Text = "(" & frmUser.DataGridView1.RowCount & ") Record(s) found."
    End Sub

End Class
