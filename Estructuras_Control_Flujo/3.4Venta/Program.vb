Imports System
Module Program
    Sub Main(args As String())
        Dim cantidad, precio_unitario, descuento, total, subtotal As Single
        Console.WriteLine("Venta")

        Console.WriteLine("Ingrese precio de un producto: ")
        precio_unitario = Console.ReadLine()
        Console.WriteLine("Ingrese Cantidad a comprar: ")
        cantidad = Console.ReadLine()

        If cantidad > 9 And cantidad < 51 Then
            Console.WriteLine("El compra aplica 5% de descuento.")
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.05
            total = subtotal - descuento

        End If
        If cantidad > 50 And cantidad < 251 Then
            Console.WriteLine("Su compra aplica 10% de descuento.")
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.1
            total = subtotal - descuento

        End If
        If cantidad > 250 Then
            Console.WriteLine("Su compra aplica 20% de descuento.")
            subtotal = precio_unitario * cantidad
            descuento = subtotal * 0.2
            total = subtotal - descuento

        ElseIf cantidad < 10 Then
            Console.WriteLine("No existen descuentos a su compra.")
            subtotal = precio_unitario * cantidad
            descuento = 0
            total = subtotal



        End If

        Console.WriteLine("Facutra: ")
        Console.WriteLine("Subtotal:" & subtotal)
        Console.WriteLine("Descuento -" & descuento)
        Console.WriteLine("Total a pagar $" & total)
    End Sub
End Module
