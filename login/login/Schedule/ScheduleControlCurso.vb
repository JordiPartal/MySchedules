Public Class ScheduleControlCurso
    Private _cabecera As String
    Property cabecera As String
        Get
            Return _cabecera
        End Get
        Set(value As String)
            _cabecera = value
            lbl_cabecera.Text = _cabecera
            Cursos = dtg_usuario
            If _cabecera = "Cursos" Then
                MostrarCurso(1)
            End If
        End Set
    End Property
End Class
