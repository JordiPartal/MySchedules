Public Interface IHorario

    ''' <summary>
    ''' Muestra el día de la semana
    ''' </summary>
    ''' <param name="dia"></param>
    ''' <param name="text_box"></param>
    Sub MostrarDia(dia As Integer, text_box As Label)

    ''' <summary>
    ''' Mostrar el horario del día
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="dia"></param>
    Sub MostrarHorario(login As String, dia As Integer, data_grid As DataGridView)

    ''' <summary>
    ''' Crear la ComboBox de las horas de la jornada
    ''' </summary>
    ''' <param name="combo"></param>
    Sub CrearComboBoxHora(combo As ComboBox)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="combo"></param>
    Sub CrearComboBoxDia(combo As ComboBox)

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
    ''' Permite al usuario planificar la semana
    ''' </summary>
    ''' <param name="login"></param>
    ''' <param name="dia"></param>
    ''' <param name="hora"></param>
    ''' <param name="curso"></param>
    Sub PlanificarDia(login As String, dia As Integer, hora As String, curso As String, datagrid As DataGridView)

    ''' <summary>
    ''' Reinicia toda la demana
    ''' </summary>
    ''' <param name="login"></param>
    Sub ReiniciarSemana(login As String)

End Interface
