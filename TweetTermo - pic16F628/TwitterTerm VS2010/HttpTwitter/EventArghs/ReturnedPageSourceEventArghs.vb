Public Class ReturnedPageSourceEventArghs
    Inherits EventArgs

    Private ReadOnly m_returnedPageSource As String

    Public ReadOnly Property ReturnedPageSourceValue As String
        Get
            Return Me.m_returnedPageSource
        End Get
    End Property

    Public Sub New(ByVal ReturnedPageSource As String)
        Me.m_returnedPageSource = ReturnedPageSource
    End Sub
End Class
