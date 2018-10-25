Public Class MoveForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 4.
        Dim value As Integer = CInt(Int((4 * Rnd()) + 1))
        Select Case value
            '左移
            Case = 1 And Me.Left - 50 >= 0
                Me.Left -= 10
            '右移
            Case = 2 And Me.Left + 50 <= screenWidth - Me.Size.Width
                Me.Left += 10
            '上移
            Case = 3 And Me.Top - 50 >= 0
                Me.Top -= 10
            '下移
            Case = 4 And Me.Top + 50 <= screenHeight - Me.Size.Height
                Me.Top += 10
        End Select


    End Sub


End Class