Imports System

Module Program
    Private valor_1, valor_2
    Sub Main(args As String())
        Dim valor_1, valor_2, valor_1copia, valor_1copia3, valor_1copia2, Cantidad_Multiplos As UShort
        valor_1 = ValoresIngresados()
        valor_2 = ValoresIngresados()
        valor_1copia = valor_1
        valor_1copia2 = valor_1
        valor_1copia3 = valor_1



        '-----------------------------------------------------
        For i As UShort = valor_1 To valor_2
            If (i Mod 5) = 0 Then
                Cantidad_Multiplos = Cantidad_Multiplos + 1
            End If
        Next
        Console.WriteLine("Con For:")
        Console.WriteLine("La cantidad de multiplos es de: " & Cantidad_Multiplos)
        Cantidad_Multiplos = 0

        ''----------------------------------------------------------------------
        Do While (valor_1 <= valor_2)
            If (valor_1 Mod 5) = 0 Then
                Cantidad_Multiplos = Cantidad_Multiplos + 1
            End If
            valor_1 = valor_1 + 1
        Loop
        Console.WriteLine("Con Do While:")
        Console.WriteLine("La cantidad de multiplos es de " & Cantidad_Multiplos)
        Cantidad_Multiplos = 0
        '---------------------------------------------------------------------------

        Do Until (valor_1copia > valor_2)
            If (valor_1copia Mod 5) = 0 Then
                Cantidad_Multiplos = Cantidad_Multiplos + 1
            End If
            valor_1copia = valor_1copia + 1
        Loop
        Console.WriteLine("Con Do Until:")
        Console.WriteLine("La cantidad de multiplos es de " & Cantidad_Multiplos)
        Cantidad_Multiplos = 0
        '--------------------------------------------------------------------------

        Do
            If (valor_1copia2 Mod 5) = 0 Then
                Cantidad_Multiplos = Cantidad_Multiplos + 1
            End If
            valor_1copia2 = valor_1copia2 + 1
        Loop While (valor_1copia2 < valor_2)
        Console.WriteLine("Con Do Loop While")
        Console.WriteLine("La cantidad de multiplos es de " & Cantidad_Multiplos)
        Cantidad_Multiplos = 0
        '---------------------------------------------------------------------------
        ' valor_1 = ValoresIngresados()
        'valor_2 = ValoresIngresados()
        Do
            If (valor_1copia3 Mod 5) = 0 Then
                Cantidad_Multiplos = Cantidad_Multiplos + 1
            End If
            valor_1copia3 = valor_1copia3 + 1
        Loop Until (valor_1copia3 > valor_2)
        Console.WriteLine("Con Do Loop Until: ")
        Console.WriteLine("La cantidad de multiplos es de " & Cantidad_Multiplos)
    End Sub

    Function ValoresIngresados()
        Dim valor As UShort
        Console.WriteLine("Ingrese un valor: ")
        valor = Console.ReadLine()
        Return valor
    End Function
End Module
