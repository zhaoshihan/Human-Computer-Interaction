Imports System.Math

Public Class Calculator
    Private Sub ButtonAC_Click(sender As Object, e As EventArgs) Handles ButtonAC.Click
        TextBox1.Clear()
        TextBox1.Text = 0
        GlobalVariables.op = Nothing
        GlobalVariables.opcode1 = Nothing
        GlobalVariables.opcode2 = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Buttondot_Click(sender As Object, e As EventArgs) Handles Buttondot.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            GlobalVariables.opcode1 = Convert.ToDouble(TextBox1.Text.ToString())
            GlobalVariables.op = "+"
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        Dim temp As Double
        Try
            temp = Convert.ToDouble(TextBox1.Text.ToString())
            If temp = 0 Then
                TextBox1.Text = "-"
            Else
                GlobalVariables.opcode1 = temp
                GlobalVariables.op = "-"
                TextBox1.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Try
            GlobalVariables.opcode1 = Convert.ToDouble(TextBox1.Text.ToString())
            GlobalVariables.op = "*"
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Try
            GlobalVariables.opcode1 = Convert.ToDouble(TextBox1.Text.ToString())
            GlobalVariables.op = "/"
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonPow_Click(sender As Object, e As EventArgs) Handles ButtonPow.Click
        Try
            GlobalVariables.opcode1 = Convert.ToDouble(TextBox1.Text.ToString())
            GlobalVariables.op = "pow"
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Try
            GlobalVariables.opcode2 = Convert.ToDouble(TextBox1.Text.ToString())
            Dim temp As Double
            Select Case GlobalVariables.op
                Case = "+"
                    temp = GlobalVariables.opcode1 + GlobalVariables.opcode2
                    TextBox1.Text = temp
                    GlobalVariables.opcode1 = temp
                Case = "-"
                    temp = GlobalVariables.opcode1 - GlobalVariables.opcode2
                    TextBox1.Text = temp
                    GlobalVariables.opcode1 = temp
                Case = "*"
                    temp = GlobalVariables.opcode1 * GlobalVariables.opcode2
                    TextBox1.Text = temp
                    GlobalVariables.opcode1 = temp
                Case = "/"
                    temp = GlobalVariables.opcode1 / GlobalVariables.opcode2
                    TextBox1.Text = temp
                    GlobalVariables.opcode1 = temp
                Case = "pow"
                    temp = Math.Pow(GlobalVariables.opcode1, GlobalVariables.opcode2)
                    TextBox1.Text = temp
                    GlobalVariables.opcode1 = temp
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSin_Click(sender As Object, e As EventArgs) Handles ButtonSin.Click
        Dim temp As Double
        Try
            temp = Convert.ToDouble(TextBox1.Text.ToString())
            temp = Math.Sin(temp)
            TextBox1.Text = temp

            GlobalVariables.op = Nothing
            GlobalVariables.opcode1 = Nothing
            GlobalVariables.opcode2 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonCos_Click(sender As Object, e As EventArgs) Handles ButtonCos.Click
        Dim temp As Double
        Try
            temp = Convert.ToDouble(TextBox1.Text.ToString())
            temp = Math.Cos(temp)
            TextBox1.Text = temp

            GlobalVariables.op = Nothing
            GlobalVariables.opcode1 = Nothing
            GlobalVariables.opcode2 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonTan_Click(sender As Object, e As EventArgs) Handles ButtonTan.Click
        Dim temp As Double
        Try
            temp = Convert.ToDouble(TextBox1.Text.ToString())
            temp = Math.Tan(temp)
            TextBox1.Text = temp

            GlobalVariables.op = Nothing
            GlobalVariables.opcode1 = Nothing
            GlobalVariables.opcode2 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSqrt_Click(sender As Object, e As EventArgs) Handles ButtonSqrt.Click
        Dim temp As Double
        Try
            temp = Convert.ToDouble(TextBox1.Text.ToString())
            temp = Math.Sqrt(temp)
            TextBox1.Text = temp

            GlobalVariables.op = Nothing
            GlobalVariables.opcode1 = Nothing
            GlobalVariables.opcode2 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

Public Class GlobalVariables
    Public Shared opcode1 As Double
    Public Shared op As String
    Public Shared opcode2 As Double
End Class
