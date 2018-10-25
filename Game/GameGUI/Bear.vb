Public Class Bear
    Inherits Enemy
    Sub New()
        strName = "Bear"
        Attacks(0) = "Claw"
        Attacks(1) = "Tear"
        Attacks(2) = "Hand Strike"
        AttackDamage(0) = 10
        AttackDamage(1) = 8
        AttackDamage(2) = 12
    End Sub

    Public Overrides Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 3)
        Select Case attackNum
            Case 0
                userHealth -= AttackDamage(0)
            Case 1
                userHealth -= AttackDamage(1)
            Case 2
                userHealth -= AttackDamage(2)
        End Select
    End Sub

End Class
