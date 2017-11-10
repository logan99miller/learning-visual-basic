Module Module1

    Sub Main()
        Dim balance, withdraw, remainder, smallestNote As Integer
        balance = 231
        smallestNote = 10
        Console.WriteLine("Your balance is: " & balance)
        Console.WriteLine("How much do you wish to withdraw?")
        withdraw = Console.ReadLine()
        remainder = withdraw Mod smallestNote
        If (remainder = 0) And (withdraw <= 231) Then
            balance = balance - withdraw
            Console.WriteLine("Your balance is: " & balance)
        Else
            Console.WriteLine("You cannot withdraw this amount")
        End If
        Console.ReadLine()
        Main()
    End Sub

End Module
