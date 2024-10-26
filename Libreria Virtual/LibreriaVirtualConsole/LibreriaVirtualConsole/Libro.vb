Public Class Libro
    Private _titulo As String
    Private _autor As String
    Private _isAvailable As Boolean

    ' Constructor
    Public Sub New(titulo As String, autor As String)
        _titulo = titulo
        _autor = autor
        _isAvailable = True ' Al inicio, el libro está disponible
    End Sub

    ' Métodos
    Public Function Prestar() As String
        If _isAvailable Then
            _isAvailable = False
            Return "Libro prestado: " & _titulo
        Else
            Return "El libro '" & _titulo & "' no está disponible."
        End If
    End Function

    Public Function Devolver() As String
        If Not _isAvailable Then
            _isAvailable = True
            Return "Libro devuelto: " & _titulo
        Else
            Return "El libro '" & _titulo & "' ya estaba disponible."
        End If
    End Function

    ' Getters
    Public Function GetTitulo() As String
        Return _titulo
    End Function

    Public Function GetAutor() As String
        Return _autor
    End Function

    Public Function IsLibroDisponible() As Boolean
        Return _isAvailable
    End Function
End Class

