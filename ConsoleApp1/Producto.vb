' una clase de modelo.
' es una clase que sirve como definicion de variable.
Public Class Producto

    ' constructor (es una subrutina con el nombre new)
    Public Sub New(nom As String, pre As Integer)
        nombre = nom
        precio = pre
    End Sub
    Public Sub New()

    End Sub
    Public Property nombre As String
    Public Property precio As Integer
End Class
