Public Class AuthenticityTokenEventArghs
    Inherits EventArgs

    Private ReadOnly m_formAuthenticityToken As String

    Public ReadOnly Property AuthenticityTokenValue As String
        Get
            Return Me.m_formAuthenticityToken
        End Get
    End Property

    Public Sub New(ByVal FormAuthenticityToken As String)
        Me.m_formAuthenticityToken = FormAuthenticityToken
    End Sub
End Class
