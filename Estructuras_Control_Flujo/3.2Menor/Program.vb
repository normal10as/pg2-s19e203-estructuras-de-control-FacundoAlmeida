Imports System

Module Program
    Sub Main(args As String())
        Dim valor_a, valor_b, valor_c As Single

        Console.WriteLine("El primero: ")
        valor_a = Console.ReadLine()
        Console.WriteLine("El segundo: ")
        valor_b = Console.ReadLine()
        Console.WriteLine("El tercero: ")
        valor_c = Console.ReadLine()

        If valor_a < valor_b And valor_a < valor_c Then
            Console.WriteLine("El menor valor ingresado es el " & valor_a & ".")
        ElseIf valor_b < valor_c Then
            Console.WriteLine("El menor valor ingresado es el " & valor_b & ".")
        Else
            Console.WriteLine("El menor valor ingresado es el " & valor_c & ".")
        End If

    End Sub
End Module
