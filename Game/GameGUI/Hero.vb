Public Class Hero
    Public Const Name As String = "Hero Daenerys"
    Public Shared startHealth As Integer = 250
    Public attackNum As Integer
    Private intHealth As Integer = startHealth
    Public hasSpinach As Boolean = False
    Public ReadOnly Attacks() As String = {"Power Threanten", "Kick", "Dragon Call"}
    Public ReadOnly AttackDamage() As Integer = {5, 10, 15}

    Public Sub Attack(ByRef enemyHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 3)
        Select Case attackNum
            Case 0
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 1
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 2
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
        End Select

    End Sub

    Public Property Health() As Integer
        Set(ByVal value As Integer)
            intHealth = value
        End Set
        Get
            Return intHealth
        End Get
    End Property


End Class
