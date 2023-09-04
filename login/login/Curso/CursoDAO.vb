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

            Cerrar()

            Return ColeccionDeDatos

        Catch ex As Exception

            Throw New Exception
            MessageBox.Show("Se produjo un error")

        End Try

    End Function

End Class
