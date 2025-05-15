Public Class Form1

    Public Property CurrentUserId As Integer

    Private isLoggedIn As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '======================================================================================
    'Navigation Buttons
    '======================
    'Proceed and Begin Buttons
    '==========================

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        Else
            MessageBox.Show("You are on the last page.")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        Else

            MessageBox.Show("You are already on the last page.")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        Else
            MessageBox.Show("You are already on the last page")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        Else
            MessageBox.Show("You are already on the last page")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        Else
            MessageBox.Show("You are already on the last page")
        End If
    End Sub

    '========================
    'Back buttons
    '========================
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        Else
            MessageBox.Show("You are already on the first page")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        Else
            MessageBox.Show("You are on the first page")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        Else
            MessageBox.Show("You are already on the first page")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        Else
            MessageBox.Show("You are already on the first page")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        Else
            MessageBox.Show("You are already on the first page")
        End If
    End Sub

    '====================================================================================================
    'Authentication buttons on homepage
    '=======================================

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnLoginHome.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnSignupHome_Click(sender As Object, e As EventArgs) Handles btnSignupHome.Click
        Dim signupForm As New SignupForm()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub
End Class
