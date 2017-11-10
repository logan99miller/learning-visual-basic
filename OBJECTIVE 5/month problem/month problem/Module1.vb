Module Module1

    Sub Main()
        Dim year, month, days As Integer
        Dim monthName() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim monthLength() As String = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Console.WriteLine("Please enter a year:")
        year = Console.ReadLine()
        Console.WriteLine("Please enter a month (e.g. 1, 5 or 12:")
        month = Console.ReadLine()
        If year Mod 4 = 0 Then
            monthLength(1) = 29
        End If
        days = monthLength(month - 1)
        Console.WriteLine(monthName(month - 1) & " has " & days & " days in " & year)
        Console.ReadLine()
        Main()
    End Sub

End Module
