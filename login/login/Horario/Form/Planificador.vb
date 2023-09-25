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

        cmb_horario.Text = "-- SELECCIONA UNA HORA --"
        cmb_curso.Text = "-- SELECCIONA UN CURSO --"

        controlador.CrearHorario().MostrarDia(fecha.DayOfWeek, lbl_planificador)
        controlador.CrearHorario().CrearComboBoxHora(cmb_horario)
        controlador.CrearHorario().MostrarHorario(Globales.LOGIN, fecha.DayOfWeek, dtg_horario)

        controlador.CrearCurso().CrearComboBox(Globales.LOGIN, cmb_curso)

        btn_eliminar.Visible = False
        tlp_options.SetRow(btn_planificar, 5)

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

    Private Sub cmb_dias_SelectedIndexChanged(sender As Object, e As EventArgs)

        If dtg_horario.Rows.Count > 0 Then
            btn_eliminar.Visible = True
            tlp_options.SetRow(btn_planificar, 4)
            tlp_options.SetColumn(btn_planificar, 1)
        Else
            btn_eliminar.Visible = False
            tlp_options.SetRow(btn_planificar, 5)
            tlp_options.SetColumn(btn_planificar, 1)
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btn_planificar_Click(sender As Object, e As EventArgs) Handles btn_planificar.Click

        controlador.CrearHorario().PlanificarDia(Globales.LOGIN, fecha.DayOfWeek, cmb_horario.SelectedItem, cmb_curso.SelectedItem, dtg_horario)
        controlador.CrearHorario().MostrarHorario(Globales.LOGIN, fecha.DayOfWeek, dtg_horario)

    End Sub

    Private Sub pic_new_week_Click(sender As Object, e As EventArgs) Handles pic_new_week.Click

        controlador.CrearHorario().ReiniciarSemana(Globales.LOGIN)
        controlador.CrearHorario().MostrarHorario(Globales.LOGIN, fecha.DayOfWeek, dtg_horario)

    End Sub

End Class