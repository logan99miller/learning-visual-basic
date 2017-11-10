Module Module1

    Sub Main()
        ' the program checks the length of gamerTags entered.
        Dim valid_gamertag As Boolean = False
        Dim gamertag As String
        Console.WriteLine("Enter your gamer tag:")
        While valid_gamertag = False
            gamertag = Console.ReadLine()
            If Len(gamertag) > 15 Then
                Console.WriteLine("Too long")
            Else
                valid_gamertag = True
            End If
        End While
        Console.WriteLine("Accepted")
        Console.ReadLine()
        Main()
    End Sub

End Module
