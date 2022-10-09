Public Class tSourceEventArghs
    Inherits EventArgs

    Private ReadOnly m_source As String

    Public ReadOnly Property SourceValue As String
        Get
            Return Me.m_source
        End Get
    End Property

    Public Sub New(ByVal Source As String)
        Me.m_source = Source
    End Sub
End Class
