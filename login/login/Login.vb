Public Class FrmLogin
    Dim placeholder As String
    Private Sub TextBox_User_On_Click(sender As Object, e As EventArgs) Handles txt_usuario.Click
        placeholder = "Nombre Usuario"
        txt_usuario.Text = If((txt_usuario.Focus), String.Empty, placeholder)
    End Sub

    Private Sub txt_contrasena_Click(sender As Object, e As EventArgs) Handles txt_contrasena.Click
        placeholder = "Contraseña"
        txt_contrasena.Text = If((txt_contrasena.Focus), String.Empty, placeholder)
    End Sub
End Class
