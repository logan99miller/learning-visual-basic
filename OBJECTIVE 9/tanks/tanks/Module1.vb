Module Module1
    Dim board(2, 7, 7), killBoard(2, 7, 7), xCord, yCord As String
    Dim tankCount(2) As Integer
    Dim amountOfTanks = 10
    Function inGrid(player, xCord, yCord)
        Try
            If xCord >= 0 And xCord <= 7 And yCord >= 0 And yCord <= 7 Then 'if tank is within grid
                inGrid = True
            Else
                Console.WriteLine("You must selet a location within the grid")
                inGrid = False
            End If
        Catch
            Console.WriteLine("You must enter cordinates in the form 'X,Y'")
        End Try
    End Function
    Sub pickCords(player)
        Dim cords As String
        cords = Console.ReadLine()
        xCord = Left(cords, 1) 'extract x cord from input
        yCord = Right(cords, 1) 'extract y cord form input
        If inGrid(player, xCord, yCord) = True Then
            Exit Sub
        Else
            Console.WriteLine("The cordinates must be within the grid, try again")
            pickCords(player)
        End If
    End Sub
    Sub displayGrid(player, gameStarted)
        Console.Clear()
        Console.WriteLine(vbCrLf & "Player " & player & "'s grid:")
        Console.Write(vbCrLf & " ")
        For column = 0 To 7
            Console.Write(" " & column & " ") 'label the columns
        Next
        For xAxis = 0 To 7 'repeats for all row
            Console.WriteLine() 'ensures next line is displayed on next line
            Console.Write(xAxis & " ") 'label the rows
            For yAxis = 0 To 7 'repeats for all column
                If gameStarted = False Then
                    Console.Write(board(player, xAxis, yAxis) & "  ") 'displays value for specific player's x & y axis AND some blank space for asthetics
                Else
                    Console.Write(killBoard(player, xAxis, yAxis) & "  ")
                End If
            Next
        Next
        Console.WriteLine()
    End Sub
    Sub setTanks(player)
        Dim validCords As Boolean
        Console.WriteLine()
        For tankNumber = 1 To amountOfTanks 'repeat for amount of tanks each player places
            validCords = False 'not yet selected cord which exists AND not already taken
            While validCords = False 'keep asking for cords until it is valid
                Console.WriteLine("Please enter tank number " & tankNumber & "'s location in form 'X,Y'")
                pickCords(player)
                If board(player, xCord, yCord) = "." Then
                    board(player, xCord, yCord) = "T" 'place tank
                    displayGrid(player, False)
                    validCords = True 'exit loop because a tank has been successfully placed
                Else
                    Console.WriteLine("A tank is already at that location")
                End If
            End While
        Next
    End Sub
    Sub attackPlayer(player)
        Console.Clear()
        displayGrid(player, True)
        If player = 2 Then
            Console.WriteLine("Player 1's go to attack")
        Else
            Console.WriteLine("Player 2's go to attack")
        End If
        Console.WriteLine("Enter where you would like to bomb in form 'X,Y'")
        pickCords(player)
        If board(player, xCord, yCord) = "T" Then
            killBoard(player, xCord, yCord) = "X" 'place x
            tankCount(player) -= 1
            Console.WriteLine("--- Hit! ---")
        Else
            killBoard(player, xCord, yCord) = "O" 'place x
            Console.WriteLine("-- Missed --")
        End If
    End Sub
    Sub Main()
        tankCount(1) = amountOfTanks
        tankCount(2) = amountOfTanks
        For player = 1 To 2 'Do for each player
            For xAxis = 0 To 7 'repeat for each row
                For yAxis = 0 To 7 'repeat for each column
                    board(player, xAxis, yAxis) = "." 'set value for specific player's x & y axis. "." represents blank spot
                    killBoard(player, xAxis, yAxis) = "." 'set value for specific player's x & y axis. "." represents blank spot
                Next
            Next
            displayGrid(player, False)
            setTanks(player)
        Next
        While True
            attackPlayer(2)
            Console.ReadLine()
            attackPlayer(1)
            Console.ReadLine()
            If tankCount(1) = 0 Then
                Console.WriteLine("Player 2 has won!")
                Exit While
            ElseIf tankCount(2) = 0 Then
                Console.WriteLine("Player 1 has won!")
                Exit While
            End If
        End While
        Console.ReadLine()
    End Sub

End Module