Module Module1

    Sub Main()
        Dim integer1, integer2, answer, correct As Integer
        Randomize()
        For repeats = 1 To 10
            integer1 = CInt((Rnd() * 9) + 1)
            integer2 = CInt((Rnd() * 9) + 1)
            Console.WriteLine("What is " & integer1 & " + " & integer2 & "?")
            answer = Console.ReadLine()
            If integer1 + integer2 = answer Then
                Console.WriteLine("You are correct :)")
                correct = correct + 1
            Else
                Console.WriteLine("You are wrong :(")
            End If
        Next
        Console.WriteLine("You got " & correct & " questions right")
        Console.ReadLine()
        Main()
    End Sub

End Module
