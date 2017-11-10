Module Module1

    Function Vat(price)
        price = price * 1.2
        Return price
    End Function

    Sub Main()
        Console.WriteLine("What is the price of the item?")
        Console.WriteLine("Price with VAT is : " & Vat(Console.ReadLine()))
        Console.ReadLine()
    End Sub

End Module
