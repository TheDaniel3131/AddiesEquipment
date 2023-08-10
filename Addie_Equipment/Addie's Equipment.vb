Imports System.Globalization

Public Class AddiesEquipment
    'Public price As Single
    'Public subtotal As Single
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'show the message before going back to the filling form
        Dim revert As DialogResult

        revert = MessageBox.Show("Are you sure you want to revert back?", "Return to the filling form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (revert = DialogResult.Yes) Then
            FillingForm.Show()
            Me.Close()
        Else
            'focus on back button
            btnBack.Focus()
        End If
    End Sub

    Private Sub AddiesEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'A welcome notification to every client once they are signed up!
        NotifyIcon1.ShowBalloonTip(3500, "Signed Up", "Welcome To Addie's Equipment!", ToolTipIcon.Info)

        'adding the type of equipments
        With cboEquipmentType.Items
            .Add("Lawn Mower – Rotary")
            .Add("Lawn Mower – Ride On")
            .Add("Lawn Mower – Handheld")
            .Add("Mobile Garden Sprinkler (small)")
            .Add("Mobile Garden Sprinkler (large)")
            .Add("Garden Spray – 5L")
            .Add("Garden Spray – 10L")
            .Add("Outdoor High Pressure Pump")
        End With

        'lock the comboboxs so it would not edited
        cboEquipmentType.SelectedIndex = -1
        cboEquipmentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboRentalDays.SelectedIndex = -1
        cboRentalDays.DropDownStyle = ComboBoxStyle.DropDownList

        'set the US currency to MY currency
        Dim cult As CultureInfo = New CultureInfo("en-MY")
        Threading.Thread.CurrentThread.CurrentCulture = cult
    End Sub

    Private Sub cboRentalDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRentalDays.SelectedIndexChanged

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'error message on add if no selecting options for the comboboxes
        If (cboEquipmentType.Text = "") Then
            MessageBox.Show("Please Select Your Equipment Type!", "Missing selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEquipmentType.Focus()
            Return
        ElseIf (cboRentalDays.Text = "") Then
            MessageBox.Show("Please Select Your Rental Days!", "Missing selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRentalDays.Focus()
            btnAdd.Focus()
            Return
        End If

        Dim rentaldays As Integer
        Dim price As Single

        'Const discount As Single = 0.15
        'Dim rentaldays As Integer

        'display total value
        rentaldays = Integer.Parse(cboRentalDays.Text)

        'show daily rate or days rate on subtotal
        If (cboRentalDays.Text = 1) Then
            price = lblDailyRate.Text
        ElseIf (cboRentalDays.Text >= 2 And cboRentalDays.Text <= 14) Then
            price = lblDaysRate.Text
        End If

        'list the items on the receipts
        lstEquipmentType.Items.Add(cboEquipmentType.Text)
        lstRentalDays.Items.Add(cboRentalDays.Text)

        ''list the daily rate or days rate
        '1 Rental Day = daily rate, More than 1 = days rate
        If (cboRentalDays.Text = 1) Then
            lstRates.Items.Add(lblDailyRate.Text)


        ElseIf (cboRentalDays.Text > 1 And cboRentalDays.Text <= 14) Then
            lstRates.Items.Add(lblDaysRate.Text)

        End If

        'calculate the subtotal
        subtotal = rentaldays * price

        'calculate the total
        total = total + subtotal

        'calculate the variables
        'calculate the discount 
        If (lstEquipmentType.Items.Count = 1) Then
            discount = 0.00
        ElseIf (lstEquipmentType.Items.Count > 2) Then
            discount = total * 0.15
        End If

        'If (lstEquipmentType.Items.Count > 2) Then discount = 0.15
        'discount = total * discount

        'calculate the nettotal
        nettotal = total - discount

        lblDiscount.Text = discount.ToString("c")
        lblTotal.Text = total.ToString("c")
        lblNetTotal.Text = nettotal.ToString("c")
        lstSubtotal.Items.Add(subtotal.ToString("c"))
        'lstSubtotal.Items.Add(subtotal.ToString("c"))

        'send the listbox values to other listbox in finalreceipt form
        FinalReceipt.lstViewReceipt.Items.Add("Equipment Type" & Space(25) & vbTab & "Rental Days" & vbTab & "Daily Rate/Days Rate" & vbTab & "Subtotal")

        'add a line
        FinalReceipt.lstViewReceipt.Items.Add("--------------------------------------------" & Space(15) & vbTab & "--------------------" & vbTab & "-----------------------------------" & vbTab & "----------------")

        'selected item lines
        FinalReceipt.lstViewReceipt.Items.Add(Me.cboEquipmentType.SelectedItem & Space(25) & Me.cboRentalDays.SelectedItem & vbTab & Space(25) & price.ToString("c") & vbTab & Space(16) & subtotal.ToString("c") & Space(5))

        'add a space line
        FinalReceipt.lstViewReceipt.Items.Add(vbNewLine)

        'FinalReceipt.lstViewReceipt.Items.Add(Me.cboEquipmentType.SelectedItem & Space(25) & Me.cboRentalDays.SelectedItem & Space(25) & price & Space(35) & subtotal & Space(15))
        'FinalReceipt.lstViewReceipt.Items.Add(Me.cboRentalDays.SelectedItem)
        'FinalReceipt.lstViewReceipt.Items.Add(Me.lstRates.SelectedItem)
        'FinalReceipt.lstViewReceipt.Items.Add(Me.lstSubtotal.SelectedItem)


        'set the US currency to MY currency
        Dim cult As CultureInfo = New CultureInfo("en-MY")
        Threading.Thread.CurrentThread.CurrentCulture = cult
    End Sub

    Private Sub cboEquipmentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEquipmentType.SelectedIndexChanged

        'set the variables
        Dim dailyrate As Single
        Dim daysrate As Single

        'Dim dailyrate As Single
        'Dim daysrate As Single

        'set dailyrate + daysrate on the equipments
        If (cboEquipmentType.Text = "Lawn Mower – Rotary") Then
            dailyrate = "50.0"
            daysrate = "38.0"
        ElseIf (cboEquipmentType.Text = "Lawn Mower – Ride On") Then
            dailyrate = "80.0"
            daysrate = "60.0"
        ElseIf (cboEquipmentType.Text = "Lawn Mower – Handheld") Then
            dailyrate = "35.0"
            daysrate = "26.0"
        ElseIf (cboEquipmentType.Text = "Mobile Garden Sprinkler (small)") Then
            dailyrate = "100.0"
            daysrate = "75.0"
        ElseIf (cboEquipmentType.Text = "Mobile Garden Sprinkler (large)") Then
            dailyrate = "150.0"
            daysrate = "113.0"
        ElseIf (cboEquipmentType.Text = "Garden Spray – 5L") Then
            dailyrate = "30.0"
            daysrate = "25.0"
        ElseIf (cboEquipmentType.Text = "Garden Spray – 10L") Then
            dailyrate = "40.0"
            daysrate = "32.0"
        ElseIf (cboEquipmentType.Text = "Outdoor High Pressure Pump") Then
            dailyrate = "50.0"
            daysrate = "38.0"
        End If

        'display the default currency to MY currency
        lblDailyRate.Text = dailyrate.ToString("c")
        lblDaysRate.Text = daysrate.ToString("c")

        'set the US currency to MY currency
        Dim cult As CultureInfo = New CultureInfo("en-MY")
        Threading.Thread.CurrentThread.CurrentCulture = cult

    End Sub

    Dim total, discount, nettotal, subtotal As Single

    Private Sub lstRentalDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRentalDays.SelectedIndexChanged
        'if select the lstRentalDays, then the rest will be highlighted
        Dim index As Integer = lstRentalDays.SelectedIndex

        lstEquipmentType.SelectedIndex = index
        lstRates.SelectedIndex = index
        lstSubtotal.SelectedIndex = index
    End Sub

    Private Sub lstRates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedIndexChanged
        'if select the lstRates, then the rest will be highlighted
        Dim index As Integer = lstRates.SelectedIndex

        lstEquipmentType.SelectedIndex = index
        lstRentalDays.SelectedIndex = index
        lstSubtotal.SelectedIndex = index
    End Sub

    Private Sub lstSubtotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubtotal.SelectedIndexChanged
        'if select the lstSubtotal, then the rest will be highlighted
        Dim index As Integer = lstSubtotal.SelectedIndex

        lstRentalDays.SelectedIndex = index
        lstRentalDays.SelectedIndex = index
        lstRates.SelectedIndex = index
    End Sub

    Private Sub lstEquipmentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEquipmentType.SelectedIndexChanged
        'highlight the selection for the row
        'if select the lstEquipment, then the rest will be highlighted
        Dim index As Integer = lstEquipmentType.SelectedIndex

        lstRentalDays.SelectedIndex = index
        lstRates.SelectedIndex = index
        lstSubtotal.SelectedIndex = index
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'payment popup window
        Dim payment As DialogResult
        Dim incomplete As DialogResult

        If lblNetTotal.Text = "" Then
            incomplete = MessageBox.Show("Please fill in the order before proceed.", "Missing Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Else
            payment = MessageBox.Show("Are you sure you want to pay the orders?", "Confirm Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If payment = DialogResult.OK Then
                payment = MessageBox.Show("Congratulations, you have successfully ordered the equipments!", "Payment Completion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FinalReceipt.StartPosition = FormStartPosition.CenterScreen
                FinalReceipt.Show()

                Me.Close() 'close the current window of addie's equipment

            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'set the combo box default option
        cboRentalDays.SelectedIndex = -1
        cboEquipmentType.SelectedIndex = -1

        'reset the filling
        lstEquipmentType.Items.Clear()
        lstRentalDays.Items.Clear()
        lstRates.Items.Clear()
        lstSubtotal.Items.Clear()

        lblDailyRate.ResetText()
        lblDaysRate.ResetText()
        lblDiscount.ResetText()
        lblTotal.ResetText()
        lblNetTotal.ResetText()

        lblTotal.Text = ""
        lblDiscount.Text = ""
        lblNetTotal.Text = ""
        discount = 0.0
        total = 0.0
        nettotal = 0.0
    End Sub
End Class