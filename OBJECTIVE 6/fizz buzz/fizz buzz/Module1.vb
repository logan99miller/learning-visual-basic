Module Module1

    Sub Main()
        For repeats = 1 To 100
            If (repeats Mod 3 = 0) And (repeats Mod 5 = 0) Then
                Console.WriteLine("FizzBuzz")
            ElseIf repeats Mod 3 = 0 Then
                Console.WriteLine("Fizz")
            ElseIf repeats Mod 5 = 0 Then
                Console.WriteLine("Buzz")
            Else
                Console.WriteLine(repeats)
            End If
        Next
        Console.ReadLine()
        Main()
    End Sub

End Module
