Module Module1

    Sub Main()
        Randomize()
        For i = 0 To 10
            Console.WriteLine(CInt(Rnd() * 5) + 1)
        Next
        Console.ReadLine()
    End Sub

End Module
