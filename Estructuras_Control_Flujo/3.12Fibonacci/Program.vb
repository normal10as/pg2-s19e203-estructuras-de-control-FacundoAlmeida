Imports System

Module Program
    Sub Main(args As String())
        Dim valor1, valor2, resultado As Int16
        valor1 = 1
        valor2 = 0
        For i As Int16 = 1 To 20
            resultado = valor1 + valor2
            valor2 = valor1
            valor1 = resultado
            i = i + 1
            Console.WriteLine(resultado)

        Next
    End Sub
End Module
