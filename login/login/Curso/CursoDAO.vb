Imports System.Data.SqlClient

Public Class CursoDAO
    Implements ICurso

    Dim ColeccionDeDatos As New DataTable
    Dim Adaptador As SqlDataAdapter

    Public Function Seleccionar(login As String, curso As String) As DataTable Implements ICurso.Seleccionar

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarProgresoCurso '{login}', '{curso}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)

            If ColeccionDeDatos.HasErrors Then
                Throw New Exception
            End If

            Cerrar()

            Return ColeccionDeDatos

        Catch ex As Exception

            Adaptador = New SqlDataAdapter($"MostrarMisCursos '{login}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)

            Cerrar()

            Return ColeccionDeDatos

        End Try

    End Function

End Class
