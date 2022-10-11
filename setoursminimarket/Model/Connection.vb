Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class Connection
    Private ReadOnly connectionString As String

    Public Sub New()
        'connectionString = ConfigurationManager.ConnectionStrings("connMinimarket").ToString()
        connectionString = "Data Source=DESKTOP-N7U2R53;Initial Catalog=Minimarket;Integrated Security=True"
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
