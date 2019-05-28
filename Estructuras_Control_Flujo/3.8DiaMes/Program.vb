Imports System

Module Program
    Sub Main(args As String())
        Dim mes As Byte
        Dim anio As UShort
        Console.WriteLine("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case 1
                Console.WriteLine("El mes tiene 31 dias")
            Case 2
                Console.WriteLine("Eligio Febrero, indique el año para sacar el resultado.")
                anio = Console.ReadLine()
                If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
                    Console.WriteLine("El año tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
            Case 3
                Console.WriteLine("el mes tiene 31 dias")
            Case 4
                Console.WriteLine("El mes tiene 30 dias")
            Case 5
                Console.WriteLine("el mes tiene 31 dias")
            Case 6
                Console.WriteLine("el mes tiene 30 dias")
            Case 7
                Console.WriteLine("el mes tiene 31 dias")
            Case 8
                Console.WriteLine("el mes tiene 30 dias")
            Case 9
                Console.WriteLine("el mes tiene 31 dias")
            Case 10
                Console.WriteLine("el mes tiene 30 dias")
            Case 11
                Console.WriteLine("el mes tiene 31 dias")
            Case 12
                Console.WriteLine("el mes tiene 31 dias")
            Case Else
                Console.WriteLine("mes incorrecto.")
        End Select

    End Sub
End Module









