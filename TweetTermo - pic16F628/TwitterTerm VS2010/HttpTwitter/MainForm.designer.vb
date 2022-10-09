<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim passwordLabel As System.Windows.Forms.Label
        Dim usernameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TrmVreme = New System.Windows.Forms.Timer(Me.components)
        Me.WebPageTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtZaPoslati = New System.Windows.Forms.TextBox()
        Me.ChKoristiObjavu = New System.Windows.Forms.CheckBox()
        Me.CmdPrimeni2 = New System.Windows.Forms.Button()
        Me.CmbObjaviVreme = New System.Windows.Forms.ComboBox()
        Me.CmdObrisiTweet = New System.Windows.Forms.Button()
        Me.StTwitter = New System.Windows.Forms.StatusStrip()
        Me.TSVreme3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSKonekcija3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TweetMessageRichText = New System.Windows.Forms.RichTextBox()
        Me.CmdPosalji = New System.Windows.Forms.Button()
        Me.PostInputTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdPrimeniTweet = New System.Windows.Forms.Button()
        Me.CmdLogOut = New System.Windows.Forms.Button()
        Me.CmdNabaviToken = New System.Windows.Forms.Button()
        Me.RememberMeCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AuthenticityTokenTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.StLogin = New System.Windows.Forms.StatusStrip()
        Me.TSVreme = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSKonekcija = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ResponseDataTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CmdPrimeni = New System.Windows.Forms.Button()
        Me.ChPokreniUzWindows = New System.Windows.Forms.CheckBox()
        Me.StTermometar = New System.Windows.Forms.StatusStrip()
        Me.TSVreme1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSKonekcija1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtMestoMerenja = New System.Windows.Forms.TextBox()
        Me.ChKoristi = New System.Windows.Forms.CheckBox()
        Me.CmbUzorci = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.LblTemperatura = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdKonektuj = New System.Windows.Forms.Button()
        Me.CmbBrzina = New System.Windows.Forms.ComboBox()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.SourceViewTabPage = New System.Windows.Forms.TabPage()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.CmdFilter = New System.Windows.Forms.Button()
        Me.ChDatum = New System.Windows.Forms.CheckBox()
        Me.CmdGrafik = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VremeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTemperaturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TT_baseDataSet1 = New TwitterTermometer.TT_baseDataSet1()
        Me.StTabela = New System.Windows.Forms.StatusStrip()
        Me.TSVreme2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSkonekcija2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CmdIzlaz = New System.Windows.Forms.Button()
        Me.Port = New System.IO.Ports.SerialPort(Me.components)
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TblTemperaturaTableAdapter1 = New TwitterTermometer.TT_baseDataSet1TableAdapters.TblTemperaturaTableAdapter()
        Me.TrmSnimiUbazu = New System.Windows.Forms.Timer(Me.components)
        Me.TrmObjavi = New System.Windows.Forms.Timer(Me.components)
        Me.TrmToken = New System.Windows.Forms.Timer(Me.components)
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        passwordLabel = New System.Windows.Forms.Label()
        usernameLabel = New System.Windows.Forms.Label()
        Me.WebPageTabPage.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.StTwitter.SuspendLayout()
        Me.PostInputTabPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StLogin.SuspendLayout()
        Me.ResponseDataTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StTermometar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SourceViewTabPage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTemperaturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_baseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StTabela.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(2, 97)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(89, 13)
        Label3.TabIndex = 0
        Label3.Text = "Trenutni TOKEN:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Label4.Location = New System.Drawing.Point(8, 16)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(57, 16)
        Label4.TabIndex = 91
        Label4.Text = "Poruka:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 18)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(82, 13)
        Label5.TabIndex = 7
        Label5.Text = "Broj COM porta:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 58)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(80, 13)
        Label6.TabIndex = 8
        Label6.Text = "Brzina prenosa:"
        Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(83, 18)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 8
        Label1.Text = "Na svakih:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(81, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 13)
        Label2.TabIndex = 9
        Label2.Text = "Na svakih:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 53)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(114, 13)
        Label8.TabIndex = 12
        Label8.Text = "Poslednji poslati tweet:"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(6, 42)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(76, 13)
        Label7.TabIndex = 9
        Label7.Text = "Mesto merenja"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordLabel
        '
        passwordLabel.AutoSize = True
        passwordLabel.Location = New System.Drawing.Point(8, 53)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New System.Drawing.Size(56, 13)
        passwordLabel.TabIndex = 85
        passwordLabel.Text = "Password:"
        passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'usernameLabel
        '
        usernameLabel.AutoSize = True
        usernameLabel.Location = New System.Drawing.Point(6, 26)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New System.Drawing.Size(58, 13)
        usernameLabel.TabIndex = 84
        usernameLabel.Text = "Username:"
        usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrmVreme
        '
        Me.TrmVreme.Enabled = True
        '
        'WebPageTabPage
        '
        Me.WebPageTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.WebPageTabPage.Controls.Add(Me.GroupBox5)
        Me.WebPageTabPage.Controls.Add(Me.CmdObrisiTweet)
        Me.WebPageTabPage.Controls.Add(Me.StTwitter)
        Me.WebPageTabPage.Controls.Add(Label4)
        Me.WebPageTabPage.Controls.Add(Me.TweetMessageRichText)
        Me.WebPageTabPage.Controls.Add(Me.CmdPosalji)
        Me.WebPageTabPage.Location = New System.Drawing.Point(4, 22)
        Me.WebPageTabPage.Name = "WebPageTabPage"
        Me.WebPageTabPage.Size = New System.Drawing.Size(374, 263)
        Me.WebPageTabPage.TabIndex = 3
        Me.WebPageTabPage.Text = "Twitter"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Label8)
        Me.GroupBox5.Controls.Add(Me.TxtZaPoslati)
        Me.GroupBox5.Controls.Add(Me.ChKoristiObjavu)
        Me.GroupBox5.Controls.Add(Label2)
        Me.GroupBox5.Controls.Add(Me.CmdPrimeni2)
        Me.GroupBox5.Controls.Add(Me.CmbObjaviVreme)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 133)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(357, 96)
        Me.GroupBox5.TabIndex = 94
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vreme slanja:"
        '
        'TxtZaPoslati
        '
        Me.TxtZaPoslati.Enabled = False
        Me.TxtZaPoslati.Location = New System.Drawing.Point(6, 69)
        Me.TxtZaPoslati.Name = "TxtZaPoslati"
        Me.TxtZaPoslati.Size = New System.Drawing.Size(345, 20)
        Me.TxtZaPoslati.TabIndex = 11
        '
        'ChKoristiObjavu
        '
        Me.ChKoristiObjavu.AutoSize = True
        Me.ChKoristiObjavu.Location = New System.Drawing.Point(6, 24)
        Me.ChKoristiObjavu.Name = "ChKoristiObjavu"
        Me.ChKoristiObjavu.Size = New System.Drawing.Size(54, 17)
        Me.ChKoristiObjavu.TabIndex = 10
        Me.ChKoristiObjavu.Text = "Koristi"
        Me.ChKoristiObjavu.UseVisualStyleBackColor = True
        '
        'CmdPrimeni2
        '
        Me.CmdPrimeni2.Enabled = False
        Me.CmdPrimeni2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdPrimeni2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CmdPrimeni2.Location = New System.Drawing.Point(282, 19)
        Me.CmdPrimeni2.Name = "CmdPrimeni2"
        Me.CmdPrimeni2.Size = New System.Drawing.Size(65, 29)
        Me.CmdPrimeni2.TabIndex = 2
        Me.CmdPrimeni2.Text = "Primeni"
        Me.CmdPrimeni2.UseVisualStyleBackColor = True
        '
        'CmbObjaviVreme
        '
        Me.CmbObjaviVreme.Enabled = False
        Me.CmbObjaviVreme.FormattingEnabled = True
        Me.CmbObjaviVreme.Location = New System.Drawing.Point(145, 19)
        Me.CmbObjaviVreme.Name = "CmbObjaviVreme"
        Me.CmbObjaviVreme.Size = New System.Drawing.Size(64, 21)
        Me.CmbObjaviVreme.TabIndex = 1
        '
        'CmdObrisiTweet
        '
        Me.CmdObrisiTweet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdObrisiTweet.ForeColor = System.Drawing.Color.Red
        Me.CmdObrisiTweet.Location = New System.Drawing.Point(241, 94)
        Me.CmdObrisiTweet.Name = "CmdObrisiTweet"
        Me.CmdObrisiTweet.Size = New System.Drawing.Size(124, 33)
        Me.CmdObrisiTweet.TabIndex = 93
        Me.CmdObrisiTweet.Text = "Obriši"
        Me.CmdObrisiTweet.UseVisualStyleBackColor = True
        '
        'StTwitter
        '
        Me.StTwitter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSVreme3, Me.StatusLabel3, Me.TSKonekcija3})
        Me.StTwitter.Location = New System.Drawing.Point(0, 241)
        Me.StTwitter.Name = "StTwitter"
        Me.StTwitter.Size = New System.Drawing.Size(374, 22)
        Me.StTwitter.TabIndex = 92
        Me.StTwitter.Text = "StatusStrip1"
        '
        'TSVreme3
        '
        Me.TSVreme3.Name = "TSVreme3"
        Me.TSVreme3.Size = New System.Drawing.Size(114, 17)
        Me.TSVreme3.Text = "00:00:00 - 13.04.2013"
        '
        'StatusLabel3
        '
        Me.StatusLabel3.Name = "StatusLabel3"
        Me.StatusLabel3.Size = New System.Drawing.Size(79, 17)
        Me.StatusLabel3.Text = "Nema sesije..."
        '
        'TSKonekcija3
        '
        Me.TSKonekcija3.Name = "TSKonekcija3"
        Me.TSKonekcija3.Size = New System.Drawing.Size(84, 17)
        Me.TSKonekcija3.Text = "COM: Otvoren"
        '
        'TweetMessageRichText
        '
        Me.TweetMessageRichText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TweetMessageRichText.Location = New System.Drawing.Point(8, 32)
        Me.TweetMessageRichText.MaxLength = 300
        Me.TweetMessageRichText.Name = "TweetMessageRichText"
        Me.TweetMessageRichText.Size = New System.Drawing.Size(357, 56)
        Me.TweetMessageRichText.TabIndex = 90
        Me.TweetMessageRichText.Text = ""
        '
        'CmdPosalji
        '
        Me.CmdPosalji.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPosalji.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdPosalji.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CmdPosalji.Location = New System.Drawing.Point(8, 94)
        Me.CmdPosalji.Name = "CmdPosalji"
        Me.CmdPosalji.Size = New System.Drawing.Size(124, 33)
        Me.CmdPosalji.TabIndex = 89
        Me.CmdPosalji.Text = "Objavi poruku"
        Me.CmdPosalji.UseVisualStyleBackColor = True
        '
        'PostInputTabPage
        '
        Me.PostInputTabPage.Controls.Add(Me.GroupBox2)
        Me.PostInputTabPage.Controls.Add(Me.StLogin)
        Me.PostInputTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PostInputTabPage.Name = "PostInputTabPage"
        Me.PostInputTabPage.Size = New System.Drawing.Size(374, 263)
        Me.PostInputTabPage.TabIndex = 2
        Me.PostInputTabPage.Text = "Login"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdPrimeniTweet)
        Me.GroupBox2.Controls.Add(Me.CmdLogOut)
        Me.GroupBox2.Controls.Add(Me.CmdNabaviToken)
        Me.GroupBox2.Controls.Add(Me.RememberMeCheckBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.AuthenticityTokenTextBox)
        Me.GroupBox2.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(passwordLabel)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(usernameLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 232)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'CmdPrimeniTweet
        '
        Me.CmdPrimeniTweet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdPrimeniTweet.Location = New System.Drawing.Point(6, 123)
        Me.CmdPrimeniTweet.Name = "CmdPrimeniTweet"
        Me.CmdPrimeniTweet.Size = New System.Drawing.Size(115, 30)
        Me.CmdPrimeniTweet.TabIndex = 98
        Me.CmdPrimeniTweet.Text = "Primeni"
        Me.CmdPrimeniTweet.UseVisualStyleBackColor = True
        '
        'CmdLogOut
        '
        Me.CmdLogOut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdLogOut.ForeColor = System.Drawing.Color.Red
        Me.CmdLogOut.Location = New System.Drawing.Point(87, 196)
        Me.CmdLogOut.Name = "CmdLogOut"
        Me.CmdLogOut.Size = New System.Drawing.Size(186, 30)
        Me.CmdLogOut.TabIndex = 97
        Me.CmdLogOut.Text = "Logout"
        Me.CmdLogOut.UseVisualStyleBackColor = True
        '
        'CmdNabaviToken
        '
        Me.CmdNabaviToken.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdNabaviToken.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CmdNabaviToken.Location = New System.Drawing.Point(87, 160)
        Me.CmdNabaviToken.Name = "CmdNabaviToken"
        Me.CmdNabaviToken.Size = New System.Drawing.Size(186, 30)
        Me.CmdNabaviToken.TabIndex = 96
        Me.CmdNabaviToken.Text = "Nabavi TOKEN"
        Me.CmdNabaviToken.UseVisualStyleBackColor = True
        '
        'RememberMeCheckBox
        '
        Me.RememberMeCheckBox.AutoSize = True
        Me.RememberMeCheckBox.Checked = Global.TwitterTermometer.My.MySettings.Default.RememberMeSetting
        Me.RememberMeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RememberMeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TwitterTermometer.My.MySettings.Default, "RememberMeSetting", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RememberMeCheckBox.Location = New System.Drawing.Point(64, 77)
        Me.RememberMeCheckBox.Name = "RememberMeCheckBox"
        Me.RememberMeCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.RememberMeCheckBox.TabIndex = 91
        Me.RememberMeCheckBox.Text = "Zapamti lozinku"
        Me.RememberMeCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(277, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'AuthenticityTokenTextBox
        '
        Me.AuthenticityTokenTextBox.Enabled = False
        Me.AuthenticityTokenTextBox.Location = New System.Drawing.Point(97, 97)
        Me.AuthenticityTokenTextBox.Name = "AuthenticityTokenTextBox"
        Me.AuthenticityTokenTextBox.Size = New System.Drawing.Size(257, 20)
        Me.AuthenticityTokenTextBox.TabIndex = 93
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(64, 24)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.UsernameTextBox.TabIndex = 82
        Me.UsernameTextBox.Text = "d_milosavljevic"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(64, 50)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(136, 20)
        Me.PasswordTextBox.TabIndex = 83
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'StLogin
        '
        Me.StLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSVreme, Me.StatusLabel, Me.TSKonekcija})
        Me.StLogin.Location = New System.Drawing.Point(0, 241)
        Me.StLogin.Name = "StLogin"
        Me.StLogin.Size = New System.Drawing.Size(374, 22)
        Me.StLogin.TabIndex = 89
        Me.StLogin.Text = "Idle..."
        '
        'TSVreme
        '
        Me.TSVreme.Name = "TSVreme"
        Me.TSVreme.Size = New System.Drawing.Size(114, 17)
        Me.TSVreme.Text = "00:00:00 - 13.04.2013"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(79, 17)
        Me.StatusLabel.Text = "Nema sesije..."
        '
        'TSKonekcija
        '
        Me.TSKonekcija.Name = "TSKonekcija"
        Me.TSKonekcija.Size = New System.Drawing.Size(84, 17)
        Me.TSKonekcija.Text = "COM: Otvoren"
        '
        'ResponseDataTabControl
        '
        Me.ResponseDataTabControl.Controls.Add(Me.TabPage1)
        Me.ResponseDataTabControl.Controls.Add(Me.SourceViewTabPage)
        Me.ResponseDataTabControl.Controls.Add(Me.WebPageTabPage)
        Me.ResponseDataTabControl.Controls.Add(Me.PostInputTabPage)
        Me.ResponseDataTabControl.Controls.Add(Me.TabPage2)
        Me.ResponseDataTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResponseDataTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ResponseDataTabControl.Name = "ResponseDataTabControl"
        Me.ResponseDataTabControl.SelectedIndex = 0
        Me.ResponseDataTabControl.Size = New System.Drawing.Size(382, 289)
        Me.ResponseDataTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.CmdPrimeni)
        Me.TabPage1.Controls.Add(Me.ChPokreniUzWindows)
        Me.TabPage1.Controls.Add(Me.StTermometar)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(374, 263)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Termometar"
        '
        'CmdPrimeni
        '
        Me.CmdPrimeni.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdPrimeni.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CmdPrimeni.Location = New System.Drawing.Point(278, 113)
        Me.CmdPrimeni.Name = "CmdPrimeni"
        Me.CmdPrimeni.Size = New System.Drawing.Size(88, 29)
        Me.CmdPrimeni.TabIndex = 10
        Me.CmdPrimeni.Text = "Primeni"
        Me.CmdPrimeni.UseVisualStyleBackColor = True
        '
        'ChPokreniUzWindows
        '
        Me.ChPokreniUzWindows.AutoSize = True
        Me.ChPokreniUzWindows.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ChPokreniUzWindows.Location = New System.Drawing.Point(9, 214)
        Me.ChPokreniUzWindows.Name = "ChPokreniUzWindows"
        Me.ChPokreniUzWindows.Size = New System.Drawing.Size(128, 19)
        Me.ChPokreniUzWindows.TabIndex = 9
        Me.ChPokreniUzWindows.Text = "Pokreni uz sistem"
        Me.ChPokreniUzWindows.UseVisualStyleBackColor = True
        '
        'StTermometar
        '
        Me.StTermometar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSVreme1, Me.StatusLabel1, Me.TSKonekcija1})
        Me.StTermometar.Location = New System.Drawing.Point(0, 241)
        Me.StTermometar.Name = "StTermometar"
        Me.StTermometar.Size = New System.Drawing.Size(374, 22)
        Me.StTermometar.TabIndex = 8
        Me.StTermometar.Text = "StatusStrip1"
        '
        'TSVreme1
        '
        Me.TSVreme1.Name = "TSVreme1"
        Me.TSVreme1.Size = New System.Drawing.Size(114, 17)
        Me.TSVreme1.Text = "00:00:00 - 13.04.2013"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(79, 17)
        Me.StatusLabel1.Text = "Nema sesije..."
        '
        'TSKonekcija1
        '
        Me.TSKonekcija1.Name = "TSKonekcija1"
        Me.TSKonekcija1.Size = New System.Drawing.Size(82, 17)
        Me.TSKonekcija1.Text = "COM: Ztvoren"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtMestoMerenja)
        Me.GroupBox4.Controls.Add(Label7)
        Me.GroupBox4.Controls.Add(Label1)
        Me.GroupBox4.Controls.Add(Me.ChKoristi)
        Me.GroupBox4.Controls.Add(Me.CmbUzorci)
        Me.GroupBox4.Location = New System.Drawing.Point(149, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(217, 95)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Uzorci:"
        '
        'TxtMestoMerenja
        '
        Me.TxtMestoMerenja.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TxtMestoMerenja.Location = New System.Drawing.Point(9, 59)
        Me.TxtMestoMerenja.Multiline = True
        Me.TxtMestoMerenja.Name = "TxtMestoMerenja"
        Me.TxtMestoMerenja.Size = New System.Drawing.Size(202, 28)
        Me.TxtMestoMerenja.TabIndex = 11
        Me.TxtMestoMerenja.Text = "Novi Sad"
        '
        'ChKoristi
        '
        Me.ChKoristi.AutoSize = True
        Me.ChKoristi.Location = New System.Drawing.Point(23, 17)
        Me.ChKoristi.Name = "ChKoristi"
        Me.ChKoristi.Size = New System.Drawing.Size(54, 17)
        Me.ChKoristi.TabIndex = 2
        Me.ChKoristi.Text = "Koristi"
        Me.ChKoristi.UseVisualStyleBackColor = True
        '
        'CmbUzorci
        '
        Me.CmbUzorci.Enabled = False
        Me.CmbUzorci.FormattingEnabled = True
        Me.CmbUzorci.Location = New System.Drawing.Point(147, 15)
        Me.CmbUzorci.Name = "CmbUzorci"
        Me.CmbUzorci.Size = New System.Drawing.Size(64, 21)
        Me.CmbUzorci.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmdSnimi)
        Me.GroupBox3.Controls.Add(Me.LblTemperatura)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 53)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trenutna temperatura:"
        '
        'CmdSnimi
        '
        Me.CmdSnimi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdSnimi.Location = New System.Drawing.Point(247, 9)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(86, 38)
        Me.CmdSnimi.TabIndex = 1
        Me.CmdSnimi.Text = "Snimi odmah"
        Me.CmdSnimi.UseVisualStyleBackColor = True
        '
        'LblTemperatura
        '
        Me.LblTemperatura.AutoSize = True
        Me.LblTemperatura.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblTemperatura.Location = New System.Drawing.Point(3, 16)
        Me.LblTemperatura.Name = "LblTemperatura"
        Me.LblTemperatura.Size = New System.Drawing.Size(134, 31)
        Me.LblTemperatura.TabIndex = 0
        Me.LblTemperatura.Text = "Novi Sad: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.CmdKonektuj)
        Me.GroupBox1.Controls.Add(Me.CmbBrzina)
        Me.GroupBox1.Controls.Add(Me.CmbPort)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 136)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Port i brzina:"
        '
        'CmdKonektuj
        '
        Me.CmdKonektuj.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdKonektuj.ForeColor = System.Drawing.Color.Green
        Me.CmdKonektuj.Location = New System.Drawing.Point(6, 101)
        Me.CmdKonektuj.Name = "CmdKonektuj"
        Me.CmdKonektuj.Size = New System.Drawing.Size(121, 29)
        Me.CmdKonektuj.TabIndex = 6
        Me.CmdKonektuj.Text = "Konektuj"
        Me.CmdKonektuj.UseVisualStyleBackColor = True
        '
        'CmbBrzina
        '
        Me.CmbBrzina.Enabled = False
        Me.CmbBrzina.FormattingEnabled = True
        Me.CmbBrzina.Location = New System.Drawing.Point(6, 74)
        Me.CmbBrzina.Name = "CmbBrzina"
        Me.CmbBrzina.Size = New System.Drawing.Size(121, 21)
        Me.CmbBrzina.TabIndex = 5
        Me.CmbBrzina.Text = "2400 bps"
        '
        'CmbPort
        '
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(6, 34)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(121, 21)
        Me.CmbPort.TabIndex = 4
        '
        'SourceViewTabPage
        '
        Me.SourceViewTabPage.AutoScroll = True
        Me.SourceViewTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.SourceViewTabPage.Controls.Add(Me.DTP)
        Me.SourceViewTabPage.Controls.Add(Me.CmdFilter)
        Me.SourceViewTabPage.Controls.Add(Me.ChDatum)
        Me.SourceViewTabPage.Controls.Add(Me.CmdGrafik)
        Me.SourceViewTabPage.Controls.Add(Me.DataGridView1)
        Me.SourceViewTabPage.Controls.Add(Me.StTabela)
        Me.SourceViewTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SourceViewTabPage.Name = "SourceViewTabPage"
        Me.SourceViewTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SourceViewTabPage.Size = New System.Drawing.Size(374, 263)
        Me.SourceViewTabPage.TabIndex = 1
        Me.SourceViewTabPage.Text = "Tabela"
        '
        'DTP
        '
        Me.DTP.Enabled = False
        Me.DTP.Location = New System.Drawing.Point(71, 6)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(131, 20)
        Me.DTP.TabIndex = 6
        '
        'CmdFilter
        '
        Me.CmdFilter.Enabled = False
        Me.CmdFilter.Location = New System.Drawing.Point(208, 5)
        Me.CmdFilter.Name = "CmdFilter"
        Me.CmdFilter.Size = New System.Drawing.Size(43, 21)
        Me.CmdFilter.TabIndex = 5
        Me.CmdFilter.Text = "Filter"
        Me.CmdFilter.UseVisualStyleBackColor = True
        '
        'ChDatum
        '
        Me.ChDatum.AutoSize = True
        Me.ChDatum.Location = New System.Drawing.Point(8, 9)
        Me.ChDatum.Name = "ChDatum"
        Me.ChDatum.Size = New System.Drawing.Size(57, 17)
        Me.ChDatum.TabIndex = 4
        Me.ChDatum.Text = "Datum"
        Me.ChDatum.UseVisualStyleBackColor = True
        '
        'CmdGrafik
        '
        Me.CmdGrafik.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdGrafik.ForeColor = System.Drawing.Color.CadetBlue
        Me.CmdGrafik.Location = New System.Drawing.Point(292, 3)
        Me.CmdGrafik.Name = "CmdGrafik"
        Me.CmdGrafik.Size = New System.Drawing.Size(75, 23)
        Me.CmdGrafik.TabIndex = 3
        Me.CmdGrafik.Text = "Grafik"
        Me.CmdGrafik.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatumDataGridViewTextBoxColumn, Me.VremeDataGridViewTextBoxColumn, Me.TemperaturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblTemperaturaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(361, 203)
        Me.DataGridView1.TabIndex = 2
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        Me.DatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VremeDataGridViewTextBoxColumn
        '
        Me.VremeDataGridViewTextBoxColumn.DataPropertyName = "Vreme"
        Me.VremeDataGridViewTextBoxColumn.HeaderText = "Vreme"
        Me.VremeDataGridViewTextBoxColumn.Name = "VremeDataGridViewTextBoxColumn"
        Me.VremeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TemperaturaDataGridViewTextBoxColumn
        '
        Me.TemperaturaDataGridViewTextBoxColumn.DataPropertyName = "Temperatura"
        Me.TemperaturaDataGridViewTextBoxColumn.HeaderText = "Temperatura"
        Me.TemperaturaDataGridViewTextBoxColumn.Name = "TemperaturaDataGridViewTextBoxColumn"
        Me.TemperaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblTemperaturaBindingSource1
        '
        Me.TblTemperaturaBindingSource1.DataMember = "TblTemperatura"
        Me.TblTemperaturaBindingSource1.DataSource = Me.TT_baseDataSet1
        '
        'TT_baseDataSet1
        '
        Me.TT_baseDataSet1.DataSetName = "TT_baseDataSet1"
        Me.TT_baseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StTabela
        '
        Me.StTabela.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSVreme2, Me.StatusLabel2, Me.TSkonekcija2})
        Me.StTabela.Location = New System.Drawing.Point(3, 238)
        Me.StTabela.Name = "StTabela"
        Me.StTabela.Size = New System.Drawing.Size(368, 22)
        Me.StTabela.TabIndex = 0
        Me.StTabela.Text = "StatusStrip1"
        '
        'TSVreme2
        '
        Me.TSVreme2.Name = "TSVreme2"
        Me.TSVreme2.Size = New System.Drawing.Size(114, 17)
        Me.TSVreme2.Text = "00:00:00 - 13.04.2013"
        '
        'StatusLabel2
        '
        Me.StatusLabel2.Name = "StatusLabel2"
        Me.StatusLabel2.Size = New System.Drawing.Size(79, 17)
        Me.StatusLabel2.Text = "Nema sesije..."
        '
        'TSkonekcija2
        '
        Me.TSkonekcija2.Name = "TSkonekcija2"
        Me.TSkonekcija2.Size = New System.Drawing.Size(84, 17)
        Me.TSkonekcija2.Text = "COM: Otvoren"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.CmdIzlaz)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(374, 263)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Izlaz"
        '
        'CmdIzlaz
        '
        Me.CmdIzlaz.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CmdIzlaz.ForeColor = System.Drawing.Color.Red
        Me.CmdIzlaz.Location = New System.Drawing.Point(84, 113)
        Me.CmdIzlaz.Name = "CmdIzlaz"
        Me.CmdIzlaz.Size = New System.Drawing.Size(186, 29)
        Me.CmdIzlaz.TabIndex = 92
        Me.CmdIzlaz.Text = "Zatvori program"
        Me.CmdIzlaz.UseVisualStyleBackColor = True
        '
        'Port
        '
        Me.Port.BaudRate = 2400
        '
        'Tray
        '
        Me.Tray.Icon = CType(resources.GetObject("Tray.Icon"), System.Drawing.Icon)
        Me.Tray.Text = "Twitter termometar V1.0"
        Me.Tray.Visible = True
        '
        'TblTemperaturaTableAdapter1
        '
        Me.TblTemperaturaTableAdapter1.ClearBeforeFill = True
        '
        'TrmSnimiUbazu
        '
        '
        'TrmObjavi
        '
        Me.TrmObjavi.Interval = 60000
        '
        'TrmToken
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 289)
        Me.Controls.Add(Me.ResponseDataTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Twitter termometar V1.0 - 2013"
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.WebPageTabPage.ResumeLayout(False)
        Me.WebPageTabPage.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StTwitter.ResumeLayout(False)
        Me.StTwitter.PerformLayout()
        Me.PostInputTabPage.ResumeLayout(False)
        Me.PostInputTabPage.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StLogin.ResumeLayout(False)
        Me.StLogin.PerformLayout()
        Me.ResponseDataTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StTermometar.ResumeLayout(False)
        Me.StTermometar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SourceViewTabPage.ResumeLayout(False)
        Me.SourceViewTabPage.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTemperaturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_baseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StTabela.ResumeLayout(False)
        Me.StTabela.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TrmVreme As System.Windows.Forms.Timer
    Private WithEvents WebPageTabPage As System.Windows.Forms.TabPage
    Private WithEvents PostInputTabPage As System.Windows.Forms.TabPage
    Private WithEvents StLogin As System.Windows.Forms.StatusStrip
    Private WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents ResponseDataTabControl As System.Windows.Forms.TabControl
    Private WithEvents SourceViewTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents TweetMessageRichText As System.Windows.Forms.RichTextBox
    Private WithEvents CmdPosalji As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdKonektuj As System.Windows.Forms.Button
    Friend WithEvents CmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents AuthenticityTokenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Port As System.IO.Ports.SerialPort
    Friend WithEvents TSVreme As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSKonekcija As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblTemperatura As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents StTermometar As System.Windows.Forms.StatusStrip
    Friend WithEvents TSVreme1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StTwitter As System.Windows.Forms.StatusStrip
    Friend WithEvents TSVreme3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StTabela As System.Windows.Forms.StatusStrip
    Friend WithEvents TSVreme2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents CmdObrisiTweet As System.Windows.Forms.Button
    Private WithEvents StatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSKonekcija3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSKonekcija1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSkonekcija2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdGrafik As System.Windows.Forms.Button
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VremeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperaturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdSnimi As System.Windows.Forms.Button
    Friend WithEvents ChDatum As System.Windows.Forms.CheckBox
    Friend WithEvents TT_baseDataSet1 As TwitterTermometer.TT_baseDataSet1
    Friend WithEvents TblTemperaturaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblTemperaturaTableAdapter1 As TwitterTermometer.TT_baseDataSet1TableAdapters.TblTemperaturaTableAdapter
    Friend WithEvents CmdFilter As System.Windows.Forms.Button
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbBrzina As System.Windows.Forms.ComboBox
    Friend WithEvents CmbUzorci As System.Windows.Forms.ComboBox
    Friend WithEvents TrmSnimiUbazu As System.Windows.Forms.Timer
    Friend WithEvents ChKoristi As System.Windows.Forms.CheckBox
    Friend WithEvents TrmObjavi As System.Windows.Forms.Timer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ChPokreniUzWindows As System.Windows.Forms.CheckBox
    Friend WithEvents CmbObjaviVreme As System.Windows.Forms.ComboBox
    Friend WithEvents CmdPrimeni2 As System.Windows.Forms.Button
    Friend WithEvents ChKoristiObjavu As System.Windows.Forms.CheckBox
    Friend WithEvents TxtZaPoslati As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CmdIzlaz As System.Windows.Forms.Button
    Friend WithEvents TrmToken As System.Windows.Forms.Timer
    Friend WithEvents TxtMestoMerenja As System.Windows.Forms.TextBox
    Friend WithEvents CmdPrimeni As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents RememberMeCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Private WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CmdLogOut As System.Windows.Forms.Button
    Friend WithEvents CmdNabaviToken As System.Windows.Forms.Button
    Friend WithEvents CmdPrimeniTweet As System.Windows.Forms.Button

End Class
