

''' <summary>
''' Sends all notified messages to the status label.
''' </summary>
''' <remarks></remarks>

Public Class MessageDisplay
    Implements IMessageDisplay

    Public Sub Display(ByVal Status As StatusStrip,
                       ByVal Label As ToolStripStatusLabel,
                       ByVal Message As String) Implements IMessageDisplay.Display

        If Status.InvokeRequired Then
            Status.Invoke(New Action(Of StatusStrip, 
                                     ToolStripStatusLabel,
                                     String)(AddressOf Display), Status, Label, Message)
        Else
            Label.Text = Message
        End If
    End Sub
End Class