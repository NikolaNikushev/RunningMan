Public Class Movement
    Public Sub playerUp(ByVal player As Object)
        player.Top -= 10
    End Sub
    Public Sub playerDown(ByVal player As Object)
        player.Top += 10
    End Sub
    Public Sub playerLeft(ByVal player As Object)
        player.left -= 10
    End Sub
    Public Sub playerRight(ByVal player As Object)
        player.left += 10
    End Sub
    Public Function message(ByVal minutes As Integer, ByVal seconds As Integer, ByVal deaths As Integer)
        Dim endtext As String
        Dim sendtext As String
        If minutes > 1 Then
            endtext = minutes & " minutes "
            If seconds > 1 Then
                endtext += "and " & seconds & " seconds"
            ElseIf seconds = 1 Then
                endtext += "and 1 second"
            End If
        ElseIf minutes = 1 Then
            endtext = "1 minute "
            If seconds > 1 Then
                endtext += "and " & seconds & " seconds"
            ElseIf seconds = 1 Then
                endtext += "and 1 second"
            End If
        Else
            endtext = seconds & " seconds"
        End If
        sendtext = "You finished the level! You made " & deaths & " deaths and it took you " & endtext
        Return sendtext
    End Function
End Class