Imports System.Data.SqlClient

Module ScheduleData
    Dim ColeccionDeDatos As New DataTable
    Dim Adapter As SqlDataAdapter
    Public Cursos As DataGridView

    Sub ConstructorComboBoxHorario(id As Integer, Combo As ComboBox)

        Dim procedimiento = $"MostrarMisCursos {id}"

        ColeccionDeDatos.Clear()

        Abrir()
        Adapter = New SqlDataAdapter(procedimiento, CONEXION)
        Adapter.Fill(ColeccionDeDatos)
        For Each item As DataRow In ColeccionDeDatos.Rows
            Combo.Items.Add(item("curso")).ToString()
        Next

    End Sub

    Sub MostrarCurso(id As Integer)

        Dim procedimiento = $"MostrarMisCursos {id}"

        ColeccionDeDatos.Clear()

        Abrir()
        Adapter = New SqlDataAdapter(procedimiento, CONEXION)
        Adapter.Fill(ColeccionDeDatos)
        Cursos.DataSource = ColeccionDeDatos
        Cerrar()

    End Sub

End Module
