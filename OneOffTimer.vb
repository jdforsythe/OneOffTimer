Imports System.Timers
Public Class OneOffTimer
    Private Shared oneTimer As Timer
    Private _f As Action

    Sub New(ByVal milliseconds As Double, ByRef f As Action)
        oneTimer = New Timer(milliseconds)
        _f = f
        '' hook up the fire event
        AddHandler oneTimer.Elapsed, AddressOf fire
        oneTimer.Enabled = True
    End Sub

    Private Sub fire(ByVal source As Object, e As ElapsedEventArgs)
        oneTimer.Enabled = False
        _f()
    End Sub
End Class
