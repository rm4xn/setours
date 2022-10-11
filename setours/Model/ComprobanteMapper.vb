Imports System.Data.SqlClient

Public Class ComprobanteMapper
    Inherits Connection

    Public Sub New()

    End Sub

    Public Function GetComprobantes() As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = ""
                'command.Parameters.Add(param)

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function
End Class
