Imports System

Module Program
    Enum Meses
        enero = 1
        febrero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre
    End Enum
    Sub Main(args As String())

        Dim mes As UShort
        Console.WriteLine("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case Meses.enero
                Console.WriteLine("El mes ingresado es enero.")
            Case Meses.febrero
                Console.WriteLine("El mes ingresado es febrero.")
            Case Meses.marzo
                Console.WriteLine("El mes ingresado es marzo.")
            Case Meses.abril
                Console.WriteLine("El mes ingresado es abril.")
            Case Meses.mayo
                Console.WriteLine("El mes ingresado es mayo.")
            Case Meses.junio
                Console.WriteLine("El mes ingresado es junio.")
            Case Meses.julio
                Console.WriteLine("El mes ingresado es julio.")
            Case Meses.agosto
                Console.WriteLine("El mes ingresado es agosto.")
            Case Meses.septiembre
                Console.WriteLine("El mes ingresado es septiembre.")
            Case Meses.octubre
                Console.WriteLine("El mes ingresado es octubre.")
            Case Meses.noviembre
                Console.WriteLine("El mes ingresado es noviembre.")
            Case Meses.Diciembre
                Console.WriteLine("El mes ingresado es diciembre.")
            Case > 12
                Console.WriteLine("El mes ingresado es incorrecto.")
        End Select

    End Sub
End Module
