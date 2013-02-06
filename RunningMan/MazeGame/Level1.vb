Public Class Level1
    Public level1Deaths As Integer
    Public time As Integer
    Public finishedLevel1 As Boolean = False

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.BackColor = Color.Tomato
        MsgBox("Level 1. Can't be that hard.")
    End Sub
    Private Sub Level1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim startX, startY As Integer
        Dim finished As Boolean = False
        startX = 27
        startY = 36
        Functions.PlayerMovement(RunningMan, e)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
        Functions.MakeStartVisible(RunningMan, Start, Finish)
        finished = Functions.CheckFinish(RunningMan, Finish, Timer1, level1Deaths, finishedLevel1)

        If (finished = True) Then
            Functions.Message(time)
            Level2.Show()
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        Functions.Message(time)
        Level2.Show()
        Me.Close()
    End Sub

    Private Sub ToHome_Click(sender As Object, e As EventArgs) Handles ToHome.Click
        Functions.ReturnToStart(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
    End Sub
End Class