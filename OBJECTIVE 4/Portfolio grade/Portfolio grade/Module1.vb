Module Module1

    Sub Main()
        Dim marks As Integer
        Dim boundary2, boundary3, boundary4, boundary5, boundary6, boundary7, boundary8, boundary9 As Integer
        boundary2 = 4
        boundary3 = 13
        boundary4 = 22
        boundary5 = 31
        boundary6 = 41
        boundary7 = 54
        boundary8 = 67
        boundary9 = 80
        Dim grade As String
        Dim sections() As String = {"analysis", "design", "implementation", "evaluation"} 'contains each section
        For repeats = 0 To sections.Length() - 1 'asks for each section
            Console.WriteLine(vbCrLf & "Enter your marks for " & sections(repeats) & ":") 'ask for relevant section
            marks = marks + Console.ReadLine() 'appends to total marks
        Next
        Console.WriteLine(vbCrLf & "Total marks = " & marks)
        Select Case marks
            Case Is < boundary2
                grade = "1"
            Case Is < boundary3
                grade = "2"
            Case Is < boundary4
                grade = "3"
            Case Is < boundary5
                grade = "4"
            Case Is < boundary6
                grade = "5"
            Case Is < boundary7
                grade = "6"
            Case Is < boundary8
                grade = "7"
            Case Is < boundary9
                grade = "8"
            Case Else
                grade = "9"
        End Select
        Console.WriteLine("You achieved a grade: " & grade)
        Console.ReadLine()

    End Sub

End Module
