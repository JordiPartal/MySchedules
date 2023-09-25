﻿Imports System.Data.SqlClient

Public Class CursoDAO
    Implements ICurso

    Dim ColeccionDeDatos As New DataTable
    Dim Adaptador As SqlDataAdapter

    Public Sub CrearComboBox(login As String, combo As ComboBox) Implements ICurso.CrearComboBox

        Dim opcion = String.Empty

        Abrir()

        Adaptador = New SqlDataAdapter($"MostrarProgresoCurso '{login.ToUpper()}'", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        Cerrar()

        combo.Text = "-- SELECCIONA UN CURSO --"

        For Each item As DataRow In ColeccionDeDatos.Rows
            If item("curso").ToString() <> opcion Then
                combo.Items.Add(item("curso").ToString())
            End If
            opcion = item("curso").ToString()
        Next

    End Sub

    Public Function Seleccionar(login As String, curso As String) As DataTable Implements ICurso.Seleccionar

        Abrir()

        Adaptador = New SqlDataAdapter($"MostrarProgresoCurso '{login.ToUpper()}', '{curso}'", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        Cerrar()

        Return ColeccionDeDatos

    End Function

    Public Sub ActualizarProgreso(login As String, curso As String, textbox As TextBox) Implements ICurso.ActualizarProgreso

        Dim mi_login = login.ToUpper()
        Dim porcentaje = Convert.ToInt32(textbox.Text.Substring(0, textbox.Text.Length - 1))
        Dim comando As SqlCommand

        Abrir()

        comando = New SqlCommand($"ActualizarProgresCurso '{mi_login}', '{curso}', {porcentaje}", CONEXION)
        Dim registros As Integer = comando.ExecuteNonQuery()

        comando.Dispose()

    End Sub

    Public Sub EliminarCursoDePlanificacion(login As String, dia As String, curso As String) Implements ICurso.EliminarCursoDePlanificacion

        Dim mi_login = login.ToUpper()
        Dim comando As SqlCommand

        Abrir()

        comando = New SqlCommand($"EliminarCursoPlanificacion '{login}', '{dia}', '{curso}'", CONEXION)
        Dim registro As Integer = comando.ExecuteNonQuery()

        comando.Dispose()

    End Sub

    Public Sub AnadirCursoEnPlanificacion(login As String, dia As String, curso As String, datagrid As DataGridView) Implements ICurso.AnadirCursoEnPlanificacion

        Dim comando As SqlCommandBuilder
        Dim id As Integer
        Dim datos As DataTable = datagrid.DataSource

        Abrir()

        Adaptador = New SqlDataAdapter($"MostrarUsuario '{login.ToUpper()}'", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)
        id = ColeccionDeDatos.DataSet.Tables(0).Rows(0)("id")

        Adaptador = New SqlDataAdapter($"SELECT * FROM PlanificarHorario ({id}, {dia})", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)
        comando = New SqlCommandBuilder

        Adaptador.Update(datos)

        Cerrar()

    End Sub

End Class