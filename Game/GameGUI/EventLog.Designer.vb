﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventLog
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
        Me.ListEvent = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListEvent
        '
        Me.ListEvent.BackColor = System.Drawing.Color.Black
        Me.ListEvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEvent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEvent.ForeColor = System.Drawing.Color.Lime
        Me.ListEvent.FormattingEnabled = True
        Me.ListEvent.ItemHeight = 23
        Me.ListEvent.Location = New System.Drawing.Point(0, 0)
        Me.ListEvent.Name = "ListEvent"
        Me.ListEvent.Size = New System.Drawing.Size(759, 462)
        Me.ListEvent.TabIndex = 0
        '
        'EventLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 462)
        Me.Controls.Add(Me.ListEvent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EventLog"
        Me.Text = "EventLog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListEvent As ListBox
End Class
