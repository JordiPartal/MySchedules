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
        dtg_horario = New DataGridView()
        lbl_informacion = New Label()
        cmb_cursos = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        CType(dtg_horario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(dtg_horario, 0, 1)
        TableLayoutPanel1.Controls.Add(lbl_informacion, 0, 0)
        TableLayoutPanel1.Controls.Add(cmb_cursos, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.Size = New Size(820, 360)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' dtg_horario
        ' 
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
        ' lbl_informacion
        ' 
        lbl_informacion.AutoSize = True
        lbl_informacion.Dock = DockStyle.Fill
        lbl_informacion.Font = New Font("Eras Light ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_informacion.Location = New Point(3, 0)
        lbl_informacion.Name = "lbl_informacion"
        lbl_informacion.Size = New Size(404, 72)
        lbl_informacion.TabIndex = 1
        lbl_informacion.Text = "Información"
        lbl_informacion.TextAlign = ContentAlignment.BottomLeft
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
        ' ScheduleControlHorario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Name = "ScheduleControlHorario"
        Size = New Size(820, 360)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dtg_horario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtg_horario As DataGridView
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents cmb_cursos As ComboBox
End Class
