<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tlp_principal = New TableLayoutPanel()
        Panel1 = New Panel()
        txt_contrasena = New TextBox()
        lbl_contrasena = New Label()
        lbl_login = New Label()
        pnl_usuario = New Panel()
        txt_usuario = New TextBox()
        lbl_usuario = New Label()
        btn_login = New Button()
        tlp_principal.SuspendLayout()
        Panel1.SuspendLayout()
        pnl_usuario.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlp_principal
        ' 
        tlp_principal.ColumnCount = 1
        tlp_principal.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlp_principal.Controls.Add(Panel1, 0, 2)
        tlp_principal.Controls.Add(lbl_login, 0, 0)
        tlp_principal.Controls.Add(pnl_usuario, 0, 1)
        tlp_principal.Controls.Add(btn_login, 0, 3)
        tlp_principal.Dock = DockStyle.Fill
        tlp_principal.Location = New Point(0, 0)
        tlp_principal.Name = "tlp_principal"
        tlp_principal.RowCount = 4
        tlp_principal.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        tlp_principal.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlp_principal.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlp_principal.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tlp_principal.Size = New Size(720, 360)
        tlp_principal.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txt_contrasena)
        Panel1.Controls.Add(lbl_contrasena)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 198)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(720, 90)
        Panel1.TabIndex = 2
        ' 
        ' txt_contrasena
        ' 
        txt_contrasena.BackColor = SystemColors.Window
        txt_contrasena.BorderStyle = BorderStyle.FixedSingle
        txt_contrasena.Location = New Point(168, 26)
        txt_contrasena.Name = "txt_contrasena"
        txt_contrasena.PasswordChar = "*"c
        txt_contrasena.Size = New Size(525, 38)
        txt_contrasena.TabIndex = 1
        txt_contrasena.Text = "Contraseña"
        ' 
        ' lbl_contrasena
        ' 
        lbl_contrasena.Dock = DockStyle.Left
        lbl_contrasena.Location = New Point(0, 0)
        lbl_contrasena.Margin = New Padding(0)
        lbl_contrasena.Name = "lbl_contrasena"
        lbl_contrasena.Size = New Size(165, 90)
        lbl_contrasena.TabIndex = 0
        lbl_contrasena.Text = "Contraseña:"
        lbl_contrasena.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.Dock = DockStyle.Fill
        lbl_login.Font = New Font("Eras Demi ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_login.Location = New Point(3, 0)
        lbl_login.Name = "lbl_login"
        lbl_login.Padding = New Padding(16, 0, 0, 0)
        lbl_login.Size = New Size(714, 108)
        lbl_login.TabIndex = 0
        lbl_login.Text = "Bienvenido a MySchedule"
        lbl_login.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnl_usuario
        ' 
        pnl_usuario.Controls.Add(txt_usuario)
        pnl_usuario.Controls.Add(lbl_usuario)
        pnl_usuario.Dock = DockStyle.Fill
        pnl_usuario.Location = New Point(0, 108)
        pnl_usuario.Margin = New Padding(0)
        pnl_usuario.Name = "pnl_usuario"
        pnl_usuario.Size = New Size(720, 90)
        pnl_usuario.TabIndex = 1
        ' 
        ' txt_usuario
        ' 
        txt_usuario.BackColor = SystemColors.Window
        txt_usuario.BorderStyle = BorderStyle.FixedSingle
        txt_usuario.Location = New Point(168, 26)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.PlaceholderText = "Nombre Usuario"
        txt_usuario.Size = New Size(525, 38)
        txt_usuario.TabIndex = 1
        ' 
        ' lbl_usuario
        ' 
        lbl_usuario.Dock = DockStyle.Left
        lbl_usuario.Location = New Point(0, 0)
        lbl_usuario.Margin = New Padding(0)
        lbl_usuario.Name = "lbl_usuario"
        lbl_usuario.Size = New Size(165, 90)
        lbl_usuario.TabIndex = 0
        lbl_usuario.Text = "Usuario:"
        lbl_usuario.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Black
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Eras Demi ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.ForeColor = Color.Transparent
        btn_login.Location = New Point(3, 291)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(714, 59)
        btn_login.TabIndex = 3
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(720, 360)
        Controls.Add(tlp_principal)
        Font = New Font("Eras Light ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        tlp_principal.ResumeLayout(False)
        tlp_principal.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnl_usuario.ResumeLayout(False)
        pnl_usuario.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlp_principal As TableLayoutPanel
    Friend WithEvents lbl_login As Label
    Friend WithEvents pnl_usuario As Panel
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents btn_login As Button
End Class
