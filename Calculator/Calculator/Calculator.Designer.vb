<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ButtonAC = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Buttondot = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonSin = New System.Windows.Forms.Button()
        Me.ButtonCos = New System.Windows.Forms.Button()
        Me.ButtonTan = New System.Windows.Forms.Button()
        Me.ButtonSqrt = New System.Windows.Forms.Button()
        Me.ButtonPow = New System.Windows.Forms.Button()
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(59, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(281, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(86, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(153, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 36)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(22, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 36)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(86, 144)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(42, 36)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(153, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 36)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(22, 197)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(42, 36)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(86, 197)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(42, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(153, 197)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(42, 36)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ButtonAC
        '
        Me.ButtonAC.Location = New System.Drawing.Point(22, 252)
        Me.ButtonAC.Name = "ButtonAC"
        Me.ButtonAC.Size = New System.Drawing.Size(42, 36)
        Me.ButtonAC.TabIndex = 10
        Me.ButtonAC.Text = "EC"
        Me.ButtonAC.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(86, 252)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(42, 36)
        Me.Button0.TabIndex = 11
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Buttondot
        '
        Me.Buttondot.Location = New System.Drawing.Point(153, 252)
        Me.Buttondot.Name = "Buttondot"
        Me.Buttondot.Size = New System.Drawing.Size(42, 36)
        Me.Buttondot.TabIndex = 12
        Me.Buttondot.Text = "."
        Me.Buttondot.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(285, 91)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(42, 36)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Location = New System.Drawing.Point(346, 91)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(42, 36)
        Me.ButtonMinus.TabIndex = 14
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(404, 91)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonMultiply.Size = New System.Drawing.Size(42, 36)
        Me.ButtonMultiply.TabIndex = 15
        Me.ButtonMultiply.Text = "*"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(285, 144)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(42, 36)
        Me.ButtonDivide.TabIndex = 16
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonSin
        '
        Me.ButtonSin.Location = New System.Drawing.Point(346, 144)
        Me.ButtonSin.Name = "ButtonSin"
        Me.ButtonSin.Size = New System.Drawing.Size(42, 36)
        Me.ButtonSin.TabIndex = 17
        Me.ButtonSin.Text = "sin"
        Me.ButtonSin.UseVisualStyleBackColor = True
        '
        'ButtonCos
        '
        Me.ButtonCos.Location = New System.Drawing.Point(404, 144)
        Me.ButtonCos.Name = "ButtonCos"
        Me.ButtonCos.Size = New System.Drawing.Size(42, 36)
        Me.ButtonCos.TabIndex = 18
        Me.ButtonCos.Text = "cos"
        Me.ButtonCos.UseVisualStyleBackColor = True
        '
        'ButtonTan
        '
        Me.ButtonTan.Location = New System.Drawing.Point(285, 197)
        Me.ButtonTan.Name = "ButtonTan"
        Me.ButtonTan.Size = New System.Drawing.Size(42, 36)
        Me.ButtonTan.TabIndex = 19
        Me.ButtonTan.Text = "tan"
        Me.ButtonTan.UseVisualStyleBackColor = True
        '
        'ButtonSqrt
        '
        Me.ButtonSqrt.Location = New System.Drawing.Point(346, 197)
        Me.ButtonSqrt.Name = "ButtonSqrt"
        Me.ButtonSqrt.Size = New System.Drawing.Size(42, 36)
        Me.ButtonSqrt.TabIndex = 20
        Me.ButtonSqrt.Text = "sqrt"
        Me.ButtonSqrt.UseVisualStyleBackColor = True
        '
        'ButtonPow
        '
        Me.ButtonPow.Location = New System.Drawing.Point(404, 197)
        Me.ButtonPow.Name = "ButtonPow"
        Me.ButtonPow.Size = New System.Drawing.Size(42, 36)
        Me.ButtonPow.TabIndex = 21
        Me.ButtonPow.Text = "pow"
        Me.ButtonPow.UseVisualStyleBackColor = True
        '
        'ButtonEqual
        '
        Me.ButtonEqual.Location = New System.Drawing.Point(285, 252)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(161, 36)
        Me.ButtonEqual.TabIndex = 22
        Me.ButtonEqual.Text = "="
        Me.ButtonEqual.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 320)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.ButtonPow)
        Me.Controls.Add(Me.ButtonSqrt)
        Me.Controls.Add(Me.ButtonTan)
        Me.Controls.Add(Me.ButtonCos)
        Me.Controls.Add(Me.ButtonSin)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Buttondot)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.ButtonAC)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonAC As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Buttondot As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonSin As Button
    Friend WithEvents ButtonCos As Button
    Friend WithEvents ButtonTan As Button
    Friend WithEvents ButtonSqrt As Button
    Friend WithEvents ButtonPow As Button
    Friend WithEvents ButtonEqual As Button
End Class
