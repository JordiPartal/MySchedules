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

End Interface
