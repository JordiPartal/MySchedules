<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleControlCursoInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        tlp_info = New TableLayoutPanel()
        lbl_curso = New Label()
        Panel1 = New Panel()
        lbl_autores = New Label()
        lbl_progreso = New Label()
        tlp_info.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlp_info
        ' 
        tlp_info.ColumnCount = 1
        tlp_info.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlp_info.Controls.Add(lbl_curso, 0, 0)
        tlp_info.Controls.Add(Panel1, 0, 1)
        tlp_info.Dock = DockStyle.Fill
        tlp_info.Location = New Point(0, 0)
        tlp_info.Name = "tlp_info"
        tlp_info.RowCount = 2
        tlp_info.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        tlp_info.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        tlp_info.Size = New Size(410, 288)
        tlp_info.TabIndex = 0
        ' 
        ' lbl_curso
        ' 
        lbl_curso.AutoSize = True
        lbl_curso.Dock = DockStyle.Fill
        lbl_curso.Font = New Font("Eras Demi ITC", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_curso.Location = New Point(3, 0)
        lbl_curso.Name = "lbl_curso"
        lbl_curso.Size = New Size(404, 86)
        lbl_curso.TabIndex = 0
        lbl_curso.Text = "Aquí va el nombre del curso"
        lbl_curso.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbl_autores)
        Panel1.Controls.Add(lbl_progreso)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(404, 196)
        Panel1.TabIndex = 1
        ' 
        ' lbl_autores
        ' 
        lbl_autores.Dock = DockStyle.Fill
        lbl_autores.Font = New Font("Eras Light ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_autores.Location = New Point(0, 45)
        lbl_autores.Name = "lbl_autores"
        lbl_autores.Padding = New Padding(0, 16, 0, 0)
        lbl_autores.Size = New Size(404, 151)
        lbl_autores.TabIndex = 3
        lbl_autores.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbl_progreso
        ' 
        lbl_progreso.Cursor = Cursors.Hand
        lbl_progreso.Dock = DockStyle.Top
        lbl_progreso.Font = New Font("Eras Light ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_progreso.Location = New Point(0, 0)
        lbl_progreso.Name = "lbl_progreso"
        lbl_progreso.Size = New Size(404, 45)
        lbl_progreso.TabIndex = 2
        lbl_progreso.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' ScheduleControlCursoInfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(tlp_info)
        Name = "ScheduleControlCursoInfo"
        Size = New Size(410, 288)
        tlp_info.ResumeLayout(False)
        tlp_info.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlp_info As TableLayoutPanel
    Friend WithEvents lbl_curso As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_progreso As Label
    Friend WithEvents lbl_autores As Label
End Class
