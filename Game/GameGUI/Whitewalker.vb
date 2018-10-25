Public Class WhiteWalker
    Inherits Enemy

    Sub New()
        strName = "WhiteWalker"
        Attacks(0) = "Eat Brains"
        Attacks(1) = "Claw"
        Attacks(2) = "Throw Up"
        AttackDamage(0) = 15
        AttackDamage(1) = 8
        AttackDamage(2) = 10
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
                userHealth -= AttackDamage(3)
        End Select
    End Sub

End Class
