Imports System.Data.SqlClient

Module LoginValidation
    Dim ColeccionDeDatos As New DataSet
    Dim Adapter As SqlDataAdapter

    Function ComprobarUsuarioSQL(usuario As String) As Boolean
        Dim existe As Boolean

        Abrir()
        Adapter = New SqlDataAdapter("ComprobarDatos", CONEXION)
        Adapter.Fill(ColeccionDeDatos)
        existe = ColeccionDeDatos.Tables(0).Rows(0)("usuario").ToString() = usuario
        Cerrar()

        Return existe
    End Function

    Sub InformarSiExisteSQL(existe As Boolean, boton As Button)
        If existe Then
            boton.BackColor = Color.Green
            boton.Text = "Usuario autorizado"
        Else
            boton.BackColor = Color.Red
            boton.Text = "Usuario NO autorizado"
        End If
    End Sub
End Module
