Public Class EventLog
    Public Sub addEvent(ByVal strEvent As String)
        ListEvent.Items.Add(strEvent)
    End Sub

    Private Sub EventLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListEvent.Items.Add("Event Logger Has Successfully Loaded")
        ListEvent.Items.Add("------------------------------------")
    End Sub
End Class