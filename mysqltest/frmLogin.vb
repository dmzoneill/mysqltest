Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim conn As MySqlConnection

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" + txtserver.Text + ";" + "user id=" + txtUsername.Text + ";" + "password=" + txtPassword.Text + ";" + "database=literotica"
        Try
            conn.Open()
            MessageBox.Show("Connection Opened Successfully")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " + myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
End Class
