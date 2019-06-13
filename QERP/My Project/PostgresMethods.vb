Imports ADODB
Imports Npgsql
Imports System
Imports System.Data.SqlClient

Module PostgresMethods

    Public Const DevConnectionString As String = "Driver={PostgreSQL ANSI};" &
            "Server=192.168.0.57;" &
            "Database=DEV;" &
            "User ID=SIGM;" &
            "Port=5493"

    Public Const LogConnectionString As String = "Driver={PostgreSQL ANSI};" &
            "Server=192.168.0.250;" &
            "Database=LOG;" &
            "User ID=SIGM;" &
            "Port=5493"

    Public Const ProdConnectionString As String = "Driver={PostgreSQL ANSI};" &
            "Server=192.168.0.250;" &
            "Database=QuatroAir;" &
            "User ID=SIGM;" &
            "Port=5493"

    Public Const NpgsqlDevConnString As String = "Host=192.168.0.57;Port=5493;Database=DEV;Username=SIGM;Encoding=ASCII;"

    Public Function PostgresQuery(Query As String, ConnectionString As String)
        Dim PostgresConnection As New ADODB.Connection
        Dim Record As New ADODB.Recordset
        Dim QueryRecord As Array = Nothing

        If Query IsNot Nothing Then
            PostgresConnection.Open(ConnectionString)
            Record.CursorLocation = 3
            Record.Open(Query, PostgresConnection, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If Not Record.EOF Then
                QueryRecord = Record.GetRows()
            Else
                QueryRecord = Nothing
            End If
            Record.Close()
            PostgresConnection.Close()
        End If

        Return QueryRecord
    End Function

    Public Sub PostgresStatement(Statement As String, ConnectionString As String)
        Dim PostgresConnection As New ADODB.Connection
        PostgresConnection.Open(ConnectionString)
        PostgresConnection.Execute(Statement)
        PostgresConnection.Close()
    End Sub

    Public Sub NpgsqlQuery()
        Dim ConnString As String = "Host=192.168.0.57;Port=5493;Database=DEV;Username=SIGM;"
        Dim PostgresConnection As New Npgsql.NpgsqlConnection(ConnString)

        PostgresConnection.Open()
        Dim PostgresCommand As New Npgsql.NpgsqlCommand("SELECT prt_no FROM part", PostgresConnection)
        Dim reader = PostgresCommand.ExecuteReader()
        While reader.Read
            Console.WriteLine(reader.GetString(0))
        End While
        PostgresConnection.Close()
    End Sub

    Public Function NpgsqlDataset(Query As String, ConnectionString As String)


        Dim PostgresConnection As New Npgsql.NpgsqlConnection(ConnectionString)

        PostgresConnection.Open()

        Dim PostgresTable As New DataTable
        Using PostgresDataAdapter As New NpgsqlDataAdapter(Query, PostgresConnection)
            PostgresDataAdapter.Fill(PostgresTable)
        End Using

        PostgresConnection.Close()

        Return PostgresTable
    End Function
End Module
