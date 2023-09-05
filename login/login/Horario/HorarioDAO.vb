Imports System.Data.SqlClient
Imports Microsoft

Public Class HorarioDAO
    Implements IHorario

    Dim ColeccionDeDatos As New DataTable
    Dim Adaptador As SqlDataAdapter

    Public Sub CrearComboBox(combo As ComboBox) Implements IHorario.CrearComboBox

        Abrir()

        Adaptador = New SqlDataAdapter("SELECT * FROM dia", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        Cerrar()

        combo.Text = "-- SELECCIONA UN DIA --"

        For Each item In ColeccionDeDatos.Rows
            combo.Items.Add(item("descripcion"))
        Next

    End Sub

    Public Sub Seleccionar(login As String, curso As String, dia As String, datos As DataGridView) Implements IHorario.Seleccionar

        Dim procedimiento As String

        procedimiento = If(curso = String.Empty,
            $"OrganizacionCurso '{login.ToUpper()}', @dia = '{dia}'",
            $"OrganizacionCurso '{login.ToUpper()}', @curso = '{curso}'"
        )

        Abrir()

        Adaptador = New SqlDataAdapter(procedimiento, CONEXION)
        Adaptador.Fill(ColeccionDeDatos)
        datos.DataSource = ColeccionDeDatos

        Cerrar()

    End Sub

    Sub Seleccionar(login As String, datos As DataGridView) Implements IHorario.Seleccionar

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarMisCursos '{login.ToUpper()}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            datos.DataSource = ColeccionDeDatos

            Cerrar()

        Catch ex As Exception

            MessageBox.Show("Se produjo un error")

        End Try

    End Sub

End Class
