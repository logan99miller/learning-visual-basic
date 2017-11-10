Module Module1
    Dim points As Integer = 501
    Sub Main()
        Console.WriteLine(vbCrLf & "New game. Player starts at " & points & " points.")
        While points <> 0 'while they have not won
            Dim playerPoints As Integer
            Console.WriteLine(vbCrLf & "Please enter your total from 3 darts:")
            playerPoints = Console.ReadLine()
            If points - playerPoints < 3 And points - playerPoints <> 0 Then 'if your score goes below 3 then dont count the throw, but do not discount throw if player is about to win
                Console.WriteLine(vbCrLf & "Throw did not count")
            Else 'occurs on most throws
                points -= playerPoints
                Console.WriteLine(vbCrLf & "Points: " & points)
            End If
        End While
        Console.WriteLine(vbCrLf & "You have won!") 'has won if loop exited
        Console.ReadLine()a
    End Sub

End Module
