Public Class ScheduleControlHorario

    Dim controlador As IControlador
    Dim acceso = New Acceso()

    Private Sub ScheduleControlHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)
        controlador.CrearHorario().CrearComboBox("JORDI", cmb_cursos)

    End Sub

    Private Sub cmb_cursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cursos.SelectedIndexChanged

        Dim datos As DataTable

        lbl_titulo.Text = cmb_cursos.SelectedItem
        controlador = acceso.Crear(Enumeracion.Fabrica)

        datos = controlador.CrearCurso().Seleccionar("JORDI", lbl_titulo.Text)

        lbl_autor.Text = $"Tu progreso es de: {datos(0)("Progreso")}"
        lbl_progreso.Text = $"creado por {datos(0)("Autor")}"

    End Sub
End Class
