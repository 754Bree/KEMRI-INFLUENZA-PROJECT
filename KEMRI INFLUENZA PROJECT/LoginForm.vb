Imports MySql.Data.MySqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Security.Cryptography.SHA256
Imports System.Text

Public Class LoginForm
    Dim connStr As String = "server=localhost;user id=root;password=root;database=kemriflu"

    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()

        End Using
    End Function

    Public Sub SetUsername(username As String)
        txtUsername.Text = username
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query As String = "SELECT * FROM users WHERE username = @username AND password_hash = @password"
        Using conn As New MySqlConnection(connStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text))

                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim userID As Integer = reader("user_id")
                    reader.Close()

                    'Update activity column
                    '=======================
                    Dim updateActivityQuery As String = "UPDATE users SET activity = 1 WHERE user_id = @user_id"
                    Using updateCmd As New MySqlCommand(updateActivityQuery, conn)

                        updateCmd.Parameters.AddWithValue("@user_id", userID)
                        updateCmd.ExecuteNonQuery()

                    End Using
                    MessageBox.Show("Login Successful!")
                    '-==============================================
                    'Redirection code to individual demographic form
                    '===============================================
                    Dim main As New Form1()
                    main.Show()
                    main.TabControl1.SelectedTab = main.TabPage2
                    Me.Close()
                Else
                    MessageBox.Show("Invalid credentials!")

                End If
            End Using

        End Using

    End Sub


End Class