Public Class StartMenu

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Level1.Show()
        Me.Hide()
    End Sub

    Private Sub Levelss_Click(sender As Object, e As EventArgs) Handles Levelss.Click
        Levels.Show()
        Me.Hide()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Application.Exit()

    End Sub

    Private Sub Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MsgBox("Thank you! Come again!")
        Application.Exit()
    End Sub

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim timeResults As String
        timeResults = TimeResult.Text
        If timeResults = "0 seconds" Then
            Time.Visible = False
            TimeResult.Visible = False
        End If

    End Sub
End Class