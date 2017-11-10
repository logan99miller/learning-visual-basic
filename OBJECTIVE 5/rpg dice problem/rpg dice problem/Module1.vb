Module Module1

    Sub Main()
        Dim sides, randomInteger As Integer
        Dim randomDecimal As Decimal

        Console.WriteLine("How many sides does your dice have?")
        sides = Console.ReadLine()

        Randomize() 'generates random seed
        randomDecimal = Rnd() * (sides - 1) 'random decimal multiplied by amount of sides -1 ( as 1 is added later)
        randomInteger = CInt(randomDecimal + 1) 'converted to decimal and then add 1 to prevent 0s
        Console.WriteLine("You rolled a " & randomInteger)
        Console.ReadLine()
    End Sub

End Module
