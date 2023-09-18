Public Class CCCurso

    Dim controlador As IControlador
    Dim acceso = New Acceso()

    Private _cabecera As String

    Property cabecera As String
        Get
            Return _cabecera
        End Get
        Set(value As String)
            _cabecera = value
            lbl_cabecera.Text = _cabecera

            If _cabecera = "Cursos" Then
                controlador = acceso.Crear(Enumeracion.Fabrica)
                controlador.CrearHorario().Seleccionar(Globales.LOGIN, dtg_usuario)
            End If
        End Set
    End Property

    Private Sub pic_week_Click(sender As Object, e As EventArgs) Handles pic_week.Click

        ScheduleViewer.Hide()
        Planificador.Show()

    End Sub

End Class
