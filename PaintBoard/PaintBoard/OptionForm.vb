
Public Class OptionForm
    Dim myPaint As New Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myPaint.setSize(ComboBox1.SelectedIndex)
    End Sub

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        myPaint.Show()
        Label2.Text = myPaint.PaintControl1.GraphicsColor.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        Try
            myPaint.setColor(ColorDialog1.Color)
            Label2.Text = myPaint.PaintControl1.GraphicsColor.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myPaint.PaintControl1.clearCanvas()
    End Sub
End Class