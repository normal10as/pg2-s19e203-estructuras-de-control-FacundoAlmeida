Imports System

Module Program
    Sub Main(args As String())
        Dim NroPrimo As Integer = 0
        Dim num As Integer = 80
        Console.WriteLine("Numeros primos: ")
        For i As Integer = 2 To 1000
            For j As Integer = 1 To 1000
                If (i Mod j) = 0 Then
                    NroPrimo = NroPrimo + 1
                End If
            Next
            If (NroPrimo = 2) Then
                Console.WriteLine(i)
            End If
            NroPrimo = 0
        Next

    End Sub
End Module

