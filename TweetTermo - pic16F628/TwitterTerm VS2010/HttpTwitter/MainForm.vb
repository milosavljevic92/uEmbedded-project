Option Strict Off
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports


Public Class MainForm

    Public Temperatura As String
    Private brojac As Integer, primljeno As String, duzina As Integer, NijePoslata As Boolean, MestoMerenja As String


#Region " Private Members "
    ''' <summary>
    ''' An object of PostData.
    ''' </summary>
    Private WithEvents m_postData As PostData

    ''' <summary>
    ''' Details about the last notified message experienced.
    ''' </summary>
    Private WithEvents m_notifierHandler As NotifierHandler

    ''' <summary>
    ''' Renders all new messages to the status window.
    ''' </summary>
    Private m_messageDisplay As MessageDisplay

    ''' <summary>
    ''' Holds an instance of the returned pages source.
    ''' </summary>
    ''' <remarks>
    ''' Has the possibility to be outdated due to the Three seconds delay.
    ''' </remarks>
    Private m_returnedPageSource As String
#End Region ' Private Members

#Region " Object Events "
    Private Sub Token()

        If Me.m_notifierHandler Is Nothing Then
            Me.m_notifierHandler = New NotifierHandler
        End If

        If Me.m_postData Is Nothing Then
            Me.m_postData = New PostData("https://twitter.com/", m_notifierHandler)
        End If

        If Not Me.m_postData.IsLoggedIn Then
            Display("Pokušavam dobiti token...")
            InitiateThread(DirectCast(Sub() Me.m_postData.AttemptLogin(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text, Me.RememberMeCheckBox.Checked), ThreadStart))
        End If
    End Sub
    Private Sub OdjaviSe()
        If Me.m_postData Is Nothing Then
            Exit Sub
        End If

        If Me.m_postData.IsLoggedIn Then
            Display("Pokušavam se odjaviti...")
            InitiateThread(DirectCast(Sub() Me.m_postData.AttemptLogout(), ThreadStart))
        End If
    End Sub

    Private Sub Objavi(ByVal TextStatusa As String)
        If Me.m_postData Is Nothing OrElse
     Not Me.m_postData.IsLoggedIn Then
            Display("Niste ulogovani!")
            Call Token()
            NijePoslata = True
            Exit Sub
        End If

        If TextStatusa.Trim = String.Empty Then
            Display("Tweet ne može da  bude prazan!")
        Else
            Display("Pokušavam objaviti...")

            Dim message As String = TextStatusa
            InitiateThread(DirectCast(Sub() Me.m_postData.AttemptTweet(message), ThreadStart))
        End If
    End Sub


#End Region ' Object Events

#Region " Methods "
    ''' <summary>
    ''' Passes a string value to the implementation of IMessageDisplay.
    ''' </summary>
    ''' <param name="Message">A string value.</param>
    Private Sub Display(ByVal Message As String)
        If Me.m_messageDisplay Is Nothing Then
            Me.m_messageDisplay = New MessageDisplay
        End If

        Me.m_messageDisplay.Display(Me.StLogin, Me.StatusLabel, Message)
    End Sub

    Private Sub InitiateThread(ByVal ThreadStart As ThreadStart)
        Dim t As New Thread(ThreadStart)
        t.IsBackground = True
        t.Start()
    End Sub
#End Region ' Methods

#Region " Raised Events "
    Private Sub AuthenticityToken(ByVal sender As Object,ByVal e As EventArgs) Handles m_postData.AuthenticityToken
        Dim token As String = DirectCast(e, AuthenticityTokenEventArghs).AuthenticityTokenValue
        Me.AuthenticityTokenTextBox.Invoke(New MethodInvoker(Sub() Me.AuthenticityTokenTextBox.Text = token))
    End Sub



    Private Sub Notifier(ByVal sender As Object, ByVal e As EventArgs) Handles m_notifierHandler.Notifies
        Display(DirectCast(e, NotifierEventArghs).NotifierValue)
    End Sub

    Private Sub LoggedOut() Handles m_postData.LoggedOut
        Me.AuthenticityTokenTextBox.Invoke(New MethodInvoker(Sub() Me.AuthenticityTokenTextBox.Clear()))
    End Sub
#End Region ' Raised Events

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized

        Me.ShowInTaskbar = False
        Me.Visible = False
        Tray.Visible = True
        e.Cancel = True

        Tray.BalloonTipText = "Termometar radi u pozadini!"
        Tray.ShowBalloonTip(1500)
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TblTemperaturaTableAdapter1.Fill(Me.TT_baseDataSet1.TblTemperatura)
        Dim x As Integer
        Dim myPort As Array
        myPort = IO.Ports.SerialPort.GetPortNames()
        For x = 0 To UBound(myPort)
            CmbPort.Items.Add(myPort(x))
        Next
        For x = 1 To 60
            CmbUzorci.Items.Add(x & " Sec")
        Next

        For x = 30 To 300 Step 30
            Me.CmbObjaviVreme.Items.Add(x & " Min")
        Next
        Me.TSKonekcija.Text = "COM: Zatvoren"

        If Not CmbPort.Items.Count = 0 Then CmbPort.SelectedIndex = 0
        CmbUzorci.SelectedIndex = 0
        CmbObjaviVreme.SelectedIndex = 0
        MestoMerenja = GetSetting("TweetTermo", "Startup", "001", " ")
        ChKoristi.Checked = GetSetting("TweetTermo", "Startup", "002", False)
        CmbUzorci.Text = GetSetting("TweetTermo", "Startup", "003", "4 sec")
        CmbPort.Text = GetSetting("TweetTermo", "Startup", "004", " ")
        UsernameTextBox.Text = GetSetting("TweetTermo", "Startup", "005", " ")
        PasswordTextBox.Text = GetSetting("TweetTermo", "Startup", "006", Nothing)
        RememberMeCheckBox.Checked = GetSetting("TweetTermo", "Startup", "007", False)



    End Sub

    Private Sub TrmVreme_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrmVreme.Tick
        Me.TSVreme.Text = Format(Now, "hh:mm:ss") & " - " & Format(Now, "dd/MM/yyyy")
        Me.LblTemperatura.Text = MestoMerenja & ": " & Temperatura
    End Sub

    Private Sub CmdKonektuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdKonektuj.Click

        Select Case CmdKonektuj.Text
            Case "Konektuj"
                Port.ReadTimeout = 500
                Port.BaudRate = 2400
                Port.PortName = CmbPort.Text
                Port.Open()
                If Port.IsOpen = True Then
                    CmdKonektuj.Text = "Diskonektuj"
                    CmdKonektuj.ForeColor = Color.Red


                Else
                    If CmbPort.SelectedIndex < 8 Then
                        CmbPort.SelectedIndex = CmbPort.SelectedIndex + 1
                    Else
                        CmbPort.SelectedIndex = 0
                    End If
                End If
            Case "Diskonektuj"
                CmdKonektuj.Text = "Konektuj"
                CmdKonektuj.ForeColor = Color.Green
                Port.Close()
        End Select
        If Port.IsOpen = True Then
            TSKonekcija.Text = "COM: Otvoren"
        Else
            TSKonekcija.Text = "COM: Zatvoren"
        End If

    End Sub

    Private Sub Tray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tray.MouseDoubleClick
        Tray.Visible = False
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub


    Private Sub CmdPosalji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPosalji.Click
        Call Objavi(Me.TweetMessageRichText.Text)
    End Sub

 

    Private Sub StatusLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusLabel.TextChanged
        StatusLabel1.Text = StatusLabel.Text
        StatusLabel2.Text = StatusLabel.Text
        StatusLabel3.Text = StatusLabel.Text
    End Sub

    Private Sub TSVreme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSVreme.TextChanged
        TSVreme1.Text = Format(Now, "hh:mm:ss") & " - " & Format(Now, "dd/MM/yyyy")
        TSVreme2.Text = Format(Now, "hh:mm:ss") & " - " & Format(Now, "dd/MM/yyyy")
        TSVreme3.Text = Format(Now, "hh:mm:ss") & " - " & Format(Now, "dd/MM/yyyy")
    End Sub


    Private Sub TSKonekcija_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSKonekcija.TextChanged
        If Port.IsOpen = True Then
            TSKonekcija.ForeColor = Color.Green
            TSKonekcija1.ForeColor = Color.Green
            TSkonekcija2.ForeColor = Color.Green
            TSKonekcija3.ForeColor = Color.Green

        Else
            TSKonekcija.ForeColor = Color.Red
            TSKonekcija1.ForeColor = Color.Red
            TSkonekcija2.ForeColor = Color.Red
            TSKonekcija3.ForeColor = Color.Red
        End If

        TSKonekcija1.Text = TSKonekcija.Text
        TSkonekcija2.Text = TSKonekcija.Text
        TSKonekcija3.Text = TSKonekcija.Text
    End Sub


    Private Sub CmdZatrazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Port.IsOpen = False Then
            StatusLabel.Text = "Nije port otvoren!"
        End If

    End Sub

    Private Sub CmdSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSnimi.Click
        Me.TblTemperaturaTableAdapter1.Insert(Format(Now, "dd.MM.yyyy"), Format(Now, "hh:mm:ss"), "Novi Sad", Temperatura, AuthenticityTokenTextBox.Text, "DA")

        Me.TblTemperaturaTableAdapter1.Fill(Me.TT_baseDataSet1.TblTemperatura)

    End Sub

    Private Sub ChDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDatum.CheckedChanged
        If ChDatum.Checked = False Then
            DTP.Enabled = False
            CmdFilter.Enabled = False
        Else
            DTP.Enabled = True
            CmdFilter.Enabled = True
        End If

    End Sub


    Private Sub CmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFilter.Click
        Dim DatumZaKveri As String
        DatumZaKveri = Format(DTP.Value, "dd/MM/yyyy")


        Me.TblTemperaturaTableAdapter1.Popuni(Me.TT_baseDataSet1.TblTemperatura, DatumZaKveri)

        Me.DataGridView1.Refresh()
        Me.StatusLabel.Text = "Pronadjeno: " & TblTemperaturaBindingSource1.Count
    End Sub
  

    Private Sub TrmSnimiUbazu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrmSnimiUbazu.Tick
        Call OcitajTemperaturu()

        If Not Port.IsOpen = False And Mid(Temperatura, 1, 4) = "," Then
            Temperatura = "ERR"
        End If
        Me.TblTemperaturaTableAdapter1.Insert(Format(Now, "dd.MM.yyyy"), Format(Now, "hh:mm:ss"), MestoMerenja, Temperatura, AuthenticityTokenTextBox.Text, "NE")

        Me.TblTemperaturaTableAdapter1.Fill(Me.TT_baseDataSet1.TblTemperatura)

    End Sub

    Private Sub CmdGrafik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrafik.Click
        FrmGrafik.Show()
    End Sub
    Private Sub ChKoristiObjavu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChKoristiObjavu.CheckedChanged
        If ChKoristiObjavu.Checked = True Then
            CmdPrimeni2.Enabled = True
            CmbObjaviVreme.Enabled = True
        Else
            CmdPrimeni2.Enabled = False
            CmbObjaviVreme.Enabled = False
        End If
    End Sub
    Private Sub CmdPrimeni2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrimeni2.Click
        If ChKoristiObjavu.Checked = True Then

            TrmObjavi.Enabled = True
        Else

            TrmObjavi.Enabled = False
        End If

    End Sub

    Private Sub ChKoristi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChKoristi.CheckedChanged
        If ChKoristi.Checked = True Then
            CmdPrimeni.Enabled = True
            CmbUzorci.Enabled = True
        Else
            CmdPrimeni.Enabled = False
            CmbUzorci.Enabled = False
        End If
    End Sub


    Private Sub TrmObjavi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrmObjavi.Tick

        Dim IntervalObjavljivanja As Integer

        If Len(CmbObjaviVreme.Text) = 7 Then
            IntervalObjavljivanja = Convert.ToInt16(Mid(Me.CmbObjaviVreme.Text, 1, 3))
        Else
            IntervalObjavljivanja = Convert.ToInt16(Mid(Me.CmbObjaviVreme.Text, 1, 2))
        End If



        If brojac = IntervalObjavljivanja Then
            Me.TblTemperaturaTableAdapter1.Insert(Format(Now, "dd.MM.yyyy"), Format(Now, "hh:mm:ss"), MestoMerenja, Temperatura, AuthenticityTokenTextBox.Text, "DA")
            TxtZaPoslati.Text = Format(Now, "dd.MM.yyyy") & " - " & Format(Now, "hh.mm.ss") & " # Temperatura u Novom Sadu je: " & Temperatura & "°C"
            Call Objavi(TxtZaPoslati.Text)
            brojac = 1
        End If
        brojac = brojac + 1

    End Sub
    Public Sub port_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Port.DataReceived


        Try
            primljeno = Port.ReadExisting
            duzina = Len(primljeno)

           
                If duzina > 6 And duzina < 9 Then
                    Temperatura = primljeno
                End If

        Catch ex As Exception
        End Try
    End Sub


    Private Sub OcitajTemperaturu()
        If Port.IsOpen = True Then
            Port.Write("TC")
        Else
            Temperatura = "NO_COMM"
        End If
    End Sub


   


    Private Sub CmdObrisiTweet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdObrisiTweet.Click
        TweetMessageRichText.Text = " "
    End Sub

    Private Sub TrmToken_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrmToken.Tick
        If NijePoslata = True Then
            If AuthenticityTokenTextBox.Text <> " " Then
                NijePoslata = False
                Objavi(TxtZaPoslati.Text)
            End If
        End If
    End Sub
    Private Sub CmdIzlaz_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdIzlaz.Click
        Dim i As Integer
        i = MsgBox("Sigurno?", vbYesNo)
        If i = vbYes Then
            Tray.Visible = False
            End
        ElseIf i = vbNo Then

            Exit Sub
        End If
    End Sub

   
   
    Private Sub CmdPrimeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrimeni.Click
        Dim IntervalTimera As Integer
        MestoMerenja = TxtMestoMerenja.Text

        IntervalTimera = Convert.ToInt16(Mid(CmbUzorci.Text, 1, 2))
        If ChKoristi.Checked = True Then

            TrmSnimiUbazu.Interval = IntervalTimera * 1000

            TrmSnimiUbazu.Enabled = True
        Else
            TrmSnimiUbazu.Enabled = False
        End If
        SaveSetting("TweetTermo", "Startup", "001", MestoMerenja)
        SaveSetting("TweetTermo", "Startup", "002", ChKoristi.Checked)
        SaveSetting("TweetTermo", "Startup", "003", CmbUzorci.Text)
        SaveSetting("TweetTermo", "Startup", "004", CmbPort.Text)
        StatusLabel.Text = "Primenjeno!"
    End Sub
    Private Sub CmdPrimeniTweet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrimeniTweet.Click

        On Error Resume Next
        If RememberMeCheckBox.Checked = True Then

            SaveSetting("TweetTermo", "Startup", "005", UsernameTextBox.Text)
            SaveSetting("TweetTermo", "Startup", "006", PasswordTextBox.Text)
        Else
            DeleteSetting("TweetTermo", "Startup", "006")
        End If
        SaveSetting("TweetTermo", "Startup", "007", RememberMeCheckBox.Checked)
        StatusLabel.Text = "Primenjeno!"
    End Sub
    Private Sub CmdNabaviToken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNabaviToken.Click
        Call OdjaviSe()
        Token()
    End Sub

    Private Sub CmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogOut.Click
        Call OdjaviSe()
    End Sub
End Class

