Public Class Acceso

    Public Function Crear(enumerador As Enumeracion) As Fabrica

        Select Case enumerador
            Case Enumeracion.Fabrica
                Return New Fabrica()
            Case Else
                Throw New NotImplementedException
        End Select

    End Function

End Class
