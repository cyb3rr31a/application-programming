Public Class WelcomeForm

    ' Create a ToolTip instance
    Dim toolTip As New ToolTip()

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set tooltips for buttons
        toolTip.SetToolTip(BtnLoadObjectDemo, "Load Object Demo Form")
        toolTip.SetToolTip(BtnExit, "Exit Application")

    End Sub

    Private Sub Welcome_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If

        ' Set initial background color
        Me.BackColor = Color.Red
    End Sub

    Private Sub BtnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles BtnLoadObjectDemo.Click
        ' Create an instance of the ObjectDemonstrations form
        Dim objectDemoForm As New ObjectDemonstrations()

        ' Show the ObjectDemonstrations form
        objectDemoForm.Show()

        ' Hide the main form
        Me.Hide()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' Close the main form, which will terminate the application
        Me.Close()
    End Sub

End Class
