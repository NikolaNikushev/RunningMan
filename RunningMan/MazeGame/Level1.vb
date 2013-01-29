Public Class Level1
    Public level1Seconds, level1Minutes, level1Deaths As Integer
    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.BackColor = Color.Tomato
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
                    level1Deaths += 1
                End If
            End If
        Next
        If Me.Start.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            Finish.Visible = True
            Start.Visible = True
        Else
            Start.Visible = False
            Finish.Visible = True
        End If
        Timer1.Enabled = False
        level1Minutes = level1Seconds / 60
        If level1Minutes > 0 Then
            level1Seconds -= level1Minutes * 60
        End If
        If Me.Finish.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            MsgBox(Movement.message(level1Minutes, level1Seconds, level1Deaths))
            Level2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Level1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Come again!")
    End Sub

    Private Sub Finish_Click_1(sender As Object, e As EventArgs) Handles Finish.Click
        Level2.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        level1Seconds += 1
    End Sub
End Class