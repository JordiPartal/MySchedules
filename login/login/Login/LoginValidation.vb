Imports System.Data.SqlClient

Module LoginValidation
    Dim ColeccionDeDatos As New DataSet
    Dim Adapter As SqlDataAdapter

    Function ComprobarUsuarioSQL(usuario As String, password As String) As Boolean
        Dim existe As Boolean
        Dim usuario_ok As Boolean
        Dim password_ok As Boolean

        Abrir()

        Adapter = New SqlDataAdapter($"MostrarUsuario '{usuario}'", CONEXION)
        Adapter.Fill(ColeccionDeDatos)
        usuario_ok = ColeccionDeDatos.Tables(0).Rows(0)("login").ToString() = usuario
        password_ok = ColeccionDeDatos.Tables(0).Rows(0)("password").ToString() = password
        existe = usuario_ok And password_ok

        Cerrar()

        Return existe
    End Function

    Sub InformarSiExisteSQL(existe As Boolean, boton As Button, form As Form, curso As Form)
        If existe Then
            form.Hide()
            curso.Show()
        End If
    End Sub

End Module
