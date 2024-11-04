Imports MySql.Data.MySqlClient
Imports System.IO
Module dbconnection

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer
    Public result As Boolean

    Public Function dbconn() As Boolean
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection()
            End If
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost; user=admin; password=admin; port=3306; database=ticket_db"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server not connected!" & vbCrLf & ex.Message, vbExclamation)
        End Try
        Return result
    End Function


End Module
