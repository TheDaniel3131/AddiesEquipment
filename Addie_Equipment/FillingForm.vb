Public Class FillingForm
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullName.KeyPress
        'error message display only letters available
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = False 'accept the key
        Else
            e.Handled = True 'reject the key
            MessageBox.Show("Only Letters Are Allowed For Full Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        'error message display only numbers available
        If (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = False 'accept the key
        Else
            e.Handled = True 'reject the key
            MessageBox.Show("Only Numbers Are Allowed For Ages", "Invalid Input", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHomePhone.CheckedChanged
        mskPhoneNumbers.Mask = "(00) 0000 0000"
        'ComboBox1.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMobilePhone.CheckedChanged
        mskPhoneNumbers.Mask = "(000) 000 0000"
        'ComboBox1.Visible = True
    End Sub

    Private Sub FillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Notifying the clients that the filling form is clear
        NotifyIcon1.ShowBalloonTip(1500, "Sign Up", "The Filling Form Is Required.", ToolTipIcon.Info)

        Dim full = txtFullName.Text
        Dim age = txtAge.Text
        Dim add = txtAddress.Text
        Dim con = mskPhoneNumbers.Text

        'ComboBox1.Visible = False
        'ComboBox1.SelectedIndex = 2
        'ComboBox1.Visible = False

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'minimum age requirement (txtAge.Text)
        Dim age As Integer

        age = Integer.Parse(txtAge.Text)

        If (age < 18) Then
            MessageBox.Show("Age must be 18 years old and above!", "Age Requirement", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
            Return
        End If

        'error message display if there is no input
        If (txtFullName.Text = "" Or txtAge.Text = "" Or mskPhoneNumbers.Text = "" Or rdbHomePhone.Text = "" Or rdbMobilePhone.Text = "" Or txtAddress.Text = "") Then
            MessageBox.Show("Please Complete Your Form!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddiesEquipment.StartPosition = FormStartPosition.CenterScreen
            AddiesEquipment.Show()
            Me.Hide() 'hide the submission form
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim close As MsgBoxResult

        close = MessageBox.Show("Do you want to close the application?", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If close = MsgBoxResult.Yes Then Application.Exit()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Notifying the clients that the filling form is clear
        NotifyIcon1.ShowBalloonTip(3000, "Reset Form", "The Filling Form Is Now Clear!", ToolTipIcon.Info)

        'clear all the inputs
        txtFullName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        rdbHomePhone.Checked = False
        rdbMobilePhone.Checked = False
        mskPhoneNumbers.Clear()

        'back to default setting (set cursor to full name's textbox)
        txtFullName.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSite.LinkClicked
        'click the website link
        Process.Start("http://addiesequipment.com/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'show the message before going back to the mainpage
        Dim returnmain As DialogResult

        returnmain = MessageBox.Show("Are you sure you want to revert back?", "Return to the filling form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (returnmain = DialogResult.Yes) Then
            Dashboard.Show()
            Me.Close()
        Else
            'focus on back button
            btnReturn.Focus()
        End If
    End Sub
End Class
