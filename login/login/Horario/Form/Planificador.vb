Public Class Planificador

    Dim acceso = New Acceso()
    Dim curso = String.Empty

    Dim fecha As New Date
    Dim datos As DataTable
    Dim controlador As IControlador


    Private Sub Planificador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fecha = Today
        Dim is_monday = fecha.DayOfWeek = 1

        controlador = acceso.Crear(Enumeracion.Fabrica)

        cmb_dias.Text = "-- SELECCIONA UN DIA --"
        cmb_curso.Text = "-- SELECCIONA UN CURSO --"

        controlador.CrearHorario().CrearComboBox(cmb_dias)
        controlador.CrearCurso().CrearComboBox(Globales.LOGIN, cmb_curso)

        btn_eliminar.Visible = False
        tlp_options.SetRow(btn_planificar, 4)

        If is_monday Then
            pic_new_week.Show()
        Else
            pic_new_week.Hide()
        End If

    End Sub

    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click

        Hide()
        ScheduleViewer.Show()

    End Sub

    Private Sub cmb_dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dias.SelectedIndexChanged

        controlador.CrearHorario().Seleccionar(Globales.LOGIN, curso, cmb_dias.Text, dtg_horario)

        If dtg_horario.Rows.Count > 0 Then
            btn_eliminar.Visible = True
            tlp_options.SetRow(btn_planificar, 3)
        Else
            btn_eliminar.Visible = False
            tlp_options.SetRow(btn_planificar, 4)
        End If

    End Sub

    Private Sub dtg_horario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_horario.CellClick

        cmb_curso.DataBindings.Clear()
        cmb_curso.DataBindings.Add("Text", dtg_horario.DataSource, "descripcion")

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        controlador.CrearCurso().EliminarCursoDePlanificacion(Globales.LOGIN, cmb_dias.Text, cmb_curso.Text)
        controlador.CrearHorario().Seleccionar(Globales.LOGIN, curso, cmb_dias.Text, dtg_horario)

    End Sub

    Private Sub btn_planificar_Click(sender As Object, e As EventArgs) Handles btn_planificar.Click

        controlador.CrearCurso().AnadirCursoEnPlanificacion(Globales.LOGIN, cmb_dias.Text, cmb_curso.Text)
        controlador.CrearHorario().Seleccionar(Globales.LOGIN, curso, cmb_dias.Text, dtg_horario)

    End Sub

    Private Sub pic_new_week_Click(sender As Object, e As EventArgs) Handles pic_new_week.Click

        controlador.CrearHorario().ReiniciarSemana(Globales.LOGIN)
        controlador.CrearHorario().Seleccionar(Globales.LOGIN, curso, cmb_dias.Text, dtg_horario)

    End Sub

End Class