Imports System.Data.SqlClient

Module Connection
    Public ConStr As String = "Data Source= DESKTOP-GS59730\SQLEXPRESS;Initial Catalog = Sales_DB;integrated security=true"
    Public Con As New SqlClient.SqlConnection(ConStr)

End Module
