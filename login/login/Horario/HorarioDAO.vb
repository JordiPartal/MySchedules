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

    Public Sub ReiniciarSemana(login As String) Implements IHorario.ReiniciarSemana

        Dim comando As SqlCommandBuilder
        Dim datos As New DataSet

        Dim id As Integer = 0

        Try

            Abrir()

            Adaptador = New SqlDataAdapter($"MostrarUsuario {login.ToUpper()}", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)

            id = Convert.ToInt32(ColeccionDeDatos.Rows(0)("id"))
            ColeccionDeDatos.Reset()

            Adaptador = New SqlDataAdapter($"SELECT * FROM SeleccionarDiaCursoUsuario ({id})", CONEXION)
            Adaptador.Fill(datos)
            comando = New SqlCommandBuilder(Adaptador)

            For Each Hilera As DataRow In datos.Tables(0).Rows
                Hilera.Delete()
            Next

            Adaptador.Update(datos.Tables(0))

            Cerrar()

        Catch ex As Exception

            MessageBox.Show("Se produjo un error")

        End Try

    End Sub

End Class
