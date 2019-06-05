Imports System

Module Program
    Sub Main(args As String())
        Dim precio_unitario, monto_descontado As Single
        Dim descuento, subtotal, total As Single
        Dim cantidad, desc_aplicado As Int16

        Console.WriteLine("Ingrese Cantidad a llevar. ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese precio unitario. ")
        precio_unitario = Console.ReadLine()

        If (cantidad < 10) Then
            Console.WriteLine("El producto no aplica descuento.")
            subtotal = precio_unitario * cantidad
            desc_aplicado = 0
            monto_descontado = 0

        ElseIf (cantidad > 9 And cantidad < 51) Then
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.05
            total = subtotal - descuento
            desc_aplicado = 5
            monto_descontado = subtotal - total

        ElseIf (cantidad > 50 And cantidad < 251) Then
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.1
            total = subtotal - descuento
            desc_aplicado = 10
            monto_descontado = subtotal - total

        ElseIf (cantidad > 250) Then
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.2
            total = subtotal - descuento
            desc_aplicado = 20
            monto_descontado = subtotal - total
        End If
        Console.WriteLine("Factura: ")
        Console.WriteLine("Subtotal: $" & subtotal)
        Console.WriteLine("Descuento Aplicado:" & desc_aplicado & "%")
        Console.WriteLine("Monto Descontado: $" & monto_descontado)
        Console.WriteLine("Total a pagar: $" & total)





    End Sub
End Module
