Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.EntityFrameworkCore.DbLoggerCategory.Database

Public Class HorarioDAO
    Implements IHorario

    Dim ColeccionDeDatos As New DataTable
    Dim Adaptador As SqlDataAdapter

    Public Sub MostrarDia(dia As Integer, text_box As Label) Implements IHorario.MostrarDia

        Dim dia_de_la_semana
        Dim datos As New DataSet

        Abrir()

        Adaptador = New SqlDataAdapter($"MostrarDia {dia}", CONEXION)
        Adaptador.Fill(datos)
        dia_de_la_semana = datos.Tables(0).Rows(0)("dia")
        text_box.Text = dia_de_la_semana

        Cerrar()

    End Sub

    Public Sub MostrarHorario(login As String, dia As Integer, data_grid As DataGridView) Implements IHorario.MostrarHorario

        Dim id As Integer

        Abrir()

        login = login.ToUpper()

        Adaptador = New SqlDataAdapter($"MostrarUsuario '{login}'", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)
        id = Convert.ToInt32(ColeccionDeDatos.Rows(0)("id"))
        ColeccionDeDatos.Reset()

        Adaptador = New SqlDataAdapter($"SELECT * FROM PlanificarHorario ({id}, {dia})", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)
        data_grid.DataSource = ColeccionDeDatos

        Cerrar()

    End Sub

    Public Sub CrearComboBoxHora(combo As ComboBox) Implements IHorario.CrearComboBoxHora

        Abrir()

        Adaptador = New SqlDataAdapter("SELECT * FROM horas", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        Cerrar()

        combo.Text = "-- SELECCIONA UNA HORA --"

        For Each item In ColeccionDeDatos.Rows
            combo.Items.Add(item("hora"))
        Next

    End Sub

    Public Sub CrearComboBoxDia(combo As ComboBox) Implements IHorario.CrearComboBoxDia

        Abrir()

        Adaptador = New SqlDataAdapter("SELECT * FROM dia", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        Cerrar()

        combo.Text = "-- SELECCIONA UNA HORA --"

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

    Public Sub PlanificarDia(
        login As String, dia As Integer, hora As String, curso As String, datagrid As DataGridView
    ) Implements IHorario.PlanificarDia

        Dim _login, _hora, _curso As Integer
        Dim comando As SqlCommandBuilder
        Dim datos As New DataSet

        Try

            Abrir()

            login = login.ToUpper()
            Adaptador = New SqlDataAdapter($"MostrarUsuario '{login}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            _login = Convert.ToInt32(ColeccionDeDatos.Rows(0)("id"))
            ColeccionDeDatos.Reset()

            Adaptador = New SqlDataAdapter($"SELECT * FROM horas WHERE hora = '{hora}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            _hora = Convert.ToInt32(ColeccionDeDatos.Rows(0)("franja"))
            ColeccionDeDatos.Reset()

            Adaptador = New SqlDataAdapter($"SELECT * FROM curso WHERE descripcion = '{curso}'", CONEXION)
            Adaptador.Fill(ColeccionDeDatos)
            _curso = Convert.ToInt32(ColeccionDeDatos.Rows(0)("id"))
            ColeccionDeDatos.Reset()

            Adaptador = New SqlDataAdapter($"SELECT * FROM PlanificarDia({_login}, {dia}, {_hora})", CONEXION)
            Adaptador.Fill(datos)
            comando = New SqlCommandBuilder(Adaptador)

            datos.Tables(0).Rows(0)("curso") = _curso
            Adaptador.Update(datos.Tables(0))

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

            Adaptador = New SqlDataAdapter($"SELECT * FROM ReiniciarHorario ({id})", CONEXION)
            Adaptador.Fill(datos)
            comando = New SqlCommandBuilder(Adaptador)

            For Each Hilera As DataRow In datos.Tables(0).Rows
                Hilera("curso") = DBNull.Value
            Next

            Adaptador.Update(datos.Tables(0))

            Cerrar()

        Catch ex As Exception

            MessageBox.Show("Se produjo un error")

        End Try

    End Sub

End Class
