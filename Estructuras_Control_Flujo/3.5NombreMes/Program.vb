Imports System

Module Program
    Sub Main(args As String())
        Dim mes As UShort
        Console.WriteLine("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case 1
                Console.WriteLine("El mes ingresado es enero.")
            Case 2
                Console.WriteLine("El mes ingresado es febrero.")
            Case 3
                Console.WriteLine("El mes ingresado es marzo.")
            Case 4
                Console.WriteLine("El mes ingresado es abril.")
            Case 5
                Console.WriteLine("El mes ingresado es mayo.")
            Case 6
                Console.WriteLine("El mes ingresado es junio.")
            Case 7
                Console.WriteLine("El mes ingresado es julio.")
            Case 8
                Console.WriteLine("El mes ingresado es agosto.")
            Case 9
                Console.WriteLine("El mes ingresado es septiembre.")
            Case 10
                Console.WriteLine("El mes ingresado es octubre.")
            Case 11
                Console.WriteLine("El mes ingresado es noviembre.")
            Case 12
                Console.WriteLine("El mes ingresado es diciembre.")
            Case > 12
                Console.WriteLine("El mes ingresado es incorrecto.")
        End Select

    End Sub
End Module
