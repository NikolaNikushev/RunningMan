Public Class Level2
    Public time, level2Deaths As Integer
    Public finishedLevel2 As Boolean

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Level 2! Your doing great!")
        Timer1.Enabled = True
        Me.BackColor = Color.Tan
    End Sub
    Private Sub Level2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim startX, startY As Integer
        Dim finished As Boolean = False
        startX = 469
        startY = 394

        Functions.PlayerMovement(RunningMan, e)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
        Functions.MakeStartVisible(RunningMan, Start, Finish)
        finished = Functions.CheckFinish(RunningMan, Finish, Timer1, level2Deaths, finishedLevel2)
     
        If (finished = True) Then
            Functions.Message(time)
            Level3.Show()
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        Functions.Message(time)
        Level3.Show()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
    End Sub
    Private Sub ToHome_Click(sender As Object, e As EventArgs) Handles ToHome.Click
        Functions.ReturnToStart(Me)
    End Sub
End Class