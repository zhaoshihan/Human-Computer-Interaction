Public Class Form1
    Public Sub setSize(ByVal size As Integer)
        If size = 0 Then
            PaintControl1.GraphicsSize = PaintControl.GraphicsSizes.Small
        ElseIf size = 1 Then
            PaintControl1.GraphicsSize = PaintControl.GraphicsSizes.Medium
        ElseIf size = 2 Then
            PaintControl1.GraphicsSize = PaintControl.GraphicsSizes.Large
        End If
    End Sub


    Public Sub setColor(ByVal color As Color)
        PaintControl1.GraphicsColor = color
    End Sub
End Class
