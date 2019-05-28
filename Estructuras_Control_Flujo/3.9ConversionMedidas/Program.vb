Imports System
Module programa1
    Private pie, yarda, pulgada, metro, cm As Single
    Private conversion As Single
    Sub Main(args As String())
        Select Case Menu()
            Case 1
                Console.WriteLine("Eligio pie.")
                PreguntarMedida()
                conversion_pie(conversion)
            Case 2
                Console.WriteLine("Eligio pulgada")
                PreguntarMedida()
                conversion_pulgada(conversion)
            Case 3
                Console.WriteLine("Eligio yardas")
                PreguntarMedida()
                conversion_yardas(conversion)
            Case 4
                Console.WriteLine("Eligio metros")
                PreguntarMedida()
                conversion_metros(conversion)
            Case 5
                Console.WriteLine("Eligio centimetros")
                PreguntarMedida()
                conversion_centimetros(conversion)
        End Select
    End Sub
    Function PreguntarMedida() As Single
        Console.WriteLine("Ingrese numero a convertir: ")
        conversion = Console.ReadLine()
        Return conversion
    End Function
    Sub conversion_pie(conversion As Single)
        pulgada = conversion * 12
        yarda = conversion / 3
        cm = pulgada * 2.54
        metro = cm * 100
        Console.WriteLine("Resultado: ")
        Console.WriteLine(conversion & " pie, son " & pulgada & " pulgadas.")
        Console.WriteLine(conversion & " pie, son " & yarda & " yardas.")
        Console.WriteLine(conversion & " pie, son " & cm & " centimetros.")
        Console.WriteLine(conversion & " pie, son " & metro & " metros.")
    End Sub

    Sub conversion_pulgada(conversion As Single)
        pie = conversion / 12
        yarda = pie / 3
        cm = pulgada * 2.54
        metro = cm * 100
        Console.WriteLine("Resultado: ")
        Console.WriteLine(conversion & " pulgadas, son " & pie & " pies.")
        Console.WriteLine(conversion & " pulgadas, son " & yarda & " yardas.")
        Console.WriteLine(conversion & " pulgadas, son " & cm & " centimetros.")
        Console.WriteLine(conversion & " pulgadas, son " & metro & " metros.")

    End Sub
    Sub conversion_yardas(conversion)
        pie = conversion * 3
        pulgada = pie * 12
        cm = pulgada * 2.54
        metro = cm * 100
        Console.WriteLine("Resultado: ")
        Console.WriteLine(conversion & " yardas, son " & pie & " pies.")
        Console.WriteLine(conversion & " yardas, son " & pulgada & " pulgadas.")
        Console.WriteLine(conversion & " yardas, son " & cm & " centimetros.")
        Console.WriteLine(conversion & " yardas, son " & metro & " Metros.")

    End Sub

    Sub conversion_metros(conversion As Single)
        cm = conversion / 100
        pulgada = cm * 2.54
        pie = pulgada / 12
        yarda = pie / 3
        Console.WriteLine("Resultado: ")
        Console.WriteLine(conversion & " metros, son " & cm & " centimetros.")
        Console.WriteLine(conversion & " metros, son " & pulgada & " pulgadas.")
        Console.WriteLine(conversion & " metros, son " & pie & " pies.")
        Console.WriteLine(conversion & " metros, son " & yarda & " yarda.")

    End Sub
    Sub conversion_centimetros(conversion As Single)
        pulgada = conversion * 2.54
        pie = pulgada / 12
        yarda = pie / 3
        metro = cm * 100
        Console.WriteLine("Resultado: ")
        Console.WriteLine(conversion & " centimetros, son " & pulgada & " pulgadas.")
        Console.WriteLine(conversion & " centimetros, son " & pie & " pies.")
        Console.WriteLine(conversion & " centimetros, son " & yarda & " yardas.")
        Console.WriteLine(conversion & " centimetros, son " & metro & " metros.")

    End Sub
    Function Menu()
        Dim numero As Single
        Console.WriteLine("Ingrese que desea convertir: ")
        Console.WriteLine("1.Pie")
        Console.WriteLine("2.Pulgada")
        Console.WriteLine("3.Yarda")
        Console.WriteLine("4.Metro")
        Console.WriteLine("5.Centimetro")
        Console.Write("-->")
        numero = Console.ReadLine()
        Return numero
    End Function

End Module