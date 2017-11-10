Module Module1
    Sub Main()
        Dim notebook(9) As String
        Dim editNumber As Integer
        Dim edit As String
        Dim validNumber As Boolean
        While True
            For repeats = 0 To 9
                Console.WriteLine(repeats + 1 & ": " & notebook(repeats))
            Next
            Console.WriteLine("Which note do you wish to edit?")
            'Do
            '    editNumber = Console.ReadLine()
            'Loop While Not editNumber > 0 And Not editNumber < 11
            validNumber = False
            While validNumber = False
                editNumber = Console.ReadLine()
                If editNumber > 0 And editNumber < 11 Then
                    validNumber = True
                End If
            End While
            Console.WriteLine("Please enter your new note:")
            edit = Console.ReadLine()
            notebook(editNumber - 1) = edit
            Console.Clear()
        End While
    End Sub
End Module
