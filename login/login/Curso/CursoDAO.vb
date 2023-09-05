Imports System.Data.SqlClient

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

End Class
