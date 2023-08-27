<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleControl
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtg_usuario = New DataGridView()
        pnl_subrayado = New Panel()
        lbl_cabecera = New Label()
        CType(dtg_usuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtg_usuario
        ' 
        dtg_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtg_usuario.Dock = DockStyle.Bottom
        dtg_usuario.Location = New Point(0, 85)
        dtg_usuario.Name = "dtg_usuario"
        dtg_usuario.RowHeadersWidth = 51
        dtg_usuario.RowTemplate.Height = 29
        dtg_usuario.Size = New Size(820, 275)
        dtg_usuario.TabIndex = 0
        ' 
        ' pnl_subrayado
        ' 
        pnl_subrayado.BackColor = Color.Black
        pnl_subrayado.Dock = DockStyle.Bottom
        pnl_subrayado.Location = New Point(0, 80)
        pnl_subrayado.Name = "pnl_subrayado"
        pnl_subrayado.Size = New Size(820, 5)
        pnl_subrayado.TabIndex = 2
        ' 
        ' lbl_cabecera
        ' 
        lbl_cabecera.AutoSize = True
        lbl_cabecera.Dock = DockStyle.Bottom
        lbl_cabecera.Font = New Font("Eras Light ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_cabecera.Location = New Point(0, 34)
        lbl_cabecera.Name = "lbl_cabecera"
        lbl_cabecera.Padding = New Padding(16, 0, 0, 0)
        lbl_cabecera.Size = New Size(353, 46)
        lbl_cabecera.TabIndex = 3
        lbl_cabecera.Text = "Qué quieres mirar?"
        lbl_cabecera.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ScheduleControl
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        Controls.Add(lbl_cabecera)
        Controls.Add(pnl_subrayado)
        Controls.Add(dtg_usuario)
        Name = "ScheduleControl"
        Size = New Size(820, 360)
        CType(dtg_usuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtg_usuario As DataGridView
    Friend WithEvents pnl_subrayado As Panel
    Friend WithEvents lbl_cabecera As Label
End Class
