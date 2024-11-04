Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_ManageMovie
    Private Sub frm_ManageMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbl_moviedata` SET `moviename`=@moviename,`price`=@price WHERE `movieid`=@movieid", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@moviename", txt_MovieName.Text)
            cmd.Parameters.AddWithValue("@price", txt_Price.Text)
            cmd.Parameters.AddWithValue("@movieid", "1001")
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Movie Update Success!", vbInformation)
            Else
                MsgBox("Movie Update Failed!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_MovieName.Clear()
        txt_Price.Clear()
        Form1.GetMovieNameandPrice()
    End Sub
End Class