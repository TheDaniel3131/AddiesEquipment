Public Class Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim quit As MsgBoxResult

        quit = MessageBox.Show("Do you want to close the application?", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If quit = MsgBoxResult.Yes Then Application.Exit()

    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Me.Hide()
        FillingForm.StartPosition = FormStartPosition.CenterScreen
        FillingForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSup.Click
        'click the website link
        Process.Start("http://addiesequipment.com/support")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnWeb.Click
        'click the website link
        Process.Start("http://addiesequipment.com/")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub
End Class