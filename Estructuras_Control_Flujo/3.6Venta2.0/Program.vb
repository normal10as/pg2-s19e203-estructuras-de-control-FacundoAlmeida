Module Program
    Sub Main(args As String())
        Dim precio_unitario, subtotal, total, descuento, cantidad As Single
        Console.WriteLine("Ingrese precio del producto: ")
        precio_unitario = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad a comprar: ")
        cantidad = Console.ReadLine()

        Select Case cantidad
            Case < 10
                Console.WriteLine("Su compra no aplica descuentos.")
                subtotal = precio_unitario * cantidad
                descuento = 0
                total = subtotal
            Case 10 To 51
                Console.WriteLine("Su compra aplica 5% de descuento.")
                subtotal = precio_unitario * cantidad
                descuento = subtotal * 0.05
                total = subtotal - descuento
            Case 50 To 251
                Console.WriteLine("Su compra aplica 10% de descuento.")
                subtotal = precio_unitario * cantidad
                descuento = subtotal * 0.1
                total = subtotal - descuento
            Case > 250
                Console.WriteLine("Su compra aplica 20% de descuento.")
                subtotal = precio_unitario * cantidad
                descuento = subtotal * 0.2
                total = subtotal - descuento

        End Select
        Console.WriteLine("Facutra: ")
        Console.WriteLine("Subtotal $" & subtotal)
        Console.WriteLine("Descuento -" & descuento)
        Console.WriteLine("Total a pagar $" & total)




    End Sub
End Module
