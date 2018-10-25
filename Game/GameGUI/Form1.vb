Public Class Form1
    Private currentEnemy As GameGUI.Enemy
    Private Hero As New Hero
    Private IntSpinach As Integer = 3
    Private newlog As New EventLog
    Private logShown As Boolean = True

    Private Sub SpawnEnemy_Click(sender As Object, e As EventArgs) Handles SpawnEnemy.Click
        GenerateEnemy()
    End Sub

    Private Sub GenerateEnemy()
        Dim generator As New Random
        Dim enemyType As Integer = generator.Next(1, 4)
        Select Case enemyType
            Case 1
                If Not PictureEnemy.Image.Equals(My.Resources.whitewalker) Then
                    currentEnemy = New GameGUI.Whitewalker
                    ProgressBarEnemy.Value = Enemy.startHealth
                    PictureEnemy.Image = My.Resources.whitewalker
                Else
                    GenerateEnemy()
                End If
            Case 2
                If Not PictureEnemy.Image.Equals(My.Resources.bear) Then
                    currentEnemy = New GameGUI.Bear
                    ProgressBarEnemy.Value = Enemy.startHealth
                    PictureEnemy.Image = My.Resources.bear
                Else
                    GenerateEnemy()
                End If

            Case 3
                If Not PictureEnemy.Image.Equals(My.Resources.soilder) Then
                    currentEnemy = New GameGUI.Soilder
                    ProgressBarEnemy.Value = Enemy.startHealth
                    PictureEnemy.Image = My.Resources.soilder
                Else
                    GenerateEnemy()
                End If
        End Select
        updateEnemyHealth()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newlog.Show()
        newlog.Location = New Point(Me.Location.X, Me.Location.Y + Me.Size.Height)
        updatePopeyeHealth()
        GenerateEnemy()
    End Sub

    Private Sub Attack_Click(sender As Object, e As EventArgs) Handles Attack.Click
        If IntSpinach = 0 Then
            CheckSpinach.Checked = False
            CheckSpinach.Enabled = False
        End If

        If CheckSpinach.Checked = True And IntSpinach > 0 Then
            Hero.hasSpinach = True
            IntSpinach -= 1
            SpinachLeft.Text = "Spinach Left: " & IntSpinach.ToString
        End If
        Hero.Attack(currentEnemy.Health)
        newlog.addEvent(createEvent(Hero.Name))
        Hero.hasSpinach = False
        Try
            updateEnemyHealth()
            TimerDelay.Start()
        Catch ex As Exception
            ProgressBarEnemy.Value = 0
            MessageBox.Show("Hero has Won!")
            newlog.addEvent("---------------")
            newlog.addEvent("Hero has Won!")
            newlog.addEvent("---------------")
            GenerateEnemy()
        End Try
    End Sub

    Private Sub TimerDelay_Tick(sender As Object, e As EventArgs) Handles TimerDelay.Tick
        EnemyAttack()
    End Sub

    Private Sub EnemyAttack()
        currentEnemy.Attack(Hero.Health)
        newlog.addEvent(createEvent(currentEnemy.strName))
        TimerDelay.Stop()
        Try
            updatePopeyeHealth()
        Catch ex As Exception
            ProgressBarPopeye.Value = 0
            MessageBox.Show("Hero has lost!")
            newlog.addEvent("---------------")
            newlog.addEvent("Hero has Lost!")
            newlog.addEvent("---------------")
            Hero.Health = Hero.startHealth
            updatePopeyeHealth()
        End Try
    End Sub

    Private Sub updateEnemyHealth()
        If currentEnemy.Health = 0 Then
            Throw New Exception
        End If
        ProgressBarEnemy.Value = currentEnemy.Health
        LabelEnemyHealth.Text = "Health: " & currentEnemy.Health

    End Sub

    Private Sub updatePopeyeHealth()
        If Hero.Health = 0 Then
            Throw New Exception
        End If
        ProgressBarPopeye.Value = Hero.Health
        LabelPopeyeHealth.Text = "Health: " & Hero.Health
    End Sub

    Private Function createEvent(ByVal strName As String) As String
        If strName = Hero.Name Then
            Dim damage As Integer = Hero.AttackDamage(Hero.attackNum)
            If Hero.hasSpinach Then
                damage *= 2
            End If

            Return strName + " has used " + "[" + Hero.Attacks(Hero.attackNum) + "] for [" + damage.ToString + "] damage"

        Else
            Return strName + " has used " + "[" + currentEnemy.Attacks(currentEnemy.attackNum).ToString + "] for [" + currentEnemy.AttackDamage(currentEnemy.attackNum).ToString + "] damage"
        End If
    End Function

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        newlog.Location = New Point(Me.Location.X, Me.Location.Y + Me.Size.Height)
    End Sub

    Private Sub btnLogShowAndHide_Click(sender As Object, e As EventArgs) Handles btnLogShowAndHide.Click
        If logShown Then
            logShown = False
            newlog.Hide()
            btnLogShowAndHide.Text = "Show Log"

        Else
            logShown = True
            newlog.Show()
            btnLogShowAndHide.Text = "Hide Log"
        End If
    End Sub
End Class
