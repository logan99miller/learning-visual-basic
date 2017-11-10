Module Module1

    Sub Main()
        Dim typeOfAttributes() As String = {"name", "age", "strength", "attack damage", "defence mechanism"} 'array containing areas user can input string
        Dim file As String = "M:\VB CODE\OBJECTIVE 10\RGB FOLDER\attributes.txt" 'location of file MAY BECOME INVALID IN FUTURE
        Dim userInput As String 'what user enters
        FileOpen(1, file, OpenMode.Output) 'open file as file 1 in mode where we can output from console to file
        For repeats = 0 To typeOfAttributes.Count - 1 'asks for each attribute (-1 because .Count has 1 indexing)
            Console.WriteLine("Please enter the characters " & typeOfAttributes(repeats)) 'ask about next attribute
            userInput = Console.ReadLine() 'accepts user input
            PrintLine(1, userInput) 'Prints user's input into file 1 (only file being used)
        Next
        FileClose(1) 'close file 1 (only file being used)
        Console.WriteLine("Your attributes have been save to the file " & file)
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
