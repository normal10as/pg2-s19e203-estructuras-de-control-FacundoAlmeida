Imports System

Module Program
    Enum operaciones As Integer
        suma = 1
        resta = 2
        division = 3
        multiplicacion = 4

    End Enum
    Sub Main(args As String())
        Console.WriteLine("Suma: " & Calcular(operaciones.suma))
        Console.WriteLine("Resta: " & Calcular(operaciones.resta))
        Console.WriteLine("Multiplicacion: " & Calcular(operaciones.division))
        Console.WriteLine("Division: " & Calcular(operaciones.multiplicacion))
        Console.WriteLine("Suma sin enumeracion: " & suma(10, 10))
        Console.WriteLine("Suma sin enum(3 parametros) " & suma(10, 10, 10))
        Console.WriteLine("Suma sin enume(4 parametros) " & suma(10, 10, 10, 10))

    End Sub
    Private Function Calcular(ByVal nro_operacion) As Single
        Dim resultado As Single
        Select Case nro_operacion
            Case 1
                resultado = suma(5, 8)
                resultado = suma(5, 8, 8, 5)
            Case 2
                resultado = resta(5, 8)
                resultado = resta(5, 8, 8, 5)
            Case 3
                resultado = multiplicacion(5, 8)
                resultado = multiplicacion(5, 5, 8, 8)
            Case 4
                resultado = division(5, 8)
                resultado = division(5, 8, 8, 8)
        End Select
        Return resultado
    End Function

    Private Function suma(ByVal valor1, ByVal valor2) As Single
        Return (valor1 + valor2)
    End Function
    Private Function suma(ByVal valor1, ByVal valor2, ByVal valor3) As Single
        Return suma(valor1, valor2) + valor3
    End Function

    Private Function suma(ByVal valor1, ByVal valor2, ByVal valor3, ByVal valor4) As Single
        Return suma(valor1, valor2) + suma(valor3, valor4)
    End Function

    Private Function resta(ByVal valor1, ByVal valor2) As Single
        Return (valor1 - valor2)
    End Function
    Private Function resta(ByVal valor1, ByVal valor2, ByVal valor3) As Single
        Return resta(valor1, valor2) - valor3
    End Function
    Private Function resta(ByVal valor1, ByVal valor2, ByVal valor3, ByVal valor4) As Single
        Return resta(valor1, valor2) - resta(valor3, valor4)

    End Function
    Private Function multiplicacion(ByVal valor1, ByVal valor2) As Single
        Return (valor1 * valor2)
    End Function
    Private Function multiplicacion(ByVal valor1, ByVal valor2, ByVal valor3) As Single
        Return multiplicacion(valor1, valor2) * valor3
    End Function
    Private Function multiplicacion(ByVal valor1, ByVal valor2, ByVal valor3, ByVal valor4) As Single
        Return multiplicacion(valor1, valor2) * multiplicacion(valor3, valor4)
    End Function
    Private Function division(ByVal valor1, ByVal valor2) As Single
        Return (valor1 / valor2)
    End Function
    Private Function division(ByVal valor1, ByVal valor2, ByVal valor3) As Single
        Return division(valor1, valor2) / valor3
    End Function
    Private Function division(ByVal valor1, ByVal valor2, ByVal valor3, ByVal valor4) As Single
        Return division(valor1, valor2) / division(valor3, valor4)
    End Function
End Module