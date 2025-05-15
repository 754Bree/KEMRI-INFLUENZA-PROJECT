Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=root;database=kemriflu")


    'Temporary strorage for tab data before full submission
    Dim tab1Data As New Dictionary(Of String, Object)
    Dim tab2Data As New Dictionary(Of String, Object)
    Dim tab3Data As New Dictionary(Of String, Object)
    Dim tab4Data As New Dictionary(Of String, Object)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxes()
    End Sub
    Public Property CurrentUserId As Integer

    Private isLoggedIn As Boolean = False


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
        'Validate and save data on the tab
        Dim isValid As Boolean = False


        'Save data based on the currently selected tab
        Select Case TabControl1.SelectedIndex
            Case 0
                isValid = ValidateTab1()
                If isValid Then SaveTab1Data()
            Case 1
                isValid = ValidateTab2()
                If isValid Then SaveTab2Data()
            Case 2
                isValid = ValidateTab3
                If isValid Then SaveTab3Data()
            Case 3
                isValid = ValidateTab4
                If isValid Then SaveTab4Data()
        End Select
        If isValid Then
            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            Else

                MessageBox.Show("You are already on the last page.")

            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim isValid As Boolean = False

        'Save data based on the currently selected tab
        Select Case TabControl1.SelectedIndex
            Case 0
                isValid = ValidateTab1()
                If isValid Then SaveTab1Data()
            Case 1
                isValid = ValidateTab2()
                If isValid Then SaveTab2Data()
            Case 2
                isValid = ValidateTab3
                If isValid Then SaveTab3Data()
            Case 3
                isValid = ValidateTab4
                If isValid Then SaveTab4Data()
        End Select
        If isValid Then
            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            Else

                MessageBox.Show("You are already on the last page.")

            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim isValid As Boolean = False

        'Save data based on the currently selected tab
        Select Case TabControl1.SelectedIndex
            Case 0
                isValid = ValidateTab1()
                If isValid Then SaveTab1Data()
            Case 1
                isValid = ValidateTab2()
                If isValid Then SaveTab2Data()
            Case 2
                isValid = ValidateTab3
                If isValid Then SaveTab3Data()
            Case 3
                isValid = ValidateTab4
                If isValid Then SaveTab4Data()
        End Select
        If isValid Then
            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            Else

                MessageBox.Show("You are already on the last page.")

            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim isValid As Boolean = False

        'Save data based on the currently selected tab
        Select Case TabControl1.SelectedIndex
            Case 0
                isValid = ValidateTab1()
                If isValid Then SaveTab1Data()
            Case 1
                isValid = ValidateTab2()
                If isValid Then SaveTab2Data()
            Case 2
                isValid = ValidateTab3
                If isValid Then SaveTab3Data()
            Case 3
                isValid = ValidateTab4
                If isValid Then SaveTab4Data()
        End Select
        If isValid Then
            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            Else

                MessageBox.Show("You are already on the last page.")

            End If
        End If

    End Sub
    '##################################################################################333


    '========================
    'Validations for tabpages
    '------------------------
    Private Function ValidateTab1() As Boolean
        If String.IsNullOrWhiteSpace(txtAge.Text) Then
            MessageBox.Show("Age is required.")
            txtAge.Focus()
            Return False
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtAge.Text, age) Then
            MessageBox.Show("Enter a valid age.")
            txtAge.Focus()
            Return False
        End If

        If age < 15 OrElse age > 19 Then
            MessageBox.Show("Allowed Range : 15 to 19")
            txtAge.Focus()
            Return False
        End If

        If cmbReligion.SelectedIndex = -1 Then
            MessageBox.Show("Select Religion...")
            cmbReligion.Focus()
            Return False
        End If

        If cmbLivingWith.SelectedIndex = -1 Then
            MessageBox.Show("MUST Select one...")
            cmbLivingWith.Focus()
            Return False
        End If

        If cmbSchoolingType.SelectedIndex = -1 Then
            MessageBox.Show("MUST select one...")
            cmbSchoolingType.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtFamilyPresent.Text) Then
            MessageBox.Show("Value required")
            txtFamilyPresent.Focus()
            Return False
        End If

        Dim presentmembers As Integer
        If Not Integer.TryParse(txtFamilyPresent.Text, presentmembers) Then
            MessageBox.Show("Values allowed : 1 - 9")
            txtFamilyPresent.Focus()
            Return False
        End If
        If presentmembers < 1 OrElse presentmembers > 9 Then
            MessageBox.Show("Values : 1 - 9 ")
            txtFamilyPresent.Focus()
            Return False
        End If
    End Function

    '***********************
    'Validate Tab2
    '--------------
    Private Function ValidateTab2() As Boolean
        If cmbOccupation.SelectedIndex = -1 Then
            MessageBox.Show("Please select guardian occupation.")
            cmbOccupation.Focus()
            Return False
        End If

        If cmbEducation.SelectedIndex = -1 Then
            MessageBox.Show("Please select guardian education.")
            cmbEducation.Focus()
            Return False
        End If

    End Function

    '*************************
    'Validate Tab3
    '________________--
    Private Function ValidateTab3() As Boolean
        'Validate parent comboboxes
        If cmbSiblingsPresent.SelectedIndex = -1 Then
            MessageBox.Show("Select an option!")
            cmbSiblingsPresent.Focus()
            Return False
        End If

        If cmbSiblingsPresent.SelectedItem.ToString().ToLower() = "Yes" Then
            'Validate child
            If cmbSiblingRelationship.SelectedIndex = -1 Then
                MessageBox.Show("Select an option!")
                cmbSiblingRelationship.Focus()
                Return False
            End If
        End If

        If cmbPocketMoney.SelectedIndex = -1 Then
            MessageBox.Show("Select an option!")
            cmbPocketMoney.Focus()
            Return False
        End If

        If cmbPocketMoney.SelectedItem.ToString().ToLower() = "Yes" Then
            'Validate child
            If cmbPocketMoneyAdequacy.SelectedIndex = -1 Then
                MessageBox.Show("Select an option!")
                cmbPocketMoneyAdequacy.Focus()
                Return False
            End If
        End If

        If cmbVisitingDayAttendance.SelectedIndex = -1 Then
            MessageBox.Show("Select an option!")
            cmbVisitingDayAttendance.Focus()
            Return False
        End If

        If cmbVisitingDayAttendance.SelectedItem.ToString().ToLower() = "No" Then
            'Validate child
            If cmbOtherVisitingSources.SelectedIndex = -1 Then
                MessageBox.Show("Select an option!")
                cmbOtherVisitingSources.Focus()
                Return False
            End If
        End If
        If cmbOtherFinancialSources.SelectedIndex = -1 Then
            MessageBox.Show("Select an option!")
            cmbOtherFinancialSources.Focus()
            Return False
        End If
    End Function

    '=================
    'Validate Tab 4
    Private Function ValidateTab4() As Boolean
        'Validate Parent comboBoxes
    End Function



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

    '===================================
    'Save data functions
    '===================
    Private Sub SaveTab1Data()
        tab1Data("Age") = txtAge.ToString()
        tab1Data("Religion") = cmbReligion.SelectedItem?.ToString()
        tab1Data("Livingwith") = cmbLivingWith.SelectedItem?.ToString
        tab1Data("familymemberspresent") = txtFamilyPresent.ToString()
        tab1Data("typeofschooling") = cmbSchoolingType.SelectedItem?.ToString()
    End Sub
    Private Sub SaveTab2Data()
        tab2Data("GuardianOccupation") = cmbOccupation.SelectedItem?.ToString()
        tab2Data("unlistedguardianoccupation") = txtNotListed.ToString()
        tab2Data("GuardianEducation") = cmbEducation.SelectedItem?.ToString()
        tab2Data("notlisted") = chkListed.Checked
    End Sub

    Private Sub SaveTab3Data()
        tab3Data("siblingspresent") = cmbSiblingsPresent.SelectedItem?.ToString()
        tab3Data("siblingrelationships") = cmbSiblingRelationship.SelectedItem?.ToString()
        tab3Data("pocketmoneyavailable") = cmbPocketMoney.SelectedItem?.ToString()
        tab3Data("pocketmoneyadequacy") = cmbPocketMoneyAdequacy.SelectedItem?.ToString()
        tab3Data("otherfinancialsupportsource") = cmbOtherFinancialSources.SelectedItem?.ToString()
        tab3Data("guardianvisiting") = cmbVisitingDayAttendance.SelectedItem?.ToString()
        tab3Data("othervisitingsources") = cmbOtherVisitingSources.SelectedItem?.ToString()
    End Sub

    Private Sub SaveTab4Data()
        tab4Data("reproductivehealthaccess") = cmbReproductiveHealthAccess.SelectedItem?.ToString()
        tab4Data("educators1") = chkTeachers.ToString()
        tab4Data("educators2") = chkParents.ToString()
        tab4Data("educators3") = chkHealthWorker.ToString()
        tab4Data("educators4") = chkFriends.ToString()
        tab4Data("educators5") = chkMedia.ToString()
        tab4Data("topic1") = chkSexuality.ToString()
        tab4Data("topic2") = chkAbstinence.ToString()
        tab4Data("topic3") = chkCondoms.ToString()
        tab4Data("topic4") = chkSti.ToString()
        tab4Data("topic5") = chkRelationships.ToString()
        tab4Data("reproductivehealthadequacy") = cmbInfoAdequate.ToString()
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

    '==========================
    'Form Validations
    '================

    'I.D.D.F
    '=======
    Private Sub txtAge_Leave(sender As Object, e As EventArgs) Handles txtAge.Leave
        'Empty Textbox
        If txtAge.Text <> "" Then
            Dim age As Integer

            'Check if input is a valid number
            If Integer.TryParse(txtAge.Text, age) Then
                'Validate age range
                If age < 15 OrElse age > 19 Then
                    MessageBox.Show("Allowed Range : 15 to 19!")
                    txtAge.Clear()
                    txtAge.Focus()

                End If
            Else
                MessageBox.Show("Enter valid age.")
                txtAge.Clear()
                txtAge.Focus()
            End If
        End If
    End Sub


    '==============================
    'Loading ComboBoxes from String Collection
    '==========================================

    Private Sub LoadComboBoxes()
        'Living With Guardian
        Dim livingwith As New Specialized.StringCollection From {
            "Mother and Father", "Father only", "Mother only", "Relative"
        }
        cmbLivingWith.Items.Clear()
        For Each item As String In livingwith
            cmbLivingWith.Items.Add(item)
        Next

        'Guardian occupation
        Dim occupations As New Specialized.StringCollection From {
            "Farm Worker", "Self Employed", "Employed by someone", "professional"
        }
        cmbOccupation.Items.Clear()
        For Each item As String In occupations
            cmbOccupation.Items.Add(item)
        Next

        'Guardian Education
        Dim education As New Specialized.StringCollection From {
            "None", "Primary", "Secondary", "Tertiary"
        }
        cmbEducation.Items.Clear()
        For Each item As String In education
            cmbEducation.Items.Add(item)
        Next


        'Guardian Religion
        Dim religion As New Specialized.StringCollection From {
        "catholic", "protestant", "muslim", "sda", "none"
        }
        cmbReligion.Items.Clear()
        For Each item As String In religion
            cmbReligion.Items.Add(item)
        Next

        'Other source of Financial support
        Dim otherfinancialsource As New Specialized.StringCollection From {
        "Relatives", "Boyfriend", "Grand Parents", "Other friends"
        }
        cmbOtherFinancialSources.Items.Clear()
        For Each item As String In otherfinancialsource
            cmbOtherFinancialSources.Items.Add(item)

        Next

        'Schooling type
        Dim schooltype As New Specialized.StringCollection From {
            "Day School", "Boarding School"
        }
        cmbSchoolingType.Items.Clear()
        For Each item As String In religion
            cmbSchoolingType.Items.Add(item)
        Next


        'Other Visiting Sources
        Dim othervisitingsources As New Specialized.StringCollection From {
        "boyfriend", "relatives", "brothers/sisters", "casual male friend", "none"
        }
        cmbOtherVisitingSources.Items.Clear()
        For Each item As String In othervisitingsources
            cmbOtherVisitingSources.Items.Add(item)
        Next

        'Yes /No Questions
        Dim siblingspresent As New Specialized.StringCollection From {
        "Yes", "No"
        }
        cmbSiblingsPresent.Items.Clear()
        For Each item As String In siblingspresent
            cmbSiblingsPresent.Items.Add(item)

        Next


        Dim siblingrelationships As New Specialized.StringCollection From {
       "Yes", "No"
       }
        cmbSiblingRelationship.Items.Clear()
        For Each item As String In siblingrelationships
            cmbSiblingRelationship.Items.Add(item)

        Next

        Dim pocketmoneyavailable As New Specialized.StringCollection From {
       "Yes", "No"
       }
        cmbPocketMoney.Items.Clear()
        For Each item As String In pocketmoneyavailable
            cmbPocketMoney.Items.Add(item)

        Next

        Dim pocketmoneyadequate As New Specialized.StringCollection From {
       "Yes", "No"
       }
        cmbPocketMoneyAdequacy.Items.Clear()
        For Each item As String In pocketmoneyadequate
            cmbPocketMoneyAdequacy.Items.Add(item)

        Next

        Dim guardianvisiting As New Specialized.StringCollection From {
       "Yes", "No"
       }
        cmbOtherVisitingSources.Items.Clear()
        For Each item As String In guardianvisiting
            cmbOtherVisitingSources.Items.Add(item)

        Next
    End Sub


End Class
