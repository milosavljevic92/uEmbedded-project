Public Class NotifierEventArghs
    Inherits EventArgs

    Private ReadOnly m_notifier As String

    Public ReadOnly Property NotifierValue As String
        Get
            Return Me.m_notifier
        End Get
    End Property

    Public Sub New(ByVal Notifier As String)
        Me.m_notifier = Notifier
    End Sub
End Class
