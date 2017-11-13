Module Module1

    Sub Main()
        Dim hoursWorked, hourlyRate, grossPay As Decimal
        Const maxHours As Integer = 60
        Const minHours As Integer = 0
        Const bonusHoursBoundary As Integer = 40
        Const bonusMultipler As Integer = 1.5

        Console.WriteLine("Please enter how many hours you worked this week")
        While True 'will repeat until input is given in correct format
            Try 'prevents program from crashing if invalid format is given
                hoursWorked = Console.ReadLine()
                Exit While
            Catch
                Console.WriteLine("Please enter your hours worked as a number")
            End Try
        End While

        Console.WriteLine("Please enter your hourly rate")
        While True 'will repeat until input is given in correct format
            Try 'prevents program from crashing if invalid format is given
                hourlyRate = Console.ReadLine()
                Exit While
            Catch
                Console.WriteLine("Please enter your hours worked as a number")
            End Try
        End While

        If hoursWorked > maxHours Or hoursWorked < minHours Then 'If the hours worked are not within an acceptable range then start again
            Console.WriteLine("Your hours are not within the accepted range. Enter any input to try again")
            Console.ReadLine()
            Console.Clear()
            Main()
        End If

        grossPay = 0 'reset pay (also allows the += to work without causing an error)
        For hours = 1 To hoursWorked 'repeat for each hour worked
            If hours > bonusHoursBoundary Then 'If the current hour does qualify for a bonus
                grossPay += hourlyRate * bonusMultipler 'Add hourly rate with bonusMultiplier to gross pay
            Else 'Hour does not qualify for bonus
                grossPay += hourlyRate 'Add hourly rate to gross pay
            End If
        Next

        Console.WriteLine("Your gross pay is £" & grossPay)

        Console.WriteLine("Enter any input to restart")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

End Module