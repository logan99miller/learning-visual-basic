Module Module1

    Sub Main()
        'will moniter uses progress of gaining xp to rank up in a game

        Dim xp As Integer = 0 'start with no xp
        Dim rankAwarded() As String = {"Corporal", "Sergeant", "Staff Sergeant", "Warrent Officer"} 'name of ranks
        Dim xpNeeded() As Integer = {100, 300, 700, 1500} 'xp needed for next rank (corresponds to rankAwarded())
        Dim isRankAchieved() As Boolean = {False, False, False, False} 'no ranks (except defualt) have been achieved yet (corresponds to ranksAwarded())
        Dim rank As String = "Private" 'defualt rank
        While xp < 2000
            Console.WriteLine(vbCrLf & "Current xp = " & xp)
            Console.WriteLine("Please enter the XP earned in the last game:")
            xp += Console.ReadLine() 'append to xp
            For i = 3 To 0 Step -1 'decrease by 1 each time (allow highest rank to be checked first
                If (xp > xpNeeded(i)) And (isRankAchieved(i) = False) Then 'if you have xp and not got rank yet (prevent being awarded rank multiple times)
                    rank = rankAwarded(i)
                    xp -= xpNeeded(i) 'remove xp needed for rank (but still leave left over xp
                    isRankAchieved(i) = True
                    Console.WriteLine(vbCrLf & "You have been promoted to rank " & rank & ".")
                    Exit For
                End If
            Next
        End While
    End Sub

End Module
