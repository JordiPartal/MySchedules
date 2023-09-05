Imports Azure.Core.HttpHeader

Public Class ScheduleControlHorario

    Dim controlador As IControlador
    Dim acceso = New Acceso()

    Private Sub ScheduleControlHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)
        controlador.CrearCurso().CrearComboBox("JORDI", cmb_cursos)
        controlador.CrearHorario().CrearComboBox(cmb_dias)

    End Sub

    Private Sub cmb_dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dias.SelectedIndexChanged

        Dim curso As String = String.Empty

        cmb_cursos.Text = "-- SELECCIONA UN CURSO --"
        controlador.CrearHorario().Seleccionar("JORDI", curso, cmb_dias.Text, dtg_horario)

    End Sub

    Private Sub cmb_cursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cursos.SelectedIndexChanged

        Dim datos As DataTable
        Dim dias As String = String.Empty

        lbl_titulo.Text = cmb_cursos.SelectedItem
        controlador = acceso.Crear(Enumeracion.Fabrica)
        cmb_dias.Text = "-- SELECCIONA UN DIA --"

        datos = controlador.CrearCurso().Seleccionar("JORDI", lbl_titulo.Text)
        controlador.CrearHorario().Seleccionar("JORDI", cmb_cursos.Text, dias, dtg_horario)

        lbl_autor.Text = $"Tu progreso es de: {datos(0)("Progreso")}"
        lbl_progreso.Text = $"creado por {datos(0)("Autor")}"

    End Sub

End Class
