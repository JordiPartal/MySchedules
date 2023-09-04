Public Interface IUsuario

    Function Identificador(login As String) As Integer

    Function Seleccionar(login As String, password As String) As Boolean

    Function Actualizar(login As String, password As String) As Boolean

    Function Anadir(login As String) As Boolean

End Interface
