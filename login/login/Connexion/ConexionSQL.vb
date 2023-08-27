Imports System.Data.SqlClient

Module ConexionSQL
    Public CONEXION As New SqlConnection("Data Source=ITSMEMARIO\SQLEXPRESS; Initial Catalog=MySchedule; Integrated Security=True")

    Sub Abrir()
        If CONEXION.State = 0 Then
            CONEXION.Open()
        End If
    End Sub

    Sub Cerrar()
        If CONEXION.State = 1 Then
            CONEXION.Close()
        End If
    End Sub
End Module
