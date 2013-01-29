
Public Class Level3
    Public level3Seconds, level3Minutes, level3Hours, level3Deaths As Integer
    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SandyBrown
        Timer1.Enabled = True
        Start.Visible = True
        Finish.Visible = True
        MsgBox("Level 3! Excellent work! It's keeps on getting harder!")


    End Sub

    Private Sub Level3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim startX, startY As Integer
        startX = 24
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
                    level3Deaths += 1
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
        level3Minutes = level3Seconds / 60
        If level3Minutes > 0 Then
            level3Seconds -= level3Minutes * 60
        End If
        If Me.Finish.Bounds.IntersectsWith(Me.RunningMan.Bounds) Then

            MsgBox(Movement.message(level3Minutes, level3Seconds, level3Deaths))
            Level4.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Level3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Come again!")
    End Sub

    Private Sub Finish_Click_1(sender As Object, e As EventArgs) Handles Finish.Click
        Level4.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        level3Seconds += 1
    End Sub
End Class