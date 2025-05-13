<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        txtLastname = New TextBox()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtSignupPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        txtFirstname = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(136, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 32)
        Label1.TabIndex = 0
        Label1.Text = "Authentication"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(185, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 21)
        Label2.TabIndex = 1
        Label2.Text = "Signup"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(91, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 2
        Label3.Text = "Firstname"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(89, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 3
        Label4.Text = "Lastname"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(89, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 4
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(89, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 5
        Label6.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(91, 334)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 6
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(89, 387)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 15)
        Label8.TabIndex = 7
        Label8.Text = "Confirm Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(185, 431)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 33)
        Button1.TabIndex = 8
        Button1.Text = "Signup"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(215, 205)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(174, 23)
        txtLastname.TabIndex = 9
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(217, 248)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(172, 23)
        txtUsername.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(215, 290)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(174, 23)
        txtEmail.TabIndex = 11
        ' 
        ' txtSignupPassword
        ' 
        txtSignupPassword.Location = New Point(217, 331)
        txtSignupPassword.Name = "txtSignupPassword"
        txtSignupPassword.Size = New Size(172, 23)
        txtSignupPassword.TabIndex = 12
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(217, 379)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(172, 23)
        txtConfirmPassword.TabIndex = 13
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(215, 163)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(174, 23)
        txtFirstname.TabIndex = 14
        ' 
        ' SignupForm
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(489, 509)
        Controls.Add(txtFirstname)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtSignupPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(txtLastname)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SignupForm"
        Text = "Signup-:"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSignupPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtFirstname As TextBox
End Class
