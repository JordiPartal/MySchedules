Public Class UpdateProgress

    Dim datos As New DataTable
    Dim acceso = New Acceso()
    Dim controlador As IControlador

    Private _curso As String
    Public Property curso As String
        Get
            Return _curso
        End Get
        Set(ByVal value As String)
            _curso = value
        End Set
    End Property

    Private Sub UpdateProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)
        datos = controlador.CrearCurso().Seleccionar("JORDI", curso)
        txt_tu_progreso.Text = datos(0)("Progreso")

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        controlador = acceso.Crear(Enumeracion.Fabrica)
        controlador.CrearCurso().ActualizarProgreso("JORDI", curso, txt_tu_progreso)
        MyBase.Close()

    End Sub

End Class