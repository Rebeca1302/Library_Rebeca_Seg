Public Class Libro
    ' Atributos
    Private _titulo As String
    Private _autor As String
    Private _disponible As Boolean

    ' Constructor
    Public Sub New(titulo As String, autor As String, disponible As Boolean)
        _titulo = titulo
        _autor = autor
        _disponible = disponible
    End Sub

    ' Propiedades
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property Autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            _autor = value
        End Set
    End Property

    Public Property Disponible As Boolean
        Get
            Return _disponible
        End Get
        Set(value As Boolean)
            _disponible = value
        End Set
    End Property

    ' Métodos
    Public Function VerificarDisponibilidad() As String
        If _disponible Then
            Return "El libro está disponible."
        Else
            Return "El libro no está disponible."
        End If
    End Function

    Public Sub DevolverLibro()
        _disponible = True
    End Sub
End Class
