Public Class Level5
    Public time = 0, level5Deaths As Integer
    Public finishedLevel5 As Boolean
    Public startX As Integer = 27
    Public startY As Integer = 36

    Private Sub Level5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Functions.GlobalTime()
        StartMenu.Show()
    End Sub

    Private Sub Level5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Bisque
        MsgBox("Level5... The things get tricky here =)")
    End Sub

    Public Sub mover(ByVal move As Integer)
        If Label49.Left = 558 Then
            Timer4.Enabled = False
            Timer3.Enabled = True
        End If
        If Label49.Left = 751 Then
            Timer4.Enabled = True
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Level1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim finished As Boolean = False
        Functions.PlayerMovement(RunningMan, e)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
        Functions.MakeStartVisible(RunningMan, Start, Finish)
        finished = Functions.CheckFinish(RunningMan, Finish, Timer1, level5Deaths, finishedLevel5)

        If (finished = True) Then
            Functions.Message(time)
            MsgBox("Good job you finished level 5 !! More levels on the way!")
            Me.Close()

        End If
    End Sub

    Private Sub ToHome_Click(sender As Object, e As EventArgs) Handles ToHome.Click
        Functions.ReturnToStart(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label52.Top += 1
        If Label52.Top = 209 Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label52.Top -= 1
        If Label52.Top = 15 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label49.Left += 1
        mover(Label49.Left)
        Label50.Left += 1
        mover(Label50.Left)
        Label51.Left += 1
        mover(Label51.Left)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label49.Left -= 1
        mover(Label49.Left)
        Label50.Left -= 1
        mover(Label50.Left)
        Label51.Left -= 1
        mover(Label51.Left)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label48.Left += 1
        If Label48.Left = 894 Then
            Timer5.Enabled = False
            Timer6.Enabled = True
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label48.Left -= 1
        If Label48.Left = 558 Then
            Timer5.Enabled = True
            Timer6.Enabled = False
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label47.Left -= 2
        If Label47.Left < 1 Then
            Timer8.Enabled = True
            Timer7.Enabled = False
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label47.Left += 2
        If Label47.Left > 874 Then
            Timer7.Enabled = True
            Timer8.Enabled = False
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Label55.Left += 1
        Label54.Left -= 1
        If Label55.Left = 538 Then
            Timer10.Enabled = False
            Timer9.Enabled = True
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Label55.Left -= 1
        Label54.Left += 1
        If Label55.Left = 98 Then
            Timer9.Enabled = False
            Timer10.Enabled = True
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Label53.Left -= 1
        If Label53.Left = 0 Then
            Timer11.Enabled = False
            Timer12.Enabled = True
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Label53.Left += 1
        If Label53.Left = 267 Then
            Timer11.Enabled = True
            Timer12.Enabled = False
        End If
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        Functions.Spiral(Label37)
        Functions.Spiral(Label38)
        Functions.Spiral(Label39)
        Functions.Spiral(Label40)
        Functions.Spiral(Label41)
        Functions.Spiral(Label42)
        Functions.Spiral(Label43)
        Functions.Spiral(Label44)
        Functions.Spiral(Label45)
        Functions.Spiral(Label46)
        Functions.CheckCollision(RunningMan, Me.Controls, startX, startY)
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        MsgBox("Too hard?")
        Functions.Message(time)
        Timer16.Enabled = False
        Me.Close()

    End Sub


    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        Label56.Top -= 1
        If Label56.Top = 483 Then
            Timer14.Enabled = False
            Timer15.Enabled = True
        End If
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        Label56.Top += 1
        If Label56.Top = 562 Then
            Timer14.Enabled = True
            Timer15.Enabled = False
        End If
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        time += 1
    End Sub
End Class
