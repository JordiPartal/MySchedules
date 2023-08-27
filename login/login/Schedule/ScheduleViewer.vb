Public Class ScheduleViewer
    Private Sub ScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sch_control.cabecera = "Qué quieres mirar?"
    End Sub

    Private Sub pic_cursos_Click(sender As Object, e As EventArgs) Handles pic_cursos.Click
        sch_control.cabecera = "Cursos"
    End Sub

    Private Sub pic_calendario_Click(sender As Object, e As EventArgs) Handles pic_calendario.Click
        sch_control.cabecera = "Programación"
    End Sub
End Class