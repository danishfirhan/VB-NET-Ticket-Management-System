Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn() ' Ensure your database connection function is correctly implemented
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            conn.Open()
            ' Query to check if the username and password exist in the tbl_users table
            cmd = New MySqlCommand("SELECT * FROM `tbl_admin` WHERE `username`=@username AND `password`=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text)
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MsgBox("Login Successful!", vbInformation)
                Me.Hide() ' Hide the login form
                frmSplashScreen.Show() ' Show the splash screen form after a successful login
            Else
                MsgBox("Login Failed! Please enter the correct credentials.", vbCritical)
                usernameTextBox.Clear()
                passwordTextBox.Clear()
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
