Imports System.Data.SqlClient

Public Class Sucursal
    Inherits Connection

    Public Function GetCodigos() As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = "SELECT codigo FROM Sucursal"

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function
End Class
