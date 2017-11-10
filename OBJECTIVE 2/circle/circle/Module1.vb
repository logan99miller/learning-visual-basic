Module Module1

    Sub Main()
        Dim pi, diameter, arcAngle, radius, area, circumference, arcLength As Decimal
        Console.WriteLine("Please enter the diameter:")
        diameter = Console.ReadLine()
        Console.WriteLine("Please enter the arc angle:")
        arcAngle = Console.ReadLine()
        radius = diameter / 2
        Console.WriteLine("Radius = " & radius)
        area = pi * radius * radius
        Console.WriteLine("Area = " & area)
        circumference = pi * diameter
        Console.WriteLine("Cirumference = " & circumference)
        arcLength = (circumference * arcAngle) / 360
        Console.WriteLine("Arc length = " & arcLength)
        Console.ReadLine()
    End Sub

End Module
