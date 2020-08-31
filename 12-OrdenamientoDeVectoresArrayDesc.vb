﻿'Cargar un vector con 10 números enteros y luego ordenarlo de menor a mayor.
'Imprimir el vector ordenado.
Module OrdenamientoDeVectoresArrayDesc
    Sub Main()
        Dim vec(9) As Integer
        Console.WriteLine("Carga del Vector")
        Console.WriteLine()
        For i = 0 To UBound(vec)
            Console.Write("Ingrese en elemento {0} un nro: ", i)
            vec(i) = CInt(Console.ReadLine)
        Next
        'ordenando utilizando la clase Array
        Array.Sort(vec) 'ordena el vector de menor a mayor
        Array.Reverse(vec) 'invierte el vector
        Console.WriteLine()
        Console.WriteLine("mostrando Vector")
        Console.WriteLine()
        For i = 0 To 9
            Console.WriteLine("Elemento {0} valor: {1}", i, vec(i))
        Next
        Console.ReadLine()
    End Sub
End Module