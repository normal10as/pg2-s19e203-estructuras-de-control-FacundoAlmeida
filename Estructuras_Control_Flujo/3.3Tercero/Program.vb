Imports System

Module Program
    Sub Main(args As String())
        Dim valor1, valor2, valor3, valor4, valor5 As Single
        Console.WriteLine("Ingrese 5 valores y mostrare el mayor, por orden de ingreso. ")
        Console.WriteLine("Ingrese valor 1: ")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingrese valor 2: ")
        valor2 = Console.ReadLine()
        Console.WriteLine("Ingrese valor 3: ")
        valor3 = Console.ReadLine()
        Console.WriteLine("Ingrese valor 4: ")
        valor4 = Console.ReadLine()
        Console.WriteLine("Ingrese valor 5: ")
        valor5 = Console.ReadLine()
        If valor1 > valor2 And valor1 > valor3 And valor1 > valor4 And valor1 > valor5 Then
            Console.WriteLine("El mayor es el primero.")
        ElseIf valor2 > valor1 And valor2 > valor3 And valor2 > valor4 And valor2 > valor5 Then
            Console.WriteLine("El mayor es el segundo.")
        ElseIf valor3 > valor1 And valor3 > valor2 And valor3 > valor4 And valor3 > valor5 Then
            Console.WriteLine("El mayor es el tercero.")
        ElseIf valor4 > valor1 And valor4 > valor2 And valor4 > valor3 And valor4 > valor5 Then
            Console.WriteLine("El mayor es el cuarto.")
        ElseIf valor5 > valor1 And valor5 > valor2 And valor5 > valor3 And valor5 > valor4 Then
            Console.WriteLine("El mayor es el quinto.")
        Else
            Console.WriteLine("Todos los numeros son iguales.")
        End If
    End Sub
End Module
