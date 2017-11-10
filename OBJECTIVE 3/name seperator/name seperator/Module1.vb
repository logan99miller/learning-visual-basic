Module Module1

    Sub Main()
        Dim fullName, splitName(), forname, surname As String
        Dim space As Integer

        fullName = Console.ReadLine()
        For c = 0 To Len(fullName) - 1
            Console.WriteLine(fullName(c))
        Next

        'space = InStr(fullName, " ")
        'If space = 0 Then
        '    Console.WriteLine("Invalid input")
        'Else
        '    forname = Left(fullName, space - 1)
        '    surname = Right(fullName, Len(fullName) - space)
        '    Console.WriteLine("Forname = " & forname)
        '    Console.WriteLine("Surname = " & surname)
        'End If



        'Dim spacePresent As Boolean = False
        'Dim namesChars() As Char
        'Dim numberOfSpaces As Integer
        'While spacePresent = False
        '    numberOfSpaces = 0 'currently no spaces in name as name not entered
        '    Console.WriteLine("Please enter your first and second name:")
        '    fullName = Console.ReadLine()
        '    namesChars = fullName.ToCharArray 'split up name into each character
        '    For i = 0 To (namesChars.Length() - 1) 'test each character
        '        If namesChars(i) = " " Then 'if theres a space then record it
        '            numberOfSpaces = numberOfSpaces + 1
        '        End If
        '    Next
        '    If numberOfSpaces = 1 Then 'only exit loop if only one space (thus, only 2 words)
        '        spacePresent = True
        '    End If
        'End While
        'splitName = fullName.Split(" ") 'split words into different elements in array
        'forname = splitName(0)
        'surname = splitName(1)
        'Console.WriteLine("Forname = " & forname)
        'Console.WriteLine("Surname = " & surname)
        Console.ReadLine()
    End Sub

End Module
