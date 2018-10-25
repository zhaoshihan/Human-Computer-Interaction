<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Attack = New System.Windows.Forms.Button()
        Me.ProgressBarPopeye = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarEnemy = New System.Windows.Forms.ProgressBar()
        Me.SpawnEnemy = New System.Windows.Forms.Button()
        Me.SpinachLeft = New System.Windows.Forms.Label()
        Me.TimerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.CheckSpinach = New System.Windows.Forms.CheckBox()
        Me.LabelPopeyeHealth = New System.Windows.Forms.Label()
        Me.LabelEnemyHealth = New System.Windows.Forms.Label()
        Me.PictureEnemy = New System.Windows.Forms.PictureBox()
        Me.PicturePopeye = New System.Windows.Forms.PictureBox()
        Me.btnLogShowAndHide = New System.Windows.Forms.Button()
        CType(Me.PictureEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePopeye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Attack
        '
        Me.Attack.Location = New System.Drawing.Point(48, 12)
        Me.Attack.Name = "Attack"
        Me.Attack.Size = New System.Drawing.Size(116, 28)
        Me.Attack.TabIndex = 2
        Me.Attack.Text = "Attack"
        Me.Attack.UseVisualStyleBackColor = True
        '
        'ProgressBarPopeye
        '
        Me.ProgressBarPopeye.Location = New System.Drawing.Point(48, 309)
        Me.ProgressBarPopeye.Maximum = 250
        Me.ProgressBarPopeye.Name = "ProgressBarPopeye"
        Me.ProgressBarPopeye.Size = New System.Drawing.Size(236, 33)
        Me.ProgressBarPopeye.TabIndex = 3
        '
        'ProgressBarEnemy
        '
        Me.ProgressBarEnemy.Location = New System.Drawing.Point(463, 309)
        Me.ProgressBarEnemy.Name = "ProgressBarEnemy"
        Me.ProgressBarEnemy.Size = New System.Drawing.Size(229, 33)
        Me.ProgressBarEnemy.TabIndex = 4
        '
        'SpawnEnemy
        '
        Me.SpawnEnemy.Location = New System.Drawing.Point(463, 13)
        Me.SpawnEnemy.Name = "SpawnEnemy"
        Me.SpawnEnemy.Size = New System.Drawing.Size(229, 27)
        Me.SpawnEnemy.TabIndex = 5
        Me.SpawnEnemy.Text = "Spawn Enemy"
        Me.SpawnEnemy.UseVisualStyleBackColor = True
        '
        'SpinachLeft
        '
        Me.SpinachLeft.AutoSize = True
        Me.SpinachLeft.Location = New System.Drawing.Point(189, 36)
        Me.SpinachLeft.Name = "SpinachLeft"
        Me.SpinachLeft.Size = New System.Drawing.Size(95, 12)
        Me.SpinachLeft.TabIndex = 7
        Me.SpinachLeft.Text = "Spinach Left: 3"
        '
        'TimerDelay
        '
        '
        'CheckSpinach
        '
        Me.CheckSpinach.AutoSize = True
        Me.CheckSpinach.Location = New System.Drawing.Point(191, 12)
        Me.CheckSpinach.Name = "CheckSpinach"
        Me.CheckSpinach.Size = New System.Drawing.Size(90, 16)
        Me.CheckSpinach.TabIndex = 8
        Me.CheckSpinach.Text = "Use Spinach"
        Me.CheckSpinach.UseVisualStyleBackColor = True
        '
        'LabelPopeyeHealth
        '
        Me.LabelPopeyeHealth.AutoSize = True
        Me.LabelPopeyeHealth.Location = New System.Drawing.Point(48, 360)
        Me.LabelPopeyeHealth.Name = "LabelPopeyeHealth"
        Me.LabelPopeyeHealth.Size = New System.Drawing.Size(41, 12)
        Me.LabelPopeyeHealth.TabIndex = 9
        Me.LabelPopeyeHealth.Text = "Health"
        '
        'LabelEnemyHealth
        '
        Me.LabelEnemyHealth.AutoSize = True
        Me.LabelEnemyHealth.Location = New System.Drawing.Point(461, 360)
        Me.LabelEnemyHealth.Name = "LabelEnemyHealth"
        Me.LabelEnemyHealth.Size = New System.Drawing.Size(41, 12)
        Me.LabelEnemyHealth.TabIndex = 10
        Me.LabelEnemyHealth.Text = "Health"
        '
        'PictureEnemy
        '
        Me.PictureEnemy.ErrorImage = Nothing
        Me.PictureEnemy.Image = Global.GameGUI.My.Resources.Resources.soilder
        Me.PictureEnemy.InitialImage = CType(resources.GetObject("PictureEnemy.InitialImage"), System.Drawing.Image)
        Me.PictureEnemy.Location = New System.Drawing.Point(463, 57)
        Me.PictureEnemy.Name = "PictureEnemy"
        Me.PictureEnemy.Size = New System.Drawing.Size(229, 225)
        Me.PictureEnemy.TabIndex = 1
        Me.PictureEnemy.TabStop = False
        '
        'PicturePopeye
        '
        Me.PicturePopeye.Image = Global.GameGUI.My.Resources.Resources.hero
        Me.PicturePopeye.Location = New System.Drawing.Point(48, 57)
        Me.PicturePopeye.Name = "PicturePopeye"
        Me.PicturePopeye.Size = New System.Drawing.Size(236, 225)
        Me.PicturePopeye.TabIndex = 0
        Me.PicturePopeye.TabStop = False
        '
        'btnLogShowAndHide
        '
        Me.btnLogShowAndHide.Location = New System.Drawing.Point(48, 399)
        Me.btnLogShowAndHide.Name = "btnLogShowAndHide"
        Me.btnLogShowAndHide.Size = New System.Drawing.Size(644, 38)
        Me.btnLogShowAndHide.TabIndex = 11
        Me.btnLogShowAndHide.Text = "Hide Log"
        Me.btnLogShowAndHide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 462)
        Me.Controls.Add(Me.btnLogShowAndHide)
        Me.Controls.Add(Me.LabelEnemyHealth)
        Me.Controls.Add(Me.LabelPopeyeHealth)
        Me.Controls.Add(Me.CheckSpinach)
        Me.Controls.Add(Me.SpinachLeft)
        Me.Controls.Add(Me.SpawnEnemy)
        Me.Controls.Add(Me.ProgressBarEnemy)
        Me.Controls.Add(Me.ProgressBarPopeye)
        Me.Controls.Add(Me.Attack)
        Me.Controls.Add(Me.PictureEnemy)
        Me.Controls.Add(Me.PicturePopeye)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePopeye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureEnemy As PictureBox
    Friend WithEvents Attack As Button
    Friend WithEvents ProgressBarPopeye As ProgressBar
    Friend WithEvents ProgressBarEnemy As ProgressBar
    Friend WithEvents PicturePopeye As PictureBox
    Friend WithEvents SpawnEnemy As Button
    Friend WithEvents SpinachLeft As Label
    Friend WithEvents TimerDelay As Timer
    Friend WithEvents CheckSpinach As CheckBox
    Friend WithEvents LabelPopeyeHealth As Label
    Friend WithEvents LabelEnemyHealth As Label
    Friend WithEvents btnLogShowAndHide As Button
End Class
