
Public Class Level4
    Public level4Seconds, level4Minutes, level4Hours, level4Deaths As Integer
    Private Sub Level4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.RosyBrown
        Timer1.Enabled = True
        Start.Visible = True
        Finish.Visible = True
        MsgBox("Level 4! So far so good, but can you follow the way?")

    End Sub

    Private Sub Level4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim startX, startY As Integer
        startX = 134
        startY = 31
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
                    level4Deaths += 1
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
        level4Minutes = level4Seconds / 60
        If level4Minutes > 0 Then
            level4Seconds -= level4Minutes * 60
        End If
        If Me.Finish.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            MsgBox(Movement.message(level4Minutes, level4Seconds, level4Deaths))
            Level5.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Level4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Come again!")
    End Sub

    Private Sub Finish_Click_1(sender As Object, e As EventArgs) Handles Finish.Click
        MsgBox("Good enough.")
        Level5.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        level4Seconds += 1
    End Sub
End Class

