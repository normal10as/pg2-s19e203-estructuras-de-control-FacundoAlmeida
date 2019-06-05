Imports System

Module Program
    Sub Main(args As String())
        Const interes_anual = 0.36
        Dim capital, interes_x_mes, suma_interes, capital_inicial, saldo As Single
        Dim meses As Int16

        Console.WriteLine("Ingrese el capital inicial: ")
        capital = Console.ReadLine()
        capital_inicial = capital
        Console.WriteLine("Ingrese los meses: ")
        meses = Console.ReadLine()
        saldo = capital
        Console.WriteLine("Mes |" & " Capital |" & " Interes |" & " Saldo |")
        For i As Int16 = 1 To meses
            interes_x_mes = capital * (interes_anual / 12)
            saldo = capital + interes_x_mes
            Console.WriteLine(i & "   | " & capital & "     |    " & interes_x_mes & " |   " & saldo & "|")
            capital = saldo
            suma_interes = interes_x_mes
        Next
        saldo = capital - capital_inicial
        Console.WriteLine("El total ganado es de: $" & saldo)
    End Sub
End Module
