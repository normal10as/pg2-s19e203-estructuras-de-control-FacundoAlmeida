Imports System

Module Program
    Sub Main(args As String())
        Dim angulo As Single
        Console.WriteLine("Ingrese Grado del angulo: ")
        angulo = Console.ReadLine()
        Select Case angulo
            Case < 90
                Console.WriteLine("Su angulo es Agudo.")
            Case 90
                Console.WriteLine("Su angulo es Recto.")
            Case 91 To 179
                Console.WriteLine("Su angulo es Concavo.")
            Case 180
                Console.WriteLine("Su angulo es Llano.")
            Case 181 To 360
                Console.WriteLine("Su angulo es Concavo")
            Case < 1
                Console.WriteLine("Error!")
            Case > 360
                Console.WriteLine("Error!")

        End Select
    End Sub
End Module
