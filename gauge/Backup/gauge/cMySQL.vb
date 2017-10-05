Imports MySql.Data.MySqlClient
Imports System.Data

Public Class cMySQL
    Private Conn As New MySqlConnection
    'Private myCommand As New MySqlCommand
    'Private myAdapter As New MySqlDataAdapter
    'Private myData As New DataSet
    'Private myData2 As New MySqlDataReader


    Public Function Connect(ByVal ConString As String) As Boolean
        Dim IsConnect As Boolean = False
        'create conection string
        'ConString = "server=" & Host & ";user id=" & User & ";password=" & Password & ";database=" & Database & ";"
        'create conection to mySQL Server with connection string
        Conn = New MySqlConnection
        Conn.ConnectionString = ConString
        'Get a real connection
        IsConnect = False
        Try
            Conn.Open()
            IsConnect = True
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Server Database: " & myerror.Message)
            IsConnect = False
        End Try
        'Form1.oMySQL.DisConnect()
        Return IsConnect
    End Function

    Public Function DisConnect() As Boolean
        Dim IsDisconnect As Boolean = False
        Try
            Conn.Close()
            IsDisconnect = True
        Catch myError As MySqlException
            MessageBox.Show("Error Connecting to Server Database: " & myError.Message)
            IsDisconnect = False

        End Try
        Return IsDisconnect
    End Function

    Public Function GetData(ByVal MyQuery As String) As DataSet
        Dim mydata As New DataSet
        Dim myAdapter As New MySqlDataAdapter(MyQuery, Conn)
        'myCommand.Connection = Conn
        'myCommand.CommandText = MyQuery

        'myAdapter.SelectCommand = myCommand
        myAdapter.Fill(mydata)
        'myData2 = myCommand.ExecuteReader()

        Return mydata
    End Function
    Public Function SetData(ByVal MyQuery As String) As Boolean
        Dim myCommand As New MySqlCommand(MyQuery)
        Dim SetDataSuccess As Boolean = False
        myCommand.Connection = Conn
        Try
            'Conn.Open()
            myCommand.ExecuteNonQuery()
            'myCommand.Connection.Close()
            SetDataSuccess = True
        Catch myError As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myError.Message)
            SetDataSuccess = False
        End Try
        Return SetDataSuccess
    End Function

    Public Function command_sql(ByVal comand_data As MySqlCommand) As Boolean
        Try
            comand_data.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error Connecting to Database: " & ex.Message)
            command_sql = False
        End Try
    End Function

    'contoh :
    'FileStream fs = new (lokasi,tipe read)
    'fileSize = fs.length
    'byte[] rawData = new byte [fileSize]
    'fs.read(rawData,0,fileSize)
    'Dim sql As String
    'dim cmd as MySqlCommand
    'SQL = "INSERT INTO `file`.`blob` (`id_blob`, `name_file`, `size`, `content`) VALUES(NULL, ?name_file, ?size, ?content)";

    '               cmd.CommandText = SQL;
    '               cmd.Parameters.AddWithValue("?name_file", openFileDialog.FileName);
    '               cmd.Parameters.AddWithValue("?size", fileSize);
    '               cmd.Parameters.AddWithValue("?content", rawData);
    'command_sql(cmd)



End Class
