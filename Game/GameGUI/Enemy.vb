Public Class Enemy
    Public Shared startHealth As Integer = 100
    Public strName As String
    Public attackNum As Integer
    Private IntHeath As Integer
    Public ReadOnly Attacks(3) As String
    Public ReadOnly AttackDamage(3) As String
    Sub New()
        IntHeath = startHealth
    End Sub

    Public Overridable Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 1)
        Select Case attackNum
            Case 0
                userHealth -= 1
            Case 1
                userHealth -= 2
        End Select
    End Sub

    Public Property Health() As Integer
        Get
            Return IntHeath
        End Get
        Set(ByVal value As Integer)
            IntHeath = value
        End Set
    End Property

End Class
