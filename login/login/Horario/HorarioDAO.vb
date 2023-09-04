Imports System.Data.SqlClient

Public Class HorarioDAO
    Implements IHorario

    Dim ColeccionDeDatos As New DataTable
    Dim Adaptador As SqlDataAdapter

    Public Sub CrearComboBox(login As String, combo As ComboBox) Implements IHorario.CrearComboBox

        Dim opcion = String.Empty
        ColeccionDeDatos.Clear()

        Abrir()
        Adaptador = New SqlDataAdapter($"MostrarMisCursos '{login}'", CONEXION)
        Adaptador.Fill(ColeccionDeDatos)

        combo.Items.Add(String.Empty)

        For Each item As DataRow In ColeccionDeDatos.Rows
            If item("curso").ToString() <> opcion Then
                combo.Items.Add(item("curso").ToString())
            End If
            opcion = item("curso").ToString()
        Next

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
