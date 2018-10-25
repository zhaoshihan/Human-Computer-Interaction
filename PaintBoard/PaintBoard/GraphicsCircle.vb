Public Class GraphicsCircle
    Inherits GraphicsItem

    Public Overrides Sub Draw(graphics As Graphics)
        Dim objSolidBrush As New SolidBrush(Me.Color)
        graphics.FillEllipse(objSolidBrush, Me.Rectangle)

    End Sub
End Class
