﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PaintControl1 = New PaintBoard.PaintControl()
        Me.SuspendLayout()
        '
        'PaintControl1
        '
        Me.PaintControl1.BackColor = System.Drawing.Color.White
        Me.PaintControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaintControl1.Location = New System.Drawing.Point(0, 0)
        Me.PaintControl1.Name = "PaintControl1"
        Me.PaintControl1.Size = New System.Drawing.Size(526, 343)
        Me.PaintControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 343)
        Me.Controls.Add(Me.PaintControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaintControl1 As PaintControl
End Class
