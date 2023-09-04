Public Class ScheduleControlCurso

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
            Cursos = dtg_usuario

            If _cabecera = "Cursos" Then
                controlador = acceso.Crear(Enumeracion.Fabrica)
                controlador.CrearHorario().Seleccionar("JORDI", dtg_usuario)
            End If

        End Set

    End Property

End Class
