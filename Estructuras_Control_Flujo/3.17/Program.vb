Imports System


Module Program
    Enum operaciones As Int16
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4

    End Enum
    Sub Main(args As String())
        imprimirpantalla()
    End Sub

    Sub imprimirpantalla()
        Console.WriteLine("5 + 8 = " & Resultado(operaciones.suma, 5, 8))
        Console.WriteLine("5 + 8 + 5 = " & Resultado(operaciones.suma, 5, 8, 5))
        Console.WriteLine("5 - 8 = " & Resultado(operaciones.resta, 5, 8))
        Console.WriteLine("5 - 8 - 5 =" & Resultado(operaciones.resta, 5, 8, 5))
        Console.WriteLine("5 * 5 = " & Resultado(operaciones.multiplicacion, 5, 5))
        Console.WriteLine("5 * 5 * 8 =" & Resultado(operaciones.multiplicacion, 5, 5, 8))
        Console.WriteLine("5 / 5 =" & Resultado(operaciones.division, 5, 5))
        Console.WriteLine("5 /3 /1 =" & Resultado(operaciones.division, 5, 3, 1))

    End Sub
    Function Resultado(ByRef operaciones As Single, ByVal valor1 As Single, ByVal valor2 As Single) As Single
        Dim valor_devuelto As Single
        Select Case operaciones
            Case 1
                valor_devuelto = suma(valor1, valor2)
            Case 2
                valor_devuelto = resta(valor1, valor2)
            Case 3
                valor_devuelto = multiplicacion(valor1, valor2)
            Case 4
                valor_devuelto = division(valor1, valor2)
        End Select
        Return valor_devuelto
    End Function
    Function Resultado(ByVal operaciones, ByVal valor1, ByVal valor2, ByVal valor3) As Single
        Select Case operaciones
            Case 1
                Resultado = suma(valor1, valor2, valor3)
            Case 2
                Resultado = resta(valor1, valor2, valor3)
            Case 3
                Resultado = multiplicacion(valor1, valor2, valor3)
            Case 4
                Resultado = division(valor1, valor2, valor3)
        End Select
    End Function


    Function suma(ByVal valor1, ByVal valor2)
        Return (valor1 + valor2)
    End Function
    Function suma(ByVal valor1, ByVal valor2, ByVal valor3)
        Return (suma(valor1, valor2) + valor3)
    End Function
    '-------------------------------------------
    Function resta(ByVal valor1, ByVal valor2)
        Return valor1 - valor2
    End Function
    Function resta(ByVal valor1, ByVal valor2, ByVal valor3)
        Return resta(valor1, valor2) - valor3
    End Function
    '-----------------------------------------
    Function multiplicacion(ByVal valor1, ByVal valor2)
        Return valor1 * valor2
    End Function

    Function multiplicacion(ByVal valor1, ByVal valor2, ByVal valor3)
        Return (multiplicacion(valor1, valor2) * valor3)
    End Function
    '-----------------------------------------------
    Function division(ByVal valor1, ByVal valor2)
        Return valor1 / valor2
    End Function

    Function division(ByVal valor1, ByVal valor2, ByVal valor3)
        Return (division(valor1, valor2) / valor3)
    End Function


End Module


