Public Class Level2
    Public level2Seconds, level2Minutes, level2Deaths As Integer
    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Level 2! Your doing great!")
        Timer1.Enabled = True
        Me.BackColor = Color.Tan
        Start.Visible = True
        Finish.Visible = True
    End Sub

    Private Sub Level2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim startX, startY As Integer
        startX = 469
        startY = 394
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
                    level2Deaths += 1
                End If
            End If
        Next
        If Me.Start.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            Finish.Visible = True
            Start.Visible = True
        Else : Start.Visible = False
            Finish.Visible = True
        End If
        Timer1.Enabled = False
        level2Minutes = level2Seconds / 60
        If level2Minutes > 0 Then
            level2Seconds -= level2Minutes * 60
        End If
        If Me.Finish.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then
            MsgBox(Movement.message(level2Minutes, level2Seconds, level2Deaths))
            Level3.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Level2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Come again!")
    End Sub

    Private Sub Finish_Click_1(sender As Object, e As EventArgs) Handles Finish.Click
        Level3.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        level2Seconds += 1
    End Sub
End Class