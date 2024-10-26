Public Class Form1
    Private libro As Libro

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Creamos una instancia de Libro al cargar el formulario
        libro = New Libro("Cien años de soledad", "Gabriel García Márquez", False)
    End Sub
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim mensaje As String = libro.VerificarDisponibilidad()
        lblEstado.Text = mensaje
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        libro.DevolverLibro()
        lblEstado.Text = "Has devuelto el libro. Ahora está disponible."
        Dim form2 As New Form2()
        form2.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblEstado_Click(sender As Object, e As EventArgs) Handles lblEstado.Click

    End Sub
End Class
