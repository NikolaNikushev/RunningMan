
Public Class Level4
    Public level4Deaths, time As Integer
    Public finishedlevel4 As Boolean
    Private Sub Level4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.RosyBrown
        Timer1.Enabled = True
        MsgBox("Level 4! So far so good, but can you follow the way?")

    End Sub

    Private Sub Level4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim startX, startY As Integer
        Dim finished As Boolean = False

        startX = 134
        startY = 31
        Functions.PlayerMovement(RunningMan, e)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
        Functions.MakeStartVisible(RunningMan, Start, Finish)
        finished = Functions.CheckFinish(RunningMan, Finish, Timer1, level4Deaths, finishedlevel4)

        If (finished = True) Then
            Functions.Message(time)
            Level5.Show()
            Me.Close()
            Timer1.Enabled = False
        End If
     
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        MsgBox("Good enough.")
        Functions.Message(time)
        Level5.Show()
        Me.Close()
    End Sub
    Private Sub ToHome_Click(sender As Object, e As EventArgs) Handles ToHome.Click
        Functions.ReturnToStart(Me)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
    End Sub
End Class

