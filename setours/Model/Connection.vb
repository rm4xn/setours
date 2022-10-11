Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class Connection
    Private ReadOnly connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("connectionString").ToString()
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
