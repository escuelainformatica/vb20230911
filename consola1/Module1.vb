Imports System.Linq.Expressions

Module Module1

    Sub Main()
        ' este es un comentario dfsoidfsioodsfodfsodfs
        ' visual basic 
        ' 1) un comentario se escriba partiendo con una comilla simple
        ' 2) las mayusculas y minusculas no cuenta.
        ' 3) una variable: es un espacio de memoria.
        Dim numero As Integer = 10 ' la variable se llama numero, es del tipo entero y tiene el valor 10
        Dim numero2 As Integer = 20
        Dim variabledecimal As Decimal = 20.4
        Dim texto As String = "hola mundo"
        Dim booleano As Boolean = True ' true o false
        ' 4) definir una variable:
        Dim v1 As Integer = 3
        Dim v2 As Integer
        v2 = 3 ' cambiar el valor
        ' 5) definiendo un arreglo: (un listado de valores)
        Dim arreglo(3) As Integer
        arreglo(0) = 1
        arreglo(1) = 10
        arreglo(2) = 20
        arreglo(3) = 20
        Debug.WriteLine(arreglo)
        Dim paises(3) As String
        paises(0) = "Chile"
        paises(1) = "Argentina"
        paises(2) = "Peru"
        paises(3) = "Bolivia"
        ReDim Preserve paises(4) ' redimensionar no deberian ocuparse.
        paises(4) = "Colombia"
        ' 6) listados
        Dim listapaises As New List(Of String)
        listapaises.Add("Chile")
        listapaises.Add("Argentina")
        ' 7) definir una tabla de valores
        ' nombre | precio
        ' ------------------
        ' cocacola | 1000
        ' fanta    | 200
        Dim nombreproductos As New List(Of String)
        nombreproductos.Add("cocacola")
        nombreproductos.Add("fanta")
        Dim productos As New List(Of Producto)
        productos.Add(New Producto() With {.Nombre = "cocacola", .Precio = 1000})
        productos.Add(New Producto() With {.Nombre = "fanta", .Precio = 200})
        ' 8) crear un producto
        Dim cocacola As New Producto() With {.Nombre = "cocacola", .Precio = 1000}
        Dim fanta As New Producto()
        fanta.Nombre = "fanta"
        fanta.Precio = 200

        'Console.WriteLine(numero)
        Debug.WriteLine(numero + numero2)
        Debug.WriteLine(Integer.Parse("10") + Integer.Parse("20"))

        ' ejemplo cliente
        ' una variable que se define por una clase se llama OBJETO.
        ' una variable que se define por un valor basico (entero, string, etc.) se llama VARIABLE PRIMITIVA
        ' un objeto se tiene que crear un espacio de memoria (comando new).
        ' una variable primitiva no se define un espacio adicional (no se usa comando new)
        Dim john As New Cliente()
        john.nombre = "john"
        john.apellido = "doe"
        john.edad = 33
        john.correo = "john.doe@correo.com"
        john.agregar()
        john.eliminar()
        Dim calculo As Integer = john.calcularDeuda()
        Dim aa As New clase2()

    End Sub

End Module
Public Class clase2

End Class
