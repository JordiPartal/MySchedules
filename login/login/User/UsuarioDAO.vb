Imports System.Data.SqlClient

Public Class UsuarioDAO
    Implements IUsuario

    Dim ColeccionDeDatos As New DataSet
    Dim Adaptador As SqlDataAdapter

    Public Function Identificador(login As String) As Integer Implements IUsuario.Identificador

        Dim id As Integer
        Dim hilera As DataRow

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarUsuario '{login.ToUpper()}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            hilera = ColeccionDeDatos.Tables(0).Rows(0)
            id = hilera("id")

            Cerrar()

            ColeccionDeDatos.Tables.Remove(0)

        Catch ex As Exception

        End Try

    End Function

    Public Function Seleccionar(login As String, password As String) As Boolean Implements IUsuario.Seleccionar

        Dim existe As Boolean
        Dim login_ok As Boolean
        Dim password_ok As Boolean

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarUsuario '{login.ToUpper()}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            login_ok = ColeccionDeDatos.Tables(0).Rows(0)("login").ToString() = login
            password_ok = ColeccionDeDatos.Tables(0).Rows(0)("password").ToString() = password
            existe = login_ok And password_ok

            Cerrar()

            ColeccionDeDatos.Tables.Remove(0)

            Return existe

        Catch ex As Exception

            Return False

        End Try

    End Function

    Public Function Actualizar(login As String, password As String) As Boolean Implements IUsuario.Actualizar

        Dim comando As SqlCommandBuilder
        Dim hilera As DataRow

        Dim actulizar As Integer

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarUsuario '{login.ToUpper()}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            comando = New SqlCommandBuilder(Adaptador)
            hilera = ColeccionDeDatos.Tables(0).Rows(0)
            hilera("password") = password

            If ColeccionDeDatos.HasChanges Then
                actulizar = Adaptador.Update(ColeccionDeDatos.Tables(0))
                Return True
            Else
                Throw New Exception
            End If

            Cerrar()

            ColeccionDeDatos.Tables.Remove(0)

        Catch ex As Exception

            Return False

        End Try

    End Function

    Public Function Anadir(login As String) As Boolean Implements IUsuario.Anadir

        Dim comando As SqlCommandBuilder
        Dim hilera As DataRow

        Dim actualizar As Integer

        Try

            Dim password = "12345aA"

            Abrir()

            Adaptador = New SqlDataAdapter("MostrarTodosLosUsuarios", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            comando = New SqlCommandBuilder(Adaptador)
            hilera = ColeccionDeDatos.Tables(0).NewRow()
            hilera("login") = login
            hilera("password") = password
            ColeccionDeDatos.Tables(0).Rows.Add(hilera)

            If ColeccionDeDatos.HasChanges Then
                actualizar = Adaptador.Update(ColeccionDeDatos.Tables(0))
                Return True
            Else
                Throw New Exception
            End If

            Cerrar()

        Catch ex As Exception

            Return False

        End Try

    End Function

End Class
