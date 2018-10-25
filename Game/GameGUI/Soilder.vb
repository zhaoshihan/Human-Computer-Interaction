Public Class Soilder
    Inherits Enemy

    Sub New()
        strName = "Soilder"
        Attacks(0) = "Sword Drop"
        Attacks(1) = "Spear Hit"
        Attacks(2) = "Archery Hit"
        AttackDamage(0) = 10
        AttackDamage(1) = 5
        AttackDamage(2) = 2
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
