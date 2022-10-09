' *********************************************************************
' *
' * Simple Coders Team
' * __________________________________________________________________
' *
' * Author: ident/Sam
' * Copyright © 2013 simplecoders.com. All rights reserved.
' * Created: 13/02/2013
' * Contact: ident@simplecoders.com
' * A basic implementation of using the HttWebRequest class that connects
' * to Twitter.com.
' * 
' *
' * __________________________________________________________________
' * 
' * Notice: Simple Coders products are freeware and can be  
' * modified, and redistributed under the terms of the GNU  
' * lesser general public license as published by the Free  
'  * Software Foundation; Version 3, 29 June 2007 or later.  
' *********************************************************************

''' <summary>
''' Raises all information accordingly to the status label.
''' </summary>
''' <remarks></remarks>

Public Class NotifierHandler

    ''' <summary>
    ''' Represents the method that will handle the <see cref="NotifierHandler.Notifies">PostData</see> event of <see cref="Notifies" />.
    ''' </summary>
    ''' <remarks >
    ''' Notifies the current session state.
    ''' </remarks>
    Public Event Notifies As EventHandler(Of NotifierEventArghs)

    ''' <summary>
    ''' Raises the Notifies event.
    ''' </summary>
    ''' <param name="e">The Event Arguments.</param>
    Protected Overridable Sub OnNotifier(ByVal e As NotifierEventArghs)
        RaiseEvent Notifies(Me, e)
    End Sub

    ''' <summary>
    ''' Displays an message that the login was successful.
    ''' </summary>
    Public Sub ShowLoginSuccess()
        Dim message As String = "Ulogovan!"
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an message that the session is already active.
    ''' </summary>
    Public Sub ShowSessionActive()
        Dim message As String = "Sesija je već aktivna."
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an message that the tweet was posted.
    ''' </summary>
    Public Sub ShowTweetSuccess()
        Dim message As String = "Tweet poslat!"
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an message that the tweet has already been posted.
    ''' </summary>
    Public Sub ShowTweetAlreadyPosted()
        Dim message As String = "Whoops! You already said that... please post a new tweet."
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an message that the session has ended.
    ''' </summary>
    Public Sub ShowLoggedOut()
        Dim message As String = "Ne postoji sesija!"
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    Public Sub Exception(ByVal ex As Exception)
        Dim message As String = String.Format("ERROR: Unknown Exception ({0}).", ex.Message)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the form authenticity key could not be obtained.
    ''' </summary>
    Public Sub ShowFormAuthKeyFail()
        Dim message As String = "Greška sa tokenom!"
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the form url is invalid.
    ''' </summary>
    Public Sub ShowUrlInvalid(ByVal Url As String)
        Dim message As String = String.Format("The URI string '{0}' is invalid.", Url)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the form Href is invalid.
    ''' </summary>
    Public Sub ShowHrefInvalid(ByVal Href As String)
        Dim message As String = String.Format("The relative URI string '{0}' is invalid.", Href)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the request Failed.
    ''' </summary>
    Public Sub ShowRequestFailed(ByVal uri As String)
        Dim message As String = String.Format("Failed to create HttpWebRequest for '{0}'.", uri)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the request failed.
    ''' </summary>
    Public Sub ShowRequestFailedReturnedStatus(ByVal uri As String, ByVal status As String)
        Dim message As String = String.Format("Request from '{0}' returned Status '{1}'.", uri, status)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the response failed.
    ''' </summary>
    Public Sub ShowResponseFailed(ByVal uri As String)
        Dim message As String = String.Format("Failed to get response from '{0}'.", uri)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the response status code is bad.
    ''' </summary>
    Public Sub ShowResponseIsBad(ByVal uri As String, ByVal code As Integer, ByVal status As String)
        Dim message As String = String.Format("Request from '{0}' returned StatusCode '{1}' ({2})", uri, code, status)
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub

    ''' <summary>
    ''' Displays an error message that indicates the login has failed.
    ''' </summary>
    Public Sub ShowLoginError()
        Dim message As String = "WRONG User - pass!"
        Me.OnNotifier(New NotifierEventArghs(message))
    End Sub
End Class

