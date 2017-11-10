Module Module1
    Sub input()
        Dim productName, productPrice, decimalPlace As String
        Console.Clear()
        FileOpen(1, "catalogue.txt", OpenMode.Append) 'Appends to catalogue.txt - labelling it file 1
        Console.WriteLine("Please enter the product name")
        productName = Console.ReadLine()
        Console.WriteLine("Please enter the product's price e.g. 10.99")
        productPrice = Console.ReadLine()
        decimalPlace = Right(productPrice, 3) 'get last 3 characters of price
        decimalPlace = Left(decimalPlace, 1) 'get first of last 3 characters of price (where the decimal place should be)
        If decimalPlace = "." Then 'basic format check
            PrintLine(1, productName & " £" & productPrice) 'adds price and product to file 1
        Else
            Console.WriteLine("Failed to add product due to incorrect formatting for the price. Please ensure you have .xy after the amount of pounds")
        End If
        FileClose(1) 'closes file to prevent read/write errors
        Main() 'returns to selecting mode
    End Sub
    Sub output()
        Console.Clear()
        FileOpen(1, "catalogue.txt", OpenMode.Input) 'Allows catalgoue.txt to be read - labelling it file 1
        Do While Not EOF(1) 'repeats until end of file is reached
            Console.WriteLine(LineInput(1)) 'outputs line (note: line input attomatically appends each time command is repeated)
        Loop
        FileClose(1) 'closes file to prevent read/write errors
        Main() 'returns to selecting mode
    End Sub
    Sub find()
        Console.Clear()
        FileOpen(1, "catalogue.txt", OpenMode.Input) 'Allows catalgoue.txt to be read - labelling it file 1
        Console.WriteLine("Enter your search term e.g. computer")
        Dim userInput = Console.ReadLine()
        Console.Clear()
        Do While Not EOF(1) 'repeats until end of file is reached
            Dim currentLine = LineInput(1) 'Ensures line searched and line outputted are the same line (note: line input attomatically appends each time command is repeated)
            If currentLine.Contains(userInput) Then 'if product contains what we are searching for
                Console.WriteLine(currentLine)
            End If
        Loop
        FileClose(1)
        Main() 'returns to selecting mode
    End Sub
    Sub Main()
        Console.WriteLine("Enter any input to continue") 'checks user has read everything before clearing if a screen
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Enter 'i' for inputting new products, 'o' to output the catalogue and 'f' to find a product and output the price")
        Dim userInput = Console.ReadLine()
        Select Case userInput 'checks which mode user selects
            Case Is = "i"
                input()
            Case Is = "o"
                output()
            Case Is = "f"
                find()
            Case Else
                Console.WriteLine("Please enter a valid input")
                Main() 'returns to selecting mode
        End Select
    End Sub
End Module
