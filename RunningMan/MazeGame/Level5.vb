Public Class Level5
    Public level5Seconds, level5Minutes, level5Hours, level5Deaths As Integer
    Public Sub spiral(ByVal place As Object)
        'Right TO TOP
        If place.left = 453 And place.Top > 184 And place.Top <= 313 Then
            place.Top -= 1
            If place.top = 184 Then
                place.left -= 1
            End If
        End If
        
        'Left TO BOT
        If place.Left = 287 And place.Top >= 184 And place.Top < 313 Then
            place.Top += 1
            If place.top = 313 Then
                place.left += 1
            End If
        End If
        
        'DOWN MIDDLE TO RIGHT
        If place.Top = 184 And place.Left >= 287 And place.Left < 453 Then
            place.Left -= 1
            If place.left = 287 Then
                place.top += 1
            End If
        End If
        
        'Top MIDDLE TO LEFT
        If place.Top = 313 And place.Left > 287 And place.Left <= 453 Then
            place.Left += 1
            If place.left = 453 Then
                place.top -= 1
            End If
        End If
        
    End Sub
    Public Function mover(ByVal move As Integer)

        If Label49.Left = 558 Then
            Timer4.Enabled = False
            Timer3.Enabled = True
        End If
        If Label49.Left = 751 Then
            Timer4.Enabled = True
            Timer3.Enabled = False
        End If
    End Function

    Private Sub Level5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start.Visible = True
        Finish.Visible = True
        MsgBox("Do not touch the walls and have fun! Use the arrow keys to move! Made by RunningManTeam© (Konstantin and Nikola)")
    End Sub
    Private Sub Level1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Dim startX, startY As Integer
        startX = 27
        startY = 36
        If e.KeyCode = Keys.Up Then
            Movement.playerUp(RunningMan)
        End If
        If e.KeyCode = Keys.Left Then
            Movement.playerLeft(RunningMan)
        End If
        If e.KeyCode = Keys.Down Then
            Movement.playerDown(RunningMan)
        End If
        If e.KeyCode = Keys.Right Then
            Movement.playerRight(RunningMan)
        End If

        For Each item As Control In Me.Controls
            If TypeOf item Is Label Then
                If RunningMan.Bounds.IntersectsWith(item.Bounds) Then
                    RunningMan.Left = startX
                    RunningMan.Top = startY
                End If
            End If
        Next
        If Me.Wall1.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then

            RunningMan.Left = 32

            RunningMan.Top = 31
            Level5Deaths += 1

        Else
        End If
        If Me.Start.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            Finish.Visible = True
            Start.Visible = True
        Else : Start.Visible = False
            Finish.Visible = True
        End If
        If Me.Finish.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            MsgBox(Movement.message(level5Minutes, level5Seconds, level5Deaths))
            MsgBox("Expect more levels soon!")
            Level1.Close()
            Level2.Close()
            Level3.Close()
            Level4.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Level1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Come again!")
    End Sub

    Private Sub Finish_Click(sender As Object, e As EventArgs)
        MsgBox("Thank you for playing.")
        Level1.Close()
        Level2.Close()
        Level3.Close()
        Level4.Close()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label52.Top += 1
        If Label52.Top = 209 Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label52.Top -= 1
        If Label52.Top = 15 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label49.Left += 1
        mover(Label49.Left)
        Label50.Left += 1
        mover(Label50.Left)
        Label51.Left += 1
        mover(Label51.Left)


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label49.Left -= 1
        mover(Label49.Left)
        Label50.Left -= 1
        mover(Label50.Left)
        Label51.Left -= 1
        mover(Label51.Left)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label48.Left += 1
        If Label48.Left = 894 Then
            Timer5.Enabled = False
            Timer6.Enabled = True
        End If

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label48.Left -= 1
        If Label48.Left = 558 Then
            Timer5.Enabled = True
            Timer6.Enabled = False
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label47.Left -= 2
        If Label47.Left < 1 Then
            Timer8.Enabled = True
            Timer7.Enabled = False
        End If

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label47.Left += 2
        If Label47.Left > 874 Then
            Timer7.Enabled = True
            Timer8.Enabled = False
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Label55.Left += 1
        Label54.Left -= 1
        If Label55.Left = 538 Then
            Timer10.Enabled = False
            Timer9.Enabled = True
        End If

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Label55.Left -= 1
        Label54.Left += 1
        If Label55.Left = 98 Then
            Timer9.Enabled = False
            Timer10.Enabled = True
        End If
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Label53.Left -= 1
        If Label53.Left = 0 Then
            Timer11.Enabled = False
            Timer12.Enabled = True
        End If
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Label53.Left += 1
        If Label53.Left = 267 Then
            Timer11.Enabled = True
            Timer12.Enabled = False
        End If
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        spiral(Label37)
        spiral(Label38)
        spiral(Label39)
        spiral(Label40)
        spiral(Label41)
        spiral(Label42)
        spiral(Label43)
        spiral(Label44)
        spiral(Label45)
        spiral(Label46)

    End Sub
End Class
