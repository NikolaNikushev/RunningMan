Public Class Functions
    Public Sub PlayerMovement(ByVal player As Object, ByVal direction As System.Windows.Forms.KeyEventArgs)
        If direction.KeyCode = Keys.Up Then
            player.Top -= 10
        End If
        If direction.KeyCode = Keys.Left Then
            player.left -= 10
        End If
        If direction.KeyCode = Keys.Down Then
            player.Top += 10
        End If
        If direction.KeyCode = Keys.Right Then
            player.left += 10
        End If
    End Sub
    Public Sub Spiral(ByVal place As Object)
        'Right TO TOP
        If place.left = 452 And place.Top >= 184 And place.Top <= 313 Then
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
    Public playerDeaths As Integer
    Public Sub CheckCollision(ByVal player As Object, ByVal collisionElement As Control.ControlCollection, ByVal startX As Integer, ByVal startY As Integer)
        For Each item As Control In collisionElement
            If TypeOf item Is Label Then
                If player.Bounds.IntersectsWith(item.Bounds) Then
                    player.Left = startX
                    player.Top = startY
                    playerDeaths += 1
                End If
            End If
        Next
    End Sub
    Public Sub MakeStartVisible(ByVal player As Object, ByVal start As Object, ByVal finish As Object)
        If start.Bounds.IntersectsWith(player.Bounds) Then
            finish.Visible = True
            start.Visible = True
        Else
            start.Visible = False
            finish.Visible = True
        End If
    End Sub
    Public Function CheckFinish(ByVal player As Object, ByVal finish As Object, ByVal timer As Object, ByVal levelDeaths As Integer, ByVal finishedLevel As Boolean)
        If finish.Bounds.IntersectsWith(player.Bounds) Then
            timer.Enabled = False
            finishedLevel = True
        End If
        Return finishedLevel
    End Function
    Public Function CalculateMinutes(ByVal seconds As Integer)
        seconds /= 60
        Return seconds
    End Function
    Public globalAnswerMin, globalAnswerSec As Integer
    Public Sub Message(ByVal time As Integer)
        Dim globalSec, globalMin As Integer
        globalMin = CalculateMinutes(time)
        globalSec = time
        While globalSec > 60
            globalSec = (time - (60 * CalculateMinutes(time)))
        End While
        globalAnswerMin += globalMin
        globalAnswerSec += globalSec
        MsgBox("You did the level for: " & globalMin & " minutes " & " and " & globalSec & " seconds")
       

    End Sub
    Public Sub GlobalTime()
        Dim times As Integer
        While globalAnswerSec > 60
            globalAnswerMin += globalAnswerSec / 60
            times = globalAnswerSec / 60
            globalAnswerSec -= (times * 60)
        End While
        StartMenu.TimeResult.Text = globalAnswerMin & " minutes  " & " and " & globalAnswerSec & " seconds" & " and died " & playerDeaths & " times"
        StartMenu.TimeResult.Visible = True
        StartMenu.Time.Visible = True
    End Sub
    Public Sub ReturnToStart(ByVal starter As Control)
        starter.Hide()
        StartMenu.Show()
    End Sub
End Class