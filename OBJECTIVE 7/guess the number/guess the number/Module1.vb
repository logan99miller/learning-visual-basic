Module Module1

    Sub Main()
        Dim number, guess, goes As Integer
        goes = 0
        Randomize()
        number = CInt((Rnd() * 99) + 1)
        While guess <> number
            Console.WriteLine("Make a guess:")
            guess = Console.ReadLine()
            If guess > number Then
                Console.WriteLine("Too high!")
            ElseIf guess < number Then
                Console.WriteLine("Too low!")
            End If
            goes = goes + 1
        End While
        Console.WriteLine("You guessed it in " & goes & " goes.")
        Console.ReadLine()
        Main()
    End Sub

End Module
