Imports System.Data.SqlClient

Module ScheduleData
    Dim ColeccionDeDatos As New DataSet
    Dim Adapter As SqlDataAdapter

    Sub MostrarCurso(id As Integer, cursos As DataGridView)
        Abrir()
        Adapter = New SqlDataAdapter("MostrarMisCursos 1", CONEXION)
        Adapter.Fill(ColeccionDeDatos)
        cursos.DataSource = ColeccionDeDatos
        Cerrar()
    End Sub
End Module
