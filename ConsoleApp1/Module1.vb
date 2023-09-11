Module Module1

    Sub Main()
        ' crear una instancia (una variable que usa la clase de modelo producto)
        ' primera forma
        Dim cocacola As New Producto()
        cocacola.nombre = "cocacola"
        cocacola.precio = 2000

        Debug.WriteLine(cocacola.nombre)
        Debug.WriteLine(cocacola.precio)
        ' segunda forma
        Dim cocacola2 As New Producto() With {.nombre = "cocacola", .precio = 2000}
        ' nothing (no tiene valor)
        Dim cocacola3 As Producto()
        ' tercera forma
        Dim cocacola4 As New Producto("cocacola", 2000)
        ' lista de productos
        Dim productos As New List(Of Producto)
        productos.Add(cocacola)
        productos.Add(cocacola2)
        productos.Add(cocacola4)
        productos.Add(New Producto("fanta", 500))
        productos.Add(New Producto() With {.nombre = "sprite", .precio = 500})
        ' ciclo
        Debug.WriteLine("---- ciclo #1 -----------")
        For i As Integer = 0 To 3 ' 0,1,2,3
            Debug.WriteLine(i)
        Next
        For i As Integer = 3 To 0 Step -1 ' 3,2,1,0
            Debug.WriteLine(i)
        Next
        For i As Integer = 0 To productos.Count - 1 ' 0,1,2,3,4
            Debug.WriteLine(productos(i).nombre & " " & productos(i).precio) ' el producto en la fila "i" y el campo nombre
        Next
        ' ciclo #2
        Debug.WriteLine("---- ciclo #2 -----------")
        For Each fila As Producto In productos
            Debug.WriteLine(fila.nombre & " " & fila.precio)
        Next
        ' ciclo #3
        Debug.WriteLine("---- ciclo #3 -----------")
        ' para que necesito el ciclo while? solamente cuando no se la cantidad de datos a leer.
        Dim contador As Integer = 0
        While contador < 4 ' el que no queremos ocupar
            Debug.WriteLine(contador)
            contador = contador + 1
        End While
        ' ejercicio cliente
        Debug.WriteLine("ejercicio lista cliente")
        Dim clientes As New List(Of Cliente)
        clientes.Add(New Cliente("1111-1", "john", "doe", 0))
        clientes.Add(New Cliente("3333-3", "anna", "smith", 100))
        clientes.Add(New Cliente("4444-4", "bob", "s", 50))
        For Each fila As Cliente In clientes
            Debug.WriteLine(fila.Rut & " " & fila.Nombre & " " &
                            fila.Apellido & " " & fila.Deuda)
            Debug.WriteLine($"rut:{fila.Rut}, nombre:{fila.Nombre}, apellido:{fila.Apellido}, deuda:{fila.Deuda}")
        Next
        Debug.WriteLine("ejercicio venta")
        Dim venta As New Venta() With {
            .Cantidad = 100,
            .Producto = New Producto("cocacola", 1500),
            .Cliente = New Cliente("2222-2", "john", "doe", 3000)
            }
        Dim ventas As New List(Of Venta)
        ventas.Add(venta)
        ventas.Add(New Venta() With {
            .Cantidad = 200,
            .Producto = New Producto("fanta", 2000),
            .Cliente = New Cliente("2222-2", "anna", "smith", 2000)
            }
            )
        For Each fila As Venta In ventas
            Debug.WriteLine($"{fila.Cantidad} {fila.Cliente.Nombre} {fila.Producto.nombre}")
        Next

    End Sub

End Module
