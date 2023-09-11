Public Class Cliente
    Public Property Rut As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Deuda As Integer

    Public Sub New(rut As String, nombre As String, apellido As String, deuda As Integer)
        Me.Rut = rut ' me indica que "rut" es de la clase.
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Deuda = deuda
    End Sub
    Public Sub New()

    End Sub
End Class
