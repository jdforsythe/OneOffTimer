OneOffTimer
===========

Easily create a single-use timer to execute a Sub() after a specified number of milliseconds in VB.net

Dependencies
------------
None

Usage
-----

    '' Dim wait as New OneOffTimer(millisecondsToWait, AddressOf SubToExecuteWhenComplete)
     
    Public Sub doSomething()
        Console.Writeline("Timer has expired")
    End Sub
     
    Dim wait As New OneOffTimer(1000, doSomething)
    
If you need to do something with the UI, since this works in a background thread you'll need to use Invoke

    Public Sub doSomethingInUI()
        ' DOES NOT WORK
        ' uiTxtName.Text = "John"
         
        ' WORKS
        Invoke(Sub() uiTxtName.Text = "John")
    End Sub
   
If you need to use the Sub() for other things, you can just check InvokeRequired

    Public Sub doSomethingInUI()
        If InvokeRequired Then
            Invoke(Sub() uiTxtName.Text = "John"
        Else
            uiTxtName.Text = "John"
        End If
    End Sub
