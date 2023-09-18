Public Class LoginScreen
    Dim placeholder As String

    Private Sub TextBox_User_On_Click(sender As Object, e As EventArgs) Handles txt_usuario.Click

        placeholder = "Nombre Usuario"
        txt_usuario.Text = If((txt_usuario.Focus), String.Empty, placeholder)

    End Sub

    Private Sub TextBox_Contrasena_On_Click(sender As Object, e As EventArgs) Handles txt_contrasena.Click

        placeholder = "Contraseña"
        txt_contrasena.Text = If((txt_contrasena.Focus), String.Empty, placeholder)

    End Sub

    Private Sub Button_Login_On_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim exist As Boolean

        Try
            exist = ComprobarUsuarioSQL(txt_usuario.Text, txt_contrasena.Text)
            InformarSiExisteSQL(exist, btn_login)
        Catch ex As Exception

        End Try

    End Sub
End Class
