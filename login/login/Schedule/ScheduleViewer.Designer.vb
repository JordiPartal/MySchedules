﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleViewer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ScheduleViewer))
        tbl_shedule = New TableLayoutPanel()
        sch_control = New ScheduleControl()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        pic_cursos = New PictureBox()
        pic_calendario = New PictureBox()
        lbl_saludo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbl_shedule.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(pic_cursos, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_calendario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbl_shedule
        ' 
        tbl_shedule.ColumnCount = 2
        tbl_shedule.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        tbl_shedule.ColumnStyles.Add(New ColumnStyle())
        tbl_shedule.Controls.Add(sch_control, 0, 1)
        tbl_shedule.Controls.Add(TableLayoutPanel1, 1, 0)
        tbl_shedule.Dock = DockStyle.Fill
        tbl_shedule.Location = New Point(0, 0)
        tbl_shedule.Name = "tbl_shedule"
        tbl_shedule.RowCount = 2
        tbl_shedule.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tbl_shedule.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        tbl_shedule.Size = New Size(820, 480)
        tbl_shedule.TabIndex = 0
        ' 
        ' sch_control
        ' 
        sch_control.cabecera = Nothing
        tbl_shedule.SetColumnSpan(sch_control, 2)
        sch_control.Dock = DockStyle.Fill
        sch_control.Location = New Point(3, 123)
        sch_control.Name = "sch_control"
        sch_control.Size = New Size(814, 354)
        sch_control.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel1.Controls.Add(lbl_saludo, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(19, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(798, 114)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 164F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 32F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 164F))
        TableLayoutPanel3.Controls.Add(pic_cursos, 0, 0)
        TableLayoutPanel3.Controls.Add(pic_calendario, 2, 0)
        TableLayoutPanel3.Dock = DockStyle.Right
        TableLayoutPanel3.Location = New Point(435, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(360, 108)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' pic_cursos
        ' 
        pic_cursos.Cursor = Cursors.PanNW
        pic_cursos.Dock = DockStyle.Fill
        pic_cursos.Image = CType(resources.GetObject("pic_cursos.Image"), Image)
        pic_cursos.Location = New Point(3, 3)
        pic_cursos.Name = "pic_cursos"
        pic_cursos.Size = New Size(158, 102)
        pic_cursos.SizeMode = PictureBoxSizeMode.Zoom
        pic_cursos.TabIndex = 0
        pic_cursos.TabStop = False
        ' 
        ' pic_calendario
        ' 
        pic_calendario.Cursor = Cursors.PanNW
        pic_calendario.Dock = DockStyle.Fill
        pic_calendario.Image = CType(resources.GetObject("pic_calendario.Image"), Image)
        pic_calendario.Location = New Point(199, 3)
        pic_calendario.Name = "pic_calendario"
        pic_calendario.Size = New Size(158, 102)
        pic_calendario.SizeMode = PictureBoxSizeMode.Zoom
        pic_calendario.TabIndex = 1
        pic_calendario.TabStop = False
        ' 
        ' lbl_saludo
        ' 
        lbl_saludo.AutoSize = True
        lbl_saludo.Dock = DockStyle.Fill
        lbl_saludo.Font = New Font("Eras Demi ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_saludo.Location = New Point(3, 0)
        lbl_saludo.Name = "lbl_saludo"
        lbl_saludo.Size = New Size(393, 114)
        lbl_saludo.TabIndex = 3
        lbl_saludo.Text = "Hola, JORDI!"
        lbl_saludo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 164F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 32F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Dock = DockStyle.Right
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' ScheduleViewer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 480)
        Controls.Add(tbl_shedule)
        FormBorderStyle = FormBorderStyle.None
        Name = "ScheduleViewer"
        StartPosition = FormStartPosition.CenterParent
        Text = "ScheduleViewer"
        tbl_shedule.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        CType(pic_cursos, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_calendario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tbl_shedule As TableLayoutPanel
    Friend WithEvents sch_control As ScheduleControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_saludo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pic_cursos As PictureBox
    Friend WithEvents pic_calendario As PictureBox
End Class
