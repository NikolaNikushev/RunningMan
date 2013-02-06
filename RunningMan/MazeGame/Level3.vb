
Public Class Level3
    Public level3Deaths, time As Integer
    Public finishedLevel3 As Boolean

    Private Sub ToHome_Click(sender As Object, e As EventArgs) Handles ToHome.Click
        Functions.ReturnToStart(Me)
    End Sub
    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SandyBrown
        Timer1.Enabled = True
        MsgBox("Level 3! Excellent work! It's keeps on getting harder!")
    End Sub

    Private Sub Level3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim startX, startY As Integer
        Dim finished As Boolean = False
        startX = 24
        startY = 31
        Functions.PlayerMovement(RunningMan, e)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
        Functions.MakeStartVisible(RunningMan, Start, Finish)
        finished = Functions.CheckFinish(RunningMan, Finish, Timer1, level3Deaths, finishedLevel3)

        If (finished = True) Then
            Functions.Message(time)
            Level4.Show()
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        Functions.Message(time)
        Level4.Show()

        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
    End Sub

End Class