Imports System.Data.OleDb

Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public LokasiDB As String
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public RD As OleDbDataReader

    Public Sub Connection()
        LokasiDB = "Provider=Microsoft.JET.OLEDB.4.0; Data Source = Kasir.mdb"
        CONN = New OleDbConnection(LokasiDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module