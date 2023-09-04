Public Class Fabrica
    Implements IControlador

    Public Function CrearUsuario() As IUsuario Implements IControlador.CrearUsuario

        Return New UsuarioDAO()

    End Function

    Public Function CrearHorario() As IHorario Implements IControlador.CrearHorario

        Return New HorarioDAO()

    End Function

    Public Function CrearCurso() As ICurso Implements IControlador.CrearCurso

        Return New CursoDAO()

    End Function

End Class
