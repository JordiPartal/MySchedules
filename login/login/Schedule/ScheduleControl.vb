Public Class ScheduleControl
    Private _cabecera As String
    Property cabecera As String
        Get
            Return _cabecera
        End Get
        Set(value As String)
            _cabecera = value
            lbl_cabecera.Text = _cabecera
        End Set
    End Property
End Class
