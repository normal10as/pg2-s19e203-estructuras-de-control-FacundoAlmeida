Imports System

Module Program
    Sub Main(args As String())
        Dim valor_1 As Integer
        Dim Acumulador_Par, Acumulador_Impar As Int16

        Do
            Console.WriteLine("Ingresa valor: (0 para salir)")
            valor_1 = Console.ReadLine
            If (valor_1 Mod 2) = 0 Then
                Acumulador_Par = Acumulador_Par + 1
            Else
                Acumulador_Impar = Acumulador_Impar + 1
            End If

        Loop While (valor_1 <> 0)
        Console.WriteLine("La cantidad de Numeros pares es de " & Acumulador_Par - 1)
        Console.WriteLine("La cantidad de numeros impares es de " & Acumulador_Impar)




    End Sub
    Function IngresarValor()
        Dim valor As Integer
        Console.WriteLine("Ingrese un valor: ")
        valor = Console.ReadLine()
    End Function
End Module
