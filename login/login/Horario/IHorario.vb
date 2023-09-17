Public Interface IHorario

    ''' <summary>
    ''' Crear la ComboBox de los días
    ''' </summary>
    ''' <param name="combo"></param>
    Sub CrearComboBox(combo As ComboBox)

    ''' <summary>
    ''' Muestrar los cursos planificados por día o los días en los que hay planificado un curso
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="curso"></param>
    ''' <param name="dia"></param>
    ''' <param name="datos"></param>
    Sub Seleccionar(login As String, curso As String, dia As String, datos As DataGridView)

    ''' <summary>
    ''' Muestra los curso dónde está registrado el usuario
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="datos"></param>
    Sub Seleccionar(login As String, datos As DataGridView)

    ''' <summary>
    ''' Reinicia toda la demana
    ''' </summary>
    ''' <param name="login"></param>
    Sub ReiniciarSemana(login As String)

End Interface
