Public Class FinalReceipt
    'Public priceFR As String
    'Public subtotalFR As String

    Private Sub FinalReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''string variables
        'priceFR = AddiesEquipment.price
        'subtotalFR = AddiesEquipment.subtotal

        'Notifying the clients that the view receipt is here
        NotifyIcon1.ShowBalloonTip(3000, "View Receipt", "You can view and print the receipt!", ToolTipIcon.Info)

        'display all the information that the clients input
        lblFullName.Text = FillingForm.txtFullName.Text
        lblAge.Text = FillingForm.txtAge.Text
        lblAddress.Text = FillingForm.txtAddress.Text
        lblContact.Text = FillingForm.mskPhoneNumbers.Text
        lblTotalFR.Text = AddiesEquipment.lblTotal.Text
        lblDiscountFR.Text = AddiesEquipment.lblDiscount.Text
        lblNetTotalFR.Text = AddiesEquipment.lblNetTotal.Text

        ''send the listbox values to other listbox in finalreceipt form
        'lstViewReceipt.Items.Add("Equipment Type" & Space(25) & vbTab & "Rental Days" & vbTab & "Daily Rate/Days Rate" & vbTab & "Subtotal")

        ''add a line
        'lstViewReceipt.Items.Add("--------------------------------------------" & Space(15) & vbTab & "--------------------" & vbTab & "-----------------------------------" & vbTab & "----------------")

        ''selected item lines
        'lstViewReceipt.Items.Add(AddiesEquipment.cboEquipmentType.SelectedItem & Space(25) & AddiesEquipment.cboRentalDays.SelectedItem & vbTab & Space(25) & priceFR & vbTab & Space(16) & subtotalFR & Space(5))

        ''add a space line
        'lstViewReceipt.Items.Add(vbNewLine)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the application
        Dim close As MsgBoxResult
        Dim thankyou1 As MsgBoxResult

        close = MessageBox.Show("Are you sure you want to close the receipt?", "Closing Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        thankyou1 = MessageBox.Show("Thank you for renting our equipments!", "Visit Us Again", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If close = MsgBoxResult.Yes Then
            thankyou1 = MsgBoxResult.Yes
            Application.Exit()
        End If
    End Sub

    Private Sub lstViewReceipt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewReceipt.SelectedIndexChanged

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        ''print preview 
        'Me.Width = Me.Width - 125
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        'PrintForm1.Print()
        'Me.Width = Me.Width + 125

        'Me.Show()

        'are you sure you want to print?
        Dim print As MsgBoxResult
        Dim thankyou2 As MsgBoxResult

        print = MessageBox.Show("Are you sure you want to print the receipt?", "Confirm Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        thankyou2 = MessageBox.Show("Thank you for renting our equipments!", "Visit Us Again", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If print = MsgBoxResult.Yes Then
            thankyou2 = MsgBoxResult.Yes
            Application.Exit()
        Else
            print = MsgBoxResult.No
            thankyou2 = MsgBoxResult.No
            Me.Show()
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        'Letting the users know they click this tip
        MessageBox.Show("You have clicked this tip!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'click the website link
        Process.Start("http://addiesequipment.com/support")
    End Sub
End Class