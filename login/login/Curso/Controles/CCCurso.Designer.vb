<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCCurso
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CCCurso))
        TableLayoutPanel1 = New TableLayoutPanel()
        dtg_usuario = New DataGridView()
        TableLayoutPanel2 = New TableLayoutPanel()
        lbl_cabecera = New Label()
        pic_week = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(dtg_usuario, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(pic_week, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(dtg_usuario, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.Size = New Size(820, 360)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' dtg_usuario
        ' 
        dtg_usuario.AllowUserToResizeColumns = False
        dtg_usuario.AllowUserToResizeRows = False
        dtg_usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dtg_usuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dtg_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dtg_usuario.DefaultCellStyle = DataGridViewCellStyle2
        dtg_usuario.Dock = DockStyle.Fill
        dtg_usuario.Location = New Point(3, 75)
        dtg_usuario.Name = "dtg_usuario"
        dtg_usuario.ReadOnly = True
        dtg_usuario.RowHeadersWidth = 51
        dtg_usuario.RowTemplate.Height = 29
        dtg_usuario.Size = New Size(814, 282)
        dtg_usuario.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Controls.Add(lbl_cabecera, 0, 0)
        TableLayoutPanel2.Controls.Add(pic_week, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(814, 66)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' lbl_cabecera
        ' 
        lbl_cabecera.AutoSize = True
        lbl_cabecera.Dock = DockStyle.Fill
        lbl_cabecera.Font = New Font("Eras Light ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_cabecera.Location = New Point(3, 0)
        lbl_cabecera.Name = "lbl_cabecera"
        lbl_cabecera.Size = New Size(645, 66)
        lbl_cabecera.TabIndex = 3
        lbl_cabecera.Text = "Que quieres hacer?"
        lbl_cabecera.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pic_week
        ' 
        pic_week.Cursor = Cursors.Hand
        pic_week.Dock = DockStyle.Fill
        pic_week.Image = CType(resources.GetObject("pic_week.Image"), Image)
        pic_week.Location = New Point(654, 3)
        pic_week.Name = "pic_week"
        pic_week.Size = New Size(157, 60)
        pic_week.SizeMode = PictureBoxSizeMode.Zoom
        pic_week.TabIndex = 4
        pic_week.TabStop = False
        ' 
        ' CCCurso
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Name = "CCCurso"
        Size = New Size(820, 360)
        TableLayoutPanel1.ResumeLayout(False)
        CType(dtg_usuario, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(pic_week, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtg_usuario As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_cabecera As Label
    Friend WithEvents pic_week As PictureBox
End Class
