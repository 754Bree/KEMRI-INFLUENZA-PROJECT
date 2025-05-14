Imports MySql.Data.MySqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Security.Cryptography.SHA256
Imports System.Text
Imports System.Windows.Markup


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
        ' Create Employee Serial Number
        Dim newEmployeeSN As String = ""
        Dim prefix As String = "kflu-"
        Dim queryMaxSn As String = "SELECT employee_sn FROM users ORDER BY user_id DESC LIMIT 1"

        Using Conn As New MySqlConnection(ConnStr)
            Conn.Open()

            Using cmdMax As New MySqlCommand(queryMaxSn, Conn)
                Dim lastSN As Object = cmdMax.ExecuteScalar()

                If lastSN IsNot Nothing AndAlso Not String.IsNullOrEmpty(lastSN.ToString()) Then
                    Dim lastSNStr As String = lastSN.ToString()
                    If lastSNStr.StartsWith(prefix) Then
                        Dim numberPart As String = lastSNStr.Substring(prefix.Length)
                        Dim lastNumber As Integer
                        If Integer.TryParse(numberPart, lastNumber) Then
                            newEmployeeSN = prefix & (lastNumber + 1).ToString("D4")
                        Else
                            newEmployeeSN = prefix & "0001" ' Fallback if parsing fails
                        End If
                    Else
                        newEmployeeSN = prefix & "0001" ' Fallback if prefix is missing
                    End If
                Else
                    newEmployeeSN = prefix & "0001" ' First record
                End If
            End Using

            ' Insert new user with employee_sn
            Dim insertQuery As String = "INSERT INTO users (employee_sn, firstname, lastname, username, email, password_hash, created_at, activity) " &
                                    "VALUES (@employee_sn, @firstname, @lastname, @username, @email, @password, NOW(), 0)"

            Using cmd As New MySqlCommand(insertQuery, Conn)
                cmd.Parameters.AddWithValue("@employee_sn", newEmployeeSN)
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@password", HashPassword(txtSignupPassword.Text))

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Signup Successful! Please wait while being redirected to login...")

            Dim loginForm As New LoginForm()
            loginForm.SetUsername(txtUsername.Text) ' Pass username to login
            loginForm.Show()
            Me.Close()
        End Using
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class