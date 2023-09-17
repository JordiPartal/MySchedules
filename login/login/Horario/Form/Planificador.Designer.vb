<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planificador
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Planificador))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        lbl_planificador = New Label()
        pic_home = New PictureBox()
        dtg_horario = New DataGridView()
        tlp_options = New TableLayoutPanel()
        btn_planificar = New Button()
        cmb_dias = New ComboBox()
        cmb_curso = New ComboBox()
        btn_eliminar = New Button()
        pic_new_week = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(pic_home, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtg_horario, ComponentModel.ISupportInitialize).BeginInit()
        tlp_options.SuspendLayout()
        CType(pic_new_week, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(lbl_planificador, 0, 0)
        TableLayoutPanel1.Controls.Add(pic_home, 2, 0)
        TableLayoutPanel1.Controls.Add(dtg_horario, 1, 1)
        TableLayoutPanel1.Controls.Add(tlp_options, 0, 1)
        TableLayoutPanel1.Controls.Add(pic_new_week, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.Size = New Size(820, 480)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lbl_planificador
        ' 
        lbl_planificador.AutoSize = True
        lbl_planificador.Dock = DockStyle.Fill
        lbl_planificador.Font = New Font("Eras Demi ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_planificador.Location = New Point(3, 0)
        lbl_planificador.Name = "lbl_planificador"
        lbl_planificador.Padding = New Padding(16, 0, 0, 0)
        lbl_planificador.Size = New Size(404, 120)
        lbl_planificador.TabIndex = 7
        lbl_planificador.Text = "Planificador"
        lbl_planificador.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pic_home
        ' 
        pic_home.Cursor = Cursors.Hand
        pic_home.Dock = DockStyle.Fill
        pic_home.Image = CType(resources.GetObject("pic_home.Image"), Image)
        pic_home.Location = New Point(618, 3)
        pic_home.Name = "pic_home"
        pic_home.Size = New Size(199, 114)
        pic_home.SizeMode = PictureBoxSizeMode.Zoom
        pic_home.TabIndex = 8
        pic_home.TabStop = False
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
        TableLayoutPanel1.SetColumnSpan(dtg_horario, 2)
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dtg_horario.DefaultCellStyle = DataGridViewCellStyle2
        dtg_horario.Dock = DockStyle.Fill
        dtg_horario.Location = New Point(413, 123)
        dtg_horario.Name = "dtg_horario"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dtg_horario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dtg_horario.RowHeadersWidth = 51
        dtg_horario.RowTemplate.Height = 29
        dtg_horario.Size = New Size(404, 354)
        dtg_horario.TabIndex = 9
        ' 
        ' tlp_options
        ' 
        tlp_options.ColumnCount = 1
        tlp_options.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlp_options.Controls.Add(btn_planificar, 0, 3)
        tlp_options.Controls.Add(cmb_dias, 0, 0)
        tlp_options.Controls.Add(cmb_curso, 0, 1)
        tlp_options.Controls.Add(btn_eliminar, 0, 4)
        tlp_options.Dock = DockStyle.Fill
        tlp_options.Location = New Point(3, 123)
        tlp_options.Name = "tlp_options"
        tlp_options.RowCount = 5
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlp_options.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlp_options.Size = New Size(404, 354)
        tlp_options.TabIndex = 10
        ' 
        ' btn_planificar
        ' 
        btn_planificar.BackColor = Color.DeepSkyBlue
        btn_planificar.Dock = DockStyle.Fill
        btn_planificar.FlatStyle = FlatStyle.Flat
        btn_planificar.Font = New Font("Eras Demi ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_planificar.ForeColor = Color.Transparent
        btn_planificar.Location = New Point(3, 249)
        btn_planificar.Name = "btn_planificar"
        btn_planificar.Size = New Size(398, 47)
        btn_planificar.TabIndex = 3
        btn_planificar.Text = "Planificar"
        btn_planificar.UseVisualStyleBackColor = False
        ' 
        ' cmb_dias
        ' 
        cmb_dias.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmb_dias.FlatStyle = FlatStyle.Flat
        cmb_dias.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_dias.FormattingEnabled = True
        cmb_dias.Location = New Point(3, 18)
        cmb_dias.Name = "cmb_dias"
        cmb_dias.Size = New Size(398, 34)
        cmb_dias.TabIndex = 0
        ' 
        ' cmb_curso
        ' 
        cmb_curso.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmb_curso.FlatStyle = FlatStyle.Flat
        cmb_curso.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_curso.FormattingEnabled = True
        cmb_curso.Location = New Point(3, 88)
        cmb_curso.Name = "cmb_curso"
        cmb_curso.Size = New Size(398, 34)
        cmb_curso.TabIndex = 1
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.Crimson
        btn_eliminar.Dock = DockStyle.Fill
        btn_eliminar.FlatStyle = FlatStyle.Flat
        btn_eliminar.Font = New Font("Eras Demi ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_eliminar.ForeColor = Color.Transparent
        btn_eliminar.Location = New Point(3, 302)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(398, 49)
        btn_eliminar.TabIndex = 2
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' pic_new_week
        ' 
        pic_new_week.Dock = DockStyle.Fill
        pic_new_week.Image = CType(resources.GetObject("pic_new_week.Image"), Image)
        pic_new_week.Location = New Point(413, 3)
        pic_new_week.Name = "pic_new_week"
        pic_new_week.Size = New Size(199, 114)
        pic_new_week.SizeMode = PictureBoxSizeMode.Zoom
        pic_new_week.TabIndex = 11
        pic_new_week.TabStop = False
        ' 
        ' Planificador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(820, 480)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Planificador"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Planificador"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(pic_home, ComponentModel.ISupportInitialize).EndInit()
        CType(dtg_horario, ComponentModel.ISupportInitialize).EndInit()
        tlp_options.ResumeLayout(False)
        CType(pic_new_week, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_planificador As Label
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents dtg_horario As DataGridView
    Friend WithEvents tlp_options As TableLayoutPanel
    Friend WithEvents btn_planificar As Button
    Friend WithEvents cmb_dias As ComboBox
    Friend WithEvents cmb_curso As ComboBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents pic_new_week As PictureBox
End Class
