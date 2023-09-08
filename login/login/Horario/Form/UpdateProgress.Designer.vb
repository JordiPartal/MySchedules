<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProgress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_actualizar = New Button()
        txt_tu_progreso = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_actualizar
        ' 
        btn_actualizar.BackColor = Color.DeepSkyBlue
        btn_actualizar.FlatStyle = FlatStyle.Flat
        btn_actualizar.Font = New Font("Eras Demi ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_actualizar.ForeColor = Color.Transparent
        btn_actualizar.Location = New Point(13, 129)
        btn_actualizar.Name = "btn_actualizar"
        btn_actualizar.Size = New Size(455, 49)
        btn_actualizar.TabIndex = 0
        btn_actualizar.Text = "Aceptar"
        btn_actualizar.UseVisualStyleBackColor = False
        ' 
        ' txt_tu_progreso
        ' 
        txt_tu_progreso.BorderStyle = BorderStyle.FixedSingle
        txt_tu_progreso.Font = New Font("Eras Light ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_tu_progreso.Location = New Point(12, 54)
        txt_tu_progreso.Name = "txt_tu_progreso"
        txt_tu_progreso.Size = New Size(455, 38)
        txt_tu_progreso.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Eras Light ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 32)
        Label1.TabIndex = 2
        Label1.Text = "Progreso:"
        ' 
        ' UpdateProgress
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 190)
        Controls.Add(Label1)
        Controls.Add(txt_tu_progreso)
        Controls.Add(btn_actualizar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "UpdateProgress"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateProgress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_actualizar As Button
    Friend WithEvents txt_tu_progreso As TextBox
    Friend WithEvents Label1 As Label
End Class
