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
        tlp_overview = New TableLayoutPanel()
        cmb_dias = New ComboBox()
        dtg_horario = New DataGridView()
        cmb_cursos = New ComboBox()
        ScheduleControlCursoInfo = New ScheduleControlCursoInfo()
        tlp_overview.SuspendLayout()
        CType(dtg_horario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tlp_overview
        ' 
        tlp_overview.BackColor = Color.White
        tlp_overview.ColumnCount = 2
        tlp_overview.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlp_overview.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlp_overview.Controls.Add(cmb_dias, 0, 0)
        tlp_overview.Controls.Add(dtg_horario, 0, 1)
        tlp_overview.Controls.Add(cmb_cursos, 1, 0)
        tlp_overview.Controls.Add(ScheduleControlCursoInfo, 1, 1)
        tlp_overview.Dock = DockStyle.Fill
        tlp_overview.Location = New Point(0, 0)
        tlp_overview.Name = "tlp_overview"
        tlp_overview.RowCount = 2
        tlp_overview.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tlp_overview.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        tlp_overview.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlp_overview.Size = New Size(820, 360)
        tlp_overview.TabIndex = 0
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
        dtg_horario.AllowUserToAddRows = False
        dtg_horario.AllowUserToDeleteRows = False
        dtg_horario.AllowUserToResizeColumns = False
        dtg_horario.AllowUserToResizeRows = False
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
        ' ScheduleControlCursoInfo
        ' 
        ScheduleControlCursoInfo.autor = Nothing
        ScheduleControlCursoInfo.curso = Nothing
        ScheduleControlCursoInfo.Location = New Point(413, 75)
        ScheduleControlCursoInfo.Name = "ScheduleControlCursoInfo"
        ScheduleControlCursoInfo.progreso = Nothing
        ScheduleControlCursoInfo.Size = New Size(404, 282)
        ScheduleControlCursoInfo.TabIndex = 5
        ' 
        ' ScheduleControlHorario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(tlp_overview)
        Name = "ScheduleControlHorario"
        Size = New Size(820, 360)
        tlp_overview.ResumeLayout(False)
        CType(dtg_horario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlp_overview As TableLayoutPanel
    Friend WithEvents dtg_horario As DataGridView
    Friend WithEvents cmb_cursos As ComboBox
    Friend WithEvents cmb_dias As ComboBox
    Friend WithEvents ScheduleControlCursoInfo As ScheduleControlCursoInfo
End Class
