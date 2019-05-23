Imports System
Module Program
    Sub Main(args As String())
        Dim valor_a, valor_b As Single
        Console.WriteLine("Ingrese el valor A: ")
        valor_a = Console.ReadLine()
        Console.WriteLine("Ingrese el valor B: ")
        valor_b = Console.ReadLine()
        If (valorlac_a > valor_b) Then
            Console.WriteLine("La reion entre los dos valores es que valor A es mayor a el valor B.")
        ElseIf valor_a = valor_b Then
            Console.WriteLine("La relacion entre los dos valores es que el valor A es igual a valor B.")
        ElseIf valor_a < valor_b Then
            Console.WriteLine("La relacion entre los dos valores es que el valor B es mayor al valor A.")
        End If

    End Sub
End Module