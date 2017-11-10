Module Module1

    Sub Main()
        Dim dice() As Integer
        Randomize()
        For i = 0 To 2
            dice(i) = CInt(Rnd() * 6) - 1
            Console.WriteLine("Dice " & i & " rolled a " & dice(i))
        Next
        Console.ReadLine()

    End Sub

End Module
