Imports MySql.Data.MySqlClient
Public Class clsCreditLimit
    Public Property CreditLimit
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "UPDATE misc SET credit_limit = @credit_limit WHERE misc_id = 1 "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@credit_limit", CreditLimit)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function getCreditLimit()
        Try
            ConnectDatabase()
            Dim query = "SELECT credit_limit FROM misc WHERE misc_id = 1"
            cm = New MySqlCommand(query, con)
            Dim creditL = Convert.ToInt16(cm.ExecuteScalar())
            DisconnectDatabase()
            Return creditL
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
End Class
