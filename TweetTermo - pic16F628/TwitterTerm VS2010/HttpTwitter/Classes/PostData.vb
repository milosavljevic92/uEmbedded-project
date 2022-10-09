' *********************************************************************
' *
' * Simple Coders Team
' * __________________________________________________________________
' *
' * Author: ident/Sam/Roger
' * Copyright © 2013 simplecoders.com. All rights reserved.
' * Created: 15/02/1013
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

Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text
Imports System.Text.RegularExpressions


''' <summary>
''' Connects to the request server performing the requested tasks
''' and appropriate validation.
''' </summary>
''' <remarks></remarks>

Public Class PostData

#Region " Constant "
    ''' <summary>
    ''' Returns the servers error request page information HTML index.
    ''' </summary>
    ''' <remarks></remarks>
    Private Const UNKNOWN_PAGE_RETURNED As String = "<p id=""post-error"" role=""alert"" class=""error notice"">"
#End Region ' Constant

#Region " Private Members "
    ''' <summary>
    ''' The value of the User-agent HTTP header. The default value is Nothing.
    ''' </summary>
    Private ReadOnly m_userAgent As String = "Mozilla/5.0 (Windows NT 5.1; rv:19.0) Gecko/20100101 Firefox/19.0"

    ''' <summary>
    ''' The number of milliseconds to wait before the request times out. The default value is 100,000 milliseconds (100 seconds).
    ''' </summary>
    Private ReadOnly m_timeoutSeconds As Integer = 30

    ''' <summary>
    ''' The URL of the web application. Passed to the constructor during initialization.
    ''' </summary>
    Private ReadOnly m_forumUrl As String

    ''' <summary>
    ''' The request method to use to contact the Internet resource. The default value is GET.
    ''' </summary>
    Private ReadOnly m_formMethod As String = "Post"

    ''' <summary>
    ''' The form's authenticity token.
    ''' </summary>
    ''' <remarks></remarks>
    Private m_formAuthenticityToken As String

    ''' <summary>
    ''' A CookieContainer that contains the cookies associated with this request.
    ''' </summary>
    Private m_cookies As CookieContainer

    ''' <summary>
    ''' Details about the last notified message experienced.
    ''' </summary>
    Private m_notifierHandler As NotifierHandler
#End Region ' Private Members

#Region " Constructor "
    ''' <summary>
    ''' Creates a new instance of the <see cref="PostData" /> Class.
    ''' </summary>
    ''' <param name="ForumUrl">The web applications url.</param>
    ''' <param name="Exceptionhandler">Exception handling object.</param>
    Public Sub New(ByVal ForumUrl As String,
                   ByVal Exceptionhandler As NotifierHandler)
        Me.m_forumUrl = ForumUrl
        m_notifierHandler = Exceptionhandler
    End Sub
#End Region ' Constructor

#Region " Regular Expressions "
    Private Shared ReadOnly m_authenticityTokenPattern As String = "(?<=twttr.form_authenticity_token = ').+(?=';)"
    Private Shared ReadOnly m_AuthenticityTokenMatch As New Regex(m_authenticityTokenPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Private Shared ReadOnly m_loginErrorPattern As String = "Invalid user name or password"
    Private Shared ReadOnly m_loginErrorMatch As New Regex(m_loginErrorPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Private Shared ReadOnly m_loginSuccessPattern As String = "(?<=<body class="").+(?="" dir=""ltr"">)"
    Private Shared ReadOnly m_loginSuccessMatch As New Regex(m_loginSuccessPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Private Shared ReadOnly m_logoutSuccessPattern As String = "You’ve signed out of Twitter."
    Private Shared ReadOnly m_logoutSuccessMatch As New Regex(m_logoutSuccessPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Private Shared ReadOnly m_tweetSuccessPattern As String = "Your Tweet has been posted!"
    Private Shared ReadOnly m_tweetSuccessMatch As New Regex(m_tweetSuccessPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Private Shared ReadOnly m_idPattern As String = "(?<=<style id=""user-style-).+(?="" class=""js-user-style"">)"
    Private Shared ReadOnly m_idMatch As New Regex(m_idPattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
#End Region ' Regular Expressions

#Region " Post Data Patterns "
    Private Shared ReadOnly m_formLoginAction As String = "authenticity_token={0}&return_to=&source=&session[username_or_email]={1}&session[password]={2}&remember_me={3}"
    Private Shared ReadOnly m_formLogoutAction As String = "authenticity_token={0}&reliability_event=&scribe_log="
    Private Shared ReadOnly m_formTweetAction As String = "authenticity_token={0}&status={1}"
#End Region ' Post Data Patterns

#Region " Relative URLs "
    Private Shared ReadOnly m_loginHref As String = "intent/session"
    Private Shared ReadOnly m_logoutHref As String = "logout"
    Private Shared ReadOnly m_tweetHref As String = "intent/tweet/update"
#End Region ' Relative URLs

#Region " Events "
    ''' <summary>
    ''' Represents the method that will handle the <see cref="PostData.AuthenticityToken">PostData</see> event of <see cref="AuthenticityToken" />.
    ''' </summary>
    ''' <remarks >
    ''' Displays all relative post data patterns including authenticity token.
    ''' </remarks>
    Public Event AuthenticityToken As EventHandler(Of AuthenticityTokenEventArghs)

    ''' <summary>
    ''' Represents the method that will handle the <see cref="PostData.ReturnedPageSource">PostData</see> event of <see cref="ReturnedPageSource" />.
    ''' </summary>
    ''' <remarks >
    ''' The most recent HTML source retrieved from the server.
    ''' </remarks>
    Public Event ReturnedPageSource As EventHandler(Of ReturnedPageSourceEventArghs)

    ''' <summary>
    ''' Represents the method that will handle the <see cref="PostData.LoggedOut">PostData</see> event of <see cref="LoggedOut" />.
    ''' </summary>
    ''' <remarks>
    ''' Notifies the session has been cleared.
    ''' </remarks>
    Public Event LoggedOut As EventHandler
#End Region ' Events

#Region " Overridable Events "
    Protected Overridable Sub OnAuthenticityToken(ByVal e As AuthenticityTokenEventArghs)
        RaiseEvent AuthenticityToken(Me, e)
    End Sub

    Protected Overridable Sub OnReturnedPageSource(ByVal e As ReturnedPageSourceEventArghs)
        RaiseEvent ReturnedPageSource(Me, e)
    End Sub

    Protected Overridable Sub OnLoggedOut(ByVal e As EventArgs)
        RaiseEvent LoggedOut(Me, e)
    End Sub
#End Region ' Overridable Events

#Region " Methods "
    ''' <summary>
    ''' Attempts to login to the server with the supplied username and password.
    ''' </summary>
    ''' <param name="UserName">PlainText username</param>
    ''' <param name="Password">PlainText Password</param>
    ''' <param name="RememberMe">If true, the user will be remembered by the server.</param>
    Public Sub AttemptLogin(ByVal UserName As String, ByVal Password As String, ByVal RememberMe As Boolean)
        If Not Me.TryGetServerAuthenticityToken(m_loginHref) Then
            Exit Sub
        End If

        Dim loginUri As Uri = Me.GetAbsoluteUri(m_loginHref)

        If loginUri Is Nothing Then
            Exit Sub
        End If

        Dim request As HttpWebRequest = TryCast(HttpWebRequest.Create(loginUri), HttpWebRequest)

        If request Is Nothing Then
            Me.m_notifierHandler.ShowRequestFailed(loginUri.ToString)
            Exit Sub
        End If

        Dim postDataFormatted As String = String.Format(m_formLoginAction,
                                                        HttpUtility.UrlEncode(Me.m_formAuthenticityToken),
                                                        HttpUtility.UrlEncode(UserName),
                                                        HttpUtility.UrlEncode(Password),
                                                        If(RememberMe, 1, 0))
        Dim postDataBuffer As Byte() = Encoding.ASCII.GetBytes(postDataFormatted)

        request.Timeout = Me.m_timeoutSeconds * 1000
        request.Method = Me.m_formMethod
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = postDataBuffer.Length
        request.CookieContainer = Me.m_cookies

        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postDataBuffer, 0, postDataBuffer.Length)
            requestStream.Close()
        End Using

        Dim response As HttpWebResponse

        Try
            response = TryCast(request.GetResponse(), HttpWebResponse)
        Catch wex As WebException
            Me.m_notifierHandler.ShowRequestFailedReturnedStatus(loginUri.ToString, wex.Status.ToString())
            Exit Sub
        Catch ex As Exception
            Me.m_notifierHandler.ShowResponseFailed(loginUri.ToString)
            Exit Sub
        End Try

        If response.StatusCode <> HttpStatusCode.OK Then
            Me.m_notifierHandler.ShowResponseIsBad(loginUri.ToString(), CInt(response.StatusCode), response.StatusCode.ToString())
            Exit Sub
        End If

        Dim source As String

        Using resposeStream As Stream = response.GetResponseStream()
            Using resposeReader As New StreamReader(resposeStream)
                source = resposeReader.ReadToEnd()
            End Using
        End Using

        Me.OnReturnedPageSource(New ReturnedPageSourceEventArghs(source))

        If Not m_loginSuccessMatch.IsMatch(source) Then
            If m_loginErrorMatch.IsMatch(source) Then
                Me.m_notifierHandler.ShowLoginError()
                Exit Sub
            End If
        End If

        Me.OnAuthenticityToken(New AuthenticityTokenEventArghs(Me.m_formAuthenticityToken))
        Me.m_notifierHandler.ShowLoginSuccess()
    End Sub

    ''' <summary>
    ''' Forces a logout of the current session. Regardless of the return value, the session will no longer
    ''' be useable after this call. The use must be logged in again.
    ''' </summary>
    Public Sub AttemptLogout()
        Dim logoutUri As Uri = Me.GetAbsoluteUri(m_logoutHref)

        If logoutUri Is Nothing Then
            Exit Sub
        End If

        Dim request As HttpWebRequest = TryCast(HttpWebRequest.Create(logoutUri), HttpWebRequest)

        If request Is Nothing Then
            Me.m_notifierHandler.ShowRequestFailed(logoutUri.ToString)
            Exit Sub
        End If

        Dim postDataFormatted As String = String.Format(m_formLogoutAction,
                                                        HttpUtility.UrlEncode(Me.m_formAuthenticityToken))
        Dim postDataBuffer As Byte() = Encoding.ASCII.GetBytes(postDataFormatted)

        request.Timeout = Me.m_timeoutSeconds * 1000
        request.Method = Me.m_formMethod
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = postDataBuffer.Length
        request.CookieContainer = Me.m_cookies

        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postDataBuffer, 0, postDataBuffer.Length)
            requestStream.Close()
        End Using

        Dim response As HttpWebResponse

        Try
            response = TryCast(request.GetResponse(), HttpWebResponse)
        Catch wex As WebException
            Me.m_notifierHandler.ShowRequestFailedReturnedStatus(logoutUri.ToString, wex.Status.ToString())
            Exit Sub
        Catch ex As Exception
            Me.m_notifierHandler.ShowResponseFailed(logoutUri.ToString)
            Exit Sub
        End Try

        If response.StatusCode <> HttpStatusCode.OK Then
            Me.m_notifierHandler.ShowResponseIsBad(logoutUri.ToString(), CInt(response.StatusCode), response.StatusCode.ToString())
            Exit Sub
        End If

        Dim source As String

        Using resposeStream As Stream = response.GetResponseStream()
            Using resposeReader As New StreamReader(resposeStream)
                source = resposeReader.ReadToEnd()
            End Using
        End Using

        If Not m_logoutSuccessMatch.IsMatch(source) Then
            Me.m_notifierHandler.Exception(New Exception("Could not log out. Clearing session."))
        End If

        Me.m_notifierHandler.ShowLoggedOut()

        Me.m_cookies = Nothing
        Me.OnReturnedPageSource(New ReturnedPageSourceEventArghs(source))
        Me.OnLoggedOut(EventArgs.Empty)
    End Sub

    Public Sub AttemptTweet(ByVal Message As String)
        Dim tweetUri As Uri = Me.GetAbsoluteUri(m_tweetHref)

        If tweetUri Is Nothing Then
            Exit Sub
        End If

        Dim request As HttpWebRequest = TryCast(HttpWebRequest.Create(tweetUri), HttpWebRequest)

        If request Is Nothing Then
            Me.m_notifierHandler.ShowRequestFailed(tweetUri.ToString)
            Exit Sub
        End If

        Dim postDataFormatted As String = String.Format(m_formTweetAction,
                                                        HttpUtility.UrlDecode(Me.m_formAuthenticityToken),
                                                        HttpUtility.UrlEncode(Message))
        Dim postDataBuffer As Byte() = Encoding.ASCII.GetBytes(postDataFormatted)

        request.Timeout = Me.m_timeoutSeconds * 1000
        request.Method = Me.m_formMethod
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = postDataBuffer.Length
        request.CookieContainer = Me.m_cookies

        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postDataBuffer, 0, postDataBuffer.Length)
            requestStream.Close()
        End Using

        Dim response As HttpWebResponse

        Try
            response = TryCast(request.GetResponse(), HttpWebResponse)
        Catch wex As WebException
            Me.m_notifierHandler.ShowRequestFailedReturnedStatus(tweetUri.ToString, wex.Status.ToString())
            Exit Sub
        Catch ex As Exception
            Me.m_notifierHandler.ShowResponseFailed(tweetUri.ToString)
            Exit Sub
        End Try

        If response.StatusCode <> HttpStatusCode.OK Then
            Me.m_notifierHandler.ShowResponseIsBad(tweetUri.ToString(), CInt(response.StatusCode), response.StatusCode.ToString())
            Exit Sub
        End If

        Dim source As String

        Using resposeStream As Stream = response.GetResponseStream()
            Using resposeReader As New StreamReader(resposeStream)
                source = resposeReader.ReadToEnd()
            End Using
        End Using

        Me.OnReturnedPageSource(New ReturnedPageSourceEventArghs(source))

        If Not m_tweetSuccessMatch.IsMatch(source) Then
            If UnknownPageReturned(source) <> String.Empty Then
                Me.m_notifierHandler.ShowTweetAlreadyPosted()
                Exit Sub
            Else
                Me.m_notifierHandler.Exception(New Exception("Unknown response. Tweet may not of been posted."))
                Exit Sub
            End If
        End If

        Me.m_notifierHandler.ShowTweetSuccess()
    End Sub
#End Region ' Methods

#Region " Validation Functions "
    ''' <summary>
    ''' This gets values from the token page source, such as form authenticity token.
    ''' </summary>
    ''' <param name="tokenHref"></param>
    ''' <returns>True if successful, otherwise false.</returns>
    ''' <remarks></remarks>
    Public Function TryGetServerAuthenticityToken(ByVal tokenHref As String) As Boolean

        Me.m_cookies = New CookieContainer

        Dim tokenUri As Uri = Me.GetAbsoluteUri(tokenHref)

        If tokenUri Is Nothing Then
            Return False
        End If

        Dim tokenRequest As HttpWebRequest = TryCast(HttpWebRequest.Create(tokenUri), HttpWebRequest)

        If tokenRequest Is Nothing Then
            Me.m_notifierHandler.ShowRequestFailed(tokenUri.ToString)
        End If

        tokenRequest.Timeout = Me.m_timeoutSeconds * 1000
        tokenRequest.CookieContainer = Me.m_cookies

        Dim tokenResponse As HttpWebResponse

        Try
            tokenResponse = TryCast(tokenRequest.GetResponse(), HttpWebResponse)
        Catch wex As WebException
            Me.m_notifierHandler.ShowRequestFailedReturnedStatus(tokenUri.ToString, wex.Status.ToString())
            Return False
        Catch ex As Exception
            Me.m_notifierHandler.ShowResponseFailed(tokenUri.ToString)
            Return False
        End Try

        If tokenResponse.StatusCode <> HttpStatusCode.OK Then
            Me.m_notifierHandler.ShowResponseIsBad(tokenUri.ToString(), CInt(tokenResponse.StatusCode), tokenResponse.StatusCode.ToString())
        End If

        Dim tokenSource As String

        Using resposeStream As Stream = tokenResponse.GetResponseStream()
            Using resposeReader As New StreamReader(resposeStream)
                tokenSource = resposeReader.ReadToEnd()
                tokenResponse.Close()
            End Using
        End Using

        ' Check for errors.
        If Not m_AuthenticityTokenMatch.IsMatch(tokenSource) Then
            Me.m_notifierHandler.ShowFormAuthKeyFail()
            Return False
        End If

        Me.m_formAuthenticityToken = m_AuthenticityTokenMatch.Match(tokenSource).Value

        Return True
    End Function

    ''' <summary>
    ''' Get's an absolute URI based on the ForumURL and a path relative to it.
    ''' </summary>
    ''' <param name="href">The relative path.</param>
    ''' <returns>An absolute URI.</returns>
    ''' <remarks></remarks>
    Private Function GetAbsoluteUri(ByVal href As String) As Uri
        Dim result As Uri = Nothing

        'First get a URI of the ForumURL...
        If Not Uri.TryCreate(Me.m_forumUrl, UriKind.RelativeOrAbsolute, result) Then
            Me.m_notifierHandler.ShowUrlInvalid(Me.m_forumUrl)
            Return Nothing
        End If

        'Now we add the relative path to it.
        If Not Uri.TryCreate(result, href, result) Then
            Me.m_notifierHandler.ShowHrefInvalid(href)
        End If

        Return result
    End Function

    ''' <summary>
    ''' Returns True if this PostData object is associated with an authenticated session,
    ''' otherwise False.
    ''' </summary>
    ''' <returns>True is cookies not expired.</returns>
    ''' <remarks></remarks>
    Public Function IsLoggedIn() As Boolean

        If Me.m_cookies Is Nothing OrElse Me.m_cookies.Count = 0 Then
            Return False
        End If

        Dim cookieCollection As CookieCollection = Me.m_cookies.GetCookies(New Uri(Me.m_forumUrl))

        If cookieCollection.Count > 0 Then
            Dim expired As Boolean

            For Each cookie As Cookie In cookieCollection
                expired = expired OrElse cookie.Expired
            Next

            If Not expired Then
                Return True
            End If
        End If

        Return False
    End Function

    ''' <summary>
    ''' Returns a string value if a match is found else returns an empty string.
    ''' </summary>
    ''' <param name="source"></param>
    ''' <returns>A string value.</returns>
    ''' <remarks></remarks>
    Private Function UnknownPageReturned(ByVal source As String) As String
        Dim n As Integer = source.IndexOf(UNKNOWN_PAGE_RETURNED)

        If n >= 0 Then
            Return XElement.Parse(source.Substring(n, source.IndexOf("</p>", n + 1) + 4 - n)).Value
        End If

        Return String.Empty
    End Function
#End Region ' Validation Functions

End Class
