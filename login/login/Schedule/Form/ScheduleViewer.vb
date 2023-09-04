Public Class ScheduleViewer
    Dim sch_horario As ScheduleControlHorario

    Private Sub ScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sch_curso.cabecera = "Qué quieres hacer?"
    End Sub

    Private Sub pic_cursos_Click(sender As Object, e As EventArgs) Handles pic_cursos.Click
        sch_curso.cabecera = "Cursos"

        tbl_custom_control.Controls.Clear()
        tbl_custom_control.Controls.Add(sch_curso)
    End Sub

    Private Sub pic_calendario_Click(sender As Object, e As EventArgs) Handles pic_calendario.Click
        sch_horario = New ScheduleControlHorario()

        tbl_custom_control.Controls.Clear()
        tbl_custom_control.Controls.Add(sch_horario)
    End Sub
End Class