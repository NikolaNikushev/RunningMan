Public Class Levels
    Public Sub Content(ByVal pushed As Control)
        pushed.Show()
        Me.Hide()

    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles BackSelect.Click
        Content(StartMenu)

    End Sub

    Private Sub Level1_Click(sender As Object, e As EventArgs) Handles Level1Select.Click
        Content(Level1)
    End Sub

    Private Sub Level2_Click(sender As Object, e As EventArgs) Handles Level2Select.Click
        Content(Level2)
    End Sub

    Private Sub Level3_Click(sender As Object, e As EventArgs) Handles Level3Select.Click
        Content(Level3)
    End Sub

    Private Sub Level4_Click(sender As Object, e As EventArgs) Handles Level4Select.Click
        Content(Level4)
    End Sub

    Private Sub Level5_Click(sender As Object, e As EventArgs) Handles Level5Select.Click
        Content(Level5)
    End Sub

    Private Sub Levels_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Levels_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class