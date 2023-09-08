﻿Public Class Planificador

    Dim acceso = New Acceso()

    Dim datos As DataTable
    Dim controlador As IControlador

    Private Sub Planificador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)

        cmb_dias.Text = "-- SELECCIONA UN DIA --"
        cmb_curso.Text = "-- SELECCIONA UN CURSO --"

        controlador.CrearHorario().CrearComboBox(cmb_dias)
        controlador.CrearCurso().CrearComboBox("JORDI", cmb_curso)

        btn_eliminar.Visible = False
        tlp_options.SetRow(btn_planificar, 4)

    End Sub

    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click

        Hide()
        ScheduleViewer.Show()

    End Sub

    Private Sub cmb_dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dias.SelectedIndexChanged

        Dim curso = String.Empty
        controlador.CrearHorario().Seleccionar("JORDI", curso, cmb_dias.Text, dtg_horario)

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

        controlador.CrearCurso().EliminarCursoDePlanificacion("JORDI", cmb_dias.Text, cmb_curso.Text)

    End Sub

    Private Sub btn_planificar_Click(sender As Object, e As EventArgs) Handles btn_planificar.Click

        controlador.CrearCurso().AnadirCursoEnPlanificacion("JORDI", cmb_dias.Text, cmb_curso.Text)

    End Sub
End Class