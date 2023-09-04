Imports System.Data.SqlClient

Public Class HorarioDAO
    Implements IHorario

    Dim ColeccionDeDatos As New DataSet
    Dim Adaptador As SqlDataAdapter

    Sub Seleccionar(login As String, datos As DataGridView) Implements IHorario.Seleccionar

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarMisCursos '{login.ToUpper()}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            datos.DataSource = ColeccionDeDatos.Tables(0)

            Cerrar()

        Catch ex As Exception

            MessageBox.Show("Se produjo un error")

        End Try

    End Sub

End Class
