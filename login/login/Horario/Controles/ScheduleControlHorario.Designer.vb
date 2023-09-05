<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleControlHorario
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmb_dias = New ComboBox()
        dtg_horario = New DataGridView()
        cmb_cursos = New ComboBox()
        tbl_inf_curso = New TableLayoutPanel()
        lbl_titulo = New Label()
        Panel1 = New Panel()
        lbl_progreso = New Label()
        lbl_autor = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(dtg_horario, ComponentModel.ISupportInitialize).BeginInit()
        tbl_inf_curso.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(cmb_dias, 0, 0)
        TableLayoutPanel1.Controls.Add(dtg_horario, 0, 1)
        TableLayoutPanel1.Controls.Add(cmb_cursos, 1, 0)
        TableLayoutPanel1.Controls.Add(tbl_inf_curso, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(820, 360)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' cmb_dias
        ' 
        cmb_dias.BackColor = Color.White
        cmb_dias.Dock = DockStyle.Bottom
        cmb_dias.FlatStyle = FlatStyle.Popup
        cmb_dias.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_dias.FormattingEnabled = True
        cmb_dias.Location = New Point(3, 35)
        cmb_dias.Name = "cmb_dias"
        cmb_dias.Size = New Size(404, 34)
        cmb_dias.TabIndex = 4
        ' 
        ' dtg_horario
        ' 
        dtg_horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dtg_horario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dtg_horario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dtg_horario.DefaultCellStyle = DataGridViewCellStyle2
        dtg_horario.Dock = DockStyle.Fill
        dtg_horario.Location = New Point(3, 75)
        dtg_horario.Name = "dtg_horario"
        dtg_horario.RowHeadersWidth = 51
        dtg_horario.RowTemplate.Height = 29
        dtg_horario.Size = New Size(404, 282)
        dtg_horario.TabIndex = 0
        ' 
        ' cmb_cursos
        ' 
        cmb_cursos.BackColor = Color.White
        cmb_cursos.Dock = DockStyle.Bottom
        cmb_cursos.FlatStyle = FlatStyle.Popup
        cmb_cursos.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_cursos.FormattingEnabled = True
        cmb_cursos.Location = New Point(413, 35)
        cmb_cursos.Name = "cmb_cursos"
        cmb_cursos.Size = New Size(404, 34)
        cmb_cursos.TabIndex = 2
        ' 
        ' tbl_inf_curso
        ' 
        tbl_inf_curso.ColumnCount = 1
        tbl_inf_curso.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tbl_inf_curso.Controls.Add(lbl_titulo, 0, 0)
        tbl_inf_curso.Controls.Add(Panel1, 0, 1)
        tbl_inf_curso.Dock = DockStyle.Fill
        tbl_inf_curso.Location = New Point(413, 75)
        tbl_inf_curso.Name = "tbl_inf_curso"
        tbl_inf_curso.RowCount = 2
        tbl_inf_curso.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        tbl_inf_curso.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        tbl_inf_curso.Size = New Size(404, 282)
        tbl_inf_curso.TabIndex = 3
        ' 
        ' lbl_titulo
        ' 
        lbl_titulo.AutoSize = True
        lbl_titulo.Dock = DockStyle.Fill
        lbl_titulo.Font = New Font("Eras Demi ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_titulo.Location = New Point(3, 0)
        lbl_titulo.Name = "lbl_titulo"
        lbl_titulo.Size = New Size(398, 84)
        lbl_titulo.TabIndex = 0
        lbl_titulo.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbl_progreso)
        Panel1.Controls.Add(lbl_autor)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 192)
        Panel1.TabIndex = 1
        ' 
        ' lbl_progreso
        ' 
        lbl_progreso.Dock = DockStyle.Top
        lbl_progreso.Font = New Font("Eras Light ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_progreso.Location = New Point(0, 40)
        lbl_progreso.Name = "lbl_progreso"
        lbl_progreso.Size = New Size(398, 60)
        lbl_progreso.TabIndex = 1
        lbl_progreso.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_autor
        ' 
        lbl_autor.Dock = DockStyle.Top
        lbl_autor.Font = New Font("Eras Light ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_autor.Location = New Point(0, 0)
        lbl_autor.Name = "lbl_autor"
        lbl_autor.Size = New Size(398, 40)
        lbl_autor.TabIndex = 0
        lbl_autor.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ScheduleControlHorario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Name = "ScheduleControlHorario"
        Size = New Size(820, 360)
        TableLayoutPanel1.ResumeLayout(False)
        CType(dtg_horario, ComponentModel.ISupportInitialize).EndInit()
        tbl_inf_curso.ResumeLayout(False)
        tbl_inf_curso.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtg_horario As DataGridView
    Friend WithEvents cmb_cursos As ComboBox
    Friend WithEvents tbl_inf_curso As TableLayoutPanel
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_progreso As Label
    Friend WithEvents lbl_autor As Label
    Friend WithEvents cmb_dias As ComboBox
End Class
