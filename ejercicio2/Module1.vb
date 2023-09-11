Module Module1
    Dim total2 As Integer = 300 ' global
    Sub ejemplo()
        Dim total As Integer = 200 ' variable local
        Debug.WriteLine(total2)
    End Sub
    Sub ejemplo2()
        Debug.WriteLine(total2)
    End Sub
    Sub ejemplo3()
        Dim texto = "hola mundo"
        Dim total2 As Integer = 2123123123 ' entero largo.
        Dim total3 = 2123212321
        Dim vardecimal = 0.19
        Dim variable2 As Object
        texto = 22
        total2 = "hhhh"



    End Sub

    Sub Main()
        Dim v1 As Object ' variant.
        v1 = "hola"
        v1 = 20
        Dim v2 As Integer
        v2 = "hola"




        Console.WriteLine("Hello, world!")
        Dim total As Integer = 100
        Dim iva As Decimal = 0.19
        Dim nombre As String = "John Doe"
        Dim colores(3) As String
        colores(0) = "rojo"
        colores(1) = "amarillo"
        colores(2) = "verde"
        colores(3) = "azul"
        Dim listacolores As New List(Of String)
        listacolores.Add("rojo")
        listacolores.Add("amarillo")
        listacolores.Add("verde")
        listacolores.Add("azul")

        Dim p1 As New Producto()

        Dim productos As New List(Of Producto)
        productos.Add(New Producto() With {.Nombre = "produc1", .Precio = 55, .Cantidad = 55})
        productos.Add(p1)
        Dim p2 As New Producto()
        p2.Nombre = "produc2"
        p2.Precio = 663
        p2.Cantidad = 6666
        productos.Add(p2)
    End Sub

End Module
Public Class Producto
    Public Property Nombre As String
    Public Property Precio As Integer
    Public Property Cantidad As Integer
End Class