Imports MySql.Data.MySqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Security.Cryptography.SHA256
Imports System.Text


Public Class SignupForm
    'Declare Database connection
    '===========================
    Dim ConnStr As String = "server=localhost;user id=root;password=root;database=kemriflu"


    'Hashed password function
    '=========================
    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO users (firstname, lastname, username, email, password_hash, created_at, activity) VALUES (@firstname, @lastname, @username, @email, @password, NOW(), 0)"

        Using conn As New MySqlConnection(ConnStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@password", HashPassword(txtSignupPassword.Text))

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Signup Successful! Please wait while being redirected to login...")

                Dim loginForm As New LoginForm()
                loginForm.SetUsername(txtUsername.Text) 'Pass username
                loginForm.Show()
                Me.Close()

            End Using
        End Using

    End Sub
End Class