Public Class ScheduleControlHorario

    Dim controlador As IControlador
    Dim acceso = New Acceso()

    Private Sub ScheduleControlHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)
        controlador.CrearHorario().CrearComboBox("JORDI", cmb_cursos)

    End Sub

End Class
