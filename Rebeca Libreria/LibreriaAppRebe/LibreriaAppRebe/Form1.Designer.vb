<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblEstado = New Label()
        lblVerificarEstado = New Label()
        btnVerificar = New Button()
        btnDevolver = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.BackColor = Color.IndianRed
        lblEstado.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(305, 372)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(147, 26)
        lblEstado.TabIndex = 0
        lblEstado.Text = "Estado del Libro"
        ' 
        ' lblVerificarEstado
        ' 
        lblVerificarEstado.AutoSize = True
        lblVerificarEstado.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVerificarEstado.Location = New Point(242, 100)
        lblVerificarEstado.Name = "lblVerificarEstado"
        lblVerificarEstado.Size = New Size(294, 33)
        lblVerificarEstado.TabIndex = 1
        lblVerificarEstado.Text = "Está disponible el Libro?"
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerificar.Location = New Point(130, 262)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(143, 50)
        btnVerificar.TabIndex = 2
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' btnDevolver
        ' 
        btnDevolver.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDevolver.Location = New Point(505, 262)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(146, 50)
        btnDevolver.TabIndex = 3
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(287, 170)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 42)
        TextBox1.TabIndex = 4
        TextBox1.Text = "Ingrese el Libro"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(254, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 47)
        Label1.TabIndex = 5
        Label1.Text = "Biblioteca Virtual"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._84e35a21_c16b_4523_abf9_f173520cda541
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(btnDevolver)
        Controls.Add(btnVerificar)
        Controls.Add(lblVerificarEstado)
        Controls.Add(lblEstado)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEstado As Label
    Friend WithEvents lblVerificarEstado As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label

End Class
