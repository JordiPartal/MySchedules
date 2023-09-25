Public Interface ICurso

    ''' <summary>
    ''' Crea la ComboBox de los cursos
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="combo"></param>
    Sub CrearComboBox(login As String, combo As ComboBox)

    ''' <summary>
    ''' Muestra al usuario la información relevante del curso, título, progreso y autor
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="curso"></param>
    ''' <returns></returns>
    Function Seleccionar(login As String, curso As String) As DataTable

    ''' <summary>
    ''' Actuliza el progreso de un curso
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="textbox"></param>
    Sub ActualizarProgreso(login As String, curso As String, textbox As TextBox)

    ''' <summary>
    ''' Elimina una registro de la tabla (dia_curso_usuario)
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="dia"></param>
    ''' <param name="curso"></param>
    Sub EliminarCursoDePlanificacion(login As String, dia As String, curso As String)

    ''' <summary>
    ''' Añade un registo a la tabla (usuario_dia_hora_curso)
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="dia"></param>
    ''' <param name="curso"></param>
    Sub AnadirCursoEnPlanificacion(login As String, dia As String, curso As String, datagrid As DataGridView)

End Interface
