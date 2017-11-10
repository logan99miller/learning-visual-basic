Module Module1

    Sub Restart() 'runs Main() sub again
        Console.WriteLine("Press enter to start again")
        Console.ReadLine()
        Console.Clear()
        Main()
    End Sub

    Sub Main()
        'outputs if number happy or sad
        'conditions for happy:
        'number replaced by sum of the squares of its digits
        'process repeated until number = 1

        Dim tempNumber, numberLength, repeats As Integer
        Dim number As String
        Console.WriteLine("Enter a number:")
        number = Console.ReadLine()
        numberLength = Len(number)
        Dim digit(numberLength) As Object 'array that will contan each digit of current number
        tempNumber = 0 'set as 0 for good practice
        repeats = 0 'has not repeated sum of digits yet
        While number <> 1
            For i = 1 To numberLength 'repeat for each digit
                digit(i) = Left(number, i) 'remove everything to right of digit
                digit(i) = Right(digit(i), 1) 'remove everything left of digit
                tempNumber = tempNumber + (digit(i) * digit(i)) 'temp number is sum of digits squared
            Next
            number = tempNumber
            tempNumber = 0 'reset temp number
            repeats += 1
            If repeats > 1000 Then 'if it has tried enough times (prevents infinte loops)
                Console.WriteLine("Cannot conclude if the number is happy.")
                Restart()
            End If
            Console.WriteLine("Proccessing... Current number is " & number & ".") 'provides output so you know program works
        End While
        Console.WriteLine("You selected a happy number.")
        Restart()
    End Sub

End Module
