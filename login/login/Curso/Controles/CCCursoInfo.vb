Public Class CCCursoInfo

    Private _curso As String
    Public Property curso As String
        Get
            Return _curso
        End Get
        Set(ByVal value As String)
            _curso = value
            lbl_curso.Text = _curso
        End Set
    End Property

    Private _progreso As String
    Public Property progreso As String
        Get
            Return _progreso
        End Get
        Set(ByVal value As String)
            _progreso = value
            lbl_progreso.Text = _progreso
        End Set
    End Property

    Private _autor As String

    Public Property autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            _autor = value
            lbl_autores.Text = _autor
        End Set
    End Property

    Private Sub lbl_progreso_Click(sender As Object, e As EventArgs) Handles lbl_progreso.Click

        Dim nuevo_progreso = New UpdateProgress With {
            .curso = lbl_curso.Text
        }
        nuevo_progreso.Show()

    End Sub

End Class
