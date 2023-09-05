Imports Azure.Core.HttpHeader

Public Class ScheduleControlHorario

    Dim datos As DataTable
    Dim etiqueta As Label
    Dim controlador As IControlador

    Dim acceso = New Acceso()

    Private Sub ScheduleControlHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlador = acceso.Crear(Enumeracion.Fabrica)
        controlador.CrearCurso().CrearComboBox("JORDI", cmb_cursos)
        controlador.CrearHorario().CrearComboBox(cmb_dias)

    End Sub

    Private Sub cmb_dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dias.SelectedIndexChanged

        Dim curso = String.Empty

        cmb_cursos.Text = "-- SELECCIONA UN CURSO --"
        controlador.CrearHorario().Seleccionar("JORDI", curso, cmb_dias.Text, dtg_horario)

    End Sub

    Private Sub cmb_cursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cursos.SelectedIndexChanged

        ImportarDatosCurso(cmb_cursos.SelectedItem, datos)

    End Sub

    Private Sub dtg_horario_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_horario.SelectionChanged

        Dim cursos = cmb_dias.Text <> "-- SELECCIONA UN DIA --"
        Dim seleccionado = dtg_horario.CurrentRow.Selected <> False

        If cursos And seleccionado Then
            ImportarDatosCurso(dtg_horario.CurrentCell.Value)
        End If

    End Sub

    ''' <summary>
    ''' Muestra la informacion del curso en el Custom Control
    ''' </summary>
    ''' <param name="curso"></param>
    Sub ImportarDatosCurso(curso As String)

        Dim autores = ""

        etiqueta = New Label With {.Text = curso}
        ScheduleControlCursoInfo.curso = etiqueta.Text

        cmb_cursos.Text = "-- SELECCIONA UN CURSO --"
        datos = controlador.CrearCurso().Seleccionar("JORDI", etiqueta.Text)
        ScheduleControlCursoInfo.progreso = $"Tu progreso es de {datos(0)("Progreso")}"

        If datos.Rows.Count > 1 Then
            For Each item In datos.Rows
                Dim autor = item("Autor")
                autores += $"by {autor}{vbCrLf}"
            Next
        Else
            autores = $"by {datos(0)("Autor")}"
        End If

        ScheduleControlCursoInfo.autor = autores

    End Sub

    ''' <summary>
    ''' Muestra la informacion del curso y su planificacion
    ''' </summary>
    ''' <param name="curso"></param>
    ''' <param name="datos"></param>
    Sub ImportarDatosCurso(curso As String, datos As DataTable)

        Dim autores = ""

        etiqueta = New Label With {.Text = curso}
        ScheduleControlCursoInfo.curso = etiqueta.Text

        cmb_dias.Text = "-- SELECCIONA UN DIA --"
        datos = controlador.CrearCurso().Seleccionar("JORDI", etiqueta.Text)
        ScheduleControlCursoInfo.progreso = $"Tu progreso es de {datos(0)("Progreso")}"

        controlador.CrearHorario().Seleccionar("JORDI", curso, String.Empty, dtg_horario)

        If datos.Rows.Count > 1 Then
            For Each item In datos.Rows
                Dim autor = item("Autor")
                autores += $"by {autor}{vbCrLf}"
            Next
        Else
            autores = $"by {datos(0)("Autor")}"
        End If

        ScheduleControlCursoInfo.autor = autores

    End Sub

End Class
