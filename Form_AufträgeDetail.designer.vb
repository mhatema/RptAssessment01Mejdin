<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AufträgeDetail
  Inherits System.Windows.Forms.UserControl

  'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AufträgeDetail))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabHauptdaten = New System.Windows.Forms.TabPage()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.cmdSearch = New System.Windows.Forms.Button()
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.cmdGoogleMaps = New System.Windows.Forms.Button()
    Me.Lagerort = New Comatic.Txc()
    Me.cmdNeueAdresse = New System.Windows.Forms.Button()
    Me.Buchungskurs = New Comatic.Tx()
    Me.cmdDrct = New System.Windows.Forms.Button()
    Me.Lieferart = New Comatic.Txc()
    Me.Lieferadresse = New Comatic.Txc()
    Me.Adresse2 = New Comatic.Tx()
    Me.Rayon = New Comatic.Txc()
    Me.VisumDat = New Comatic.Tx()
    Me.Prv_Adress_ID = New Comatic.Txp()
    Me.LAnrede = New Comatic.Txc()
    Me.VisumAdm = New Comatic.Tx()
    Me.Auftragsfaktor = New Comatic.Tx()
    Me.LVorname = New Comatic.Tx()
    Me.Währung = New Comatic.Txc()
    Me.Name2 = New Comatic.Txc()
    Me.LName = New Comatic.Tx()
    Me.Konditionen = New Comatic.Txc()
    Me.Status = New Comatic.Txc()
    Me.LAdresse2 = New Comatic.Tx()
    Me.ProjektKst = New Comatic.Txc()
    Me.LAdresse3 = New Comatic.Tx()
    Me.MWStType = New Comatic.Txc()
    Me.Pendenznummer = New Comatic.Tx()
    Me.LPlz = New Comatic.Tx()
    Me.LOrt = New Comatic.Tx()
    Me.Adresse3 = New Comatic.Tx()
    Me.Suchbegriff = New Comatic.Txp()
    Me.LLand = New Comatic.Txc()
    Me.Plz = New Comatic.Tx()
    Me.LAdresse1 = New Comatic.Tx()
    Me.LbTeilLS = New Comatic.Lb()
    Me.Ort = New Comatic.Tx()
    Me.TeilLS = New Comatic.Txx()
    Me.Referenz = New Comatic.Tx()
    Me.Datum = New Comatic.Tx()
    Me.Lieferdatum = New Comatic.Tx()
    Me.Rechnungsadresse = New Comatic.Txp()
    Me.Zustelladresse = New Comatic.Txp()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.TabEinleitung = New System.Windows.Forms.TabPage()
    Me.TabPositionen = New System.Windows.Forms.TabPage()
    Me.TabSchluss = New System.Windows.Forms.TabPage()
    Me.TabEinkauf = New System.Windows.Forms.TabPage()
    Me.TabLager = New System.Windows.Forms.TabPage()
    Me.TabMaterial = New System.Windows.Forms.TabPage()
    Me.TabProvisionen = New System.Windows.Forms.TabPage()
    Me.cmdLSV = New System.Windows.Forms.Button()
    Me.cmdLS = New System.Windows.Forms.Button()
    Me.cmdRSV = New System.Windows.Forms.Button()
    Me.cmdRS = New System.Windows.Forms.Button()
    Me.cmdBSV = New System.Windows.Forms.Button()
    Me.cmdBS = New System.Windows.Forms.Button()
    Me.cmdNew = New System.Windows.Forms.Button()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.TabControl1.SuspendLayout()
    Me.TabHauptdaten.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControl1.Controls.Add(Me.TabHauptdaten)
    Me.TabControl1.Controls.Add(Me.TabEinleitung)
    Me.TabControl1.Controls.Add(Me.TabPositionen)
    Me.TabControl1.Controls.Add(Me.TabSchluss)
    Me.TabControl1.Controls.Add(Me.TabEinkauf)
    Me.TabControl1.Controls.Add(Me.TabLager)
    Me.TabControl1.Controls.Add(Me.TabMaterial)
    Me.TabControl1.Controls.Add(Me.TabProvisionen)
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1008, 568)
    Me.TabControl1.TabIndex = 1
    Me.TabControl1.TabStop = False
    '
    'TabHauptdaten
    '
    Me.TabHauptdaten.BackColor = System.Drawing.Color.White
    Me.TabHauptdaten.Controls.Add(Me.SplitContainer1)
    Me.TabHauptdaten.Location = New System.Drawing.Point(4, 22)
    Me.TabHauptdaten.Name = "TabHauptdaten"
    Me.TabHauptdaten.Size = New System.Drawing.Size(1000, 542)
    Me.TabHauptdaten.TabIndex = 0
    Me.TabHauptdaten.Text = "Hauptdaten"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
    Me.SplitContainer1.Size = New System.Drawing.Size(1000, 542)
    Me.SplitContainer1.SplitterDistance = 262
    Me.SplitContainer1.TabIndex = 0
    Me.SplitContainer1.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.Controls.Add(Me.cmdSearch)
    Me.Panel1.Controls.Add(Me.cmdGoogleMaps)
    Me.Panel1.Controls.Add(Me.Lagerort)
    Me.Panel1.Controls.Add(Me.cmdNeueAdresse)
    Me.Panel1.Controls.Add(Me.Buchungskurs)
    Me.Panel1.Controls.Add(Me.cmdDrct)
    Me.Panel1.Controls.Add(Me.Lieferart)
    Me.Panel1.Controls.Add(Me.Lieferadresse)
    Me.Panel1.Controls.Add(Me.Adresse2)
    Me.Panel1.Controls.Add(Me.Rayon)
    Me.Panel1.Controls.Add(Me.VisumDat)
    Me.Panel1.Controls.Add(Me.Prv_Adress_ID)
    Me.Panel1.Controls.Add(Me.LAnrede)
    Me.Panel1.Controls.Add(Me.VisumAdm)
    Me.Panel1.Controls.Add(Me.Auftragsfaktor)
    Me.Panel1.Controls.Add(Me.LVorname)
    Me.Panel1.Controls.Add(Me.Währung)
    Me.Panel1.Controls.Add(Me.Name2)
    Me.Panel1.Controls.Add(Me.LName)
    Me.Panel1.Controls.Add(Me.Konditionen)
    Me.Panel1.Controls.Add(Me.Status)
    Me.Panel1.Controls.Add(Me.LAdresse2)
    Me.Panel1.Controls.Add(Me.ProjektKst)
    Me.Panel1.Controls.Add(Me.LAdresse3)
    Me.Panel1.Controls.Add(Me.MWStType)
    Me.Panel1.Controls.Add(Me.Pendenznummer)
    Me.Panel1.Controls.Add(Me.LPlz)
    Me.Panel1.Controls.Add(Me.LOrt)
    Me.Panel1.Controls.Add(Me.Adresse3)
    Me.Panel1.Controls.Add(Me.Suchbegriff)
    Me.Panel1.Controls.Add(Me.LLand)
    Me.Panel1.Controls.Add(Me.Plz)
    Me.Panel1.Controls.Add(Me.LAdresse1)
    Me.Panel1.Controls.Add(Me.LbTeilLS)
    Me.Panel1.Controls.Add(Me.Ort)
    Me.Panel1.Controls.Add(Me.TeilLS)
    Me.Panel1.Controls.Add(Me.Referenz)
    Me.Panel1.Controls.Add(Me.Datum)
    Me.Panel1.Controls.Add(Me.Lieferdatum)
    Me.Panel1.Controls.Add(Me.Rechnungsadresse)
    Me.Panel1.Controls.Add(Me.Zustelladresse)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1000, 262)
    Me.Panel1.TabIndex = 0
    Me.Panel1.TabStop = True
    '
    'cmdSearch
    '
    Me.cmdSearch.Enabled = False
    Me.cmdSearch.ImageIndex = 5
    Me.cmdSearch.ImageList = Me.ImageList1
    Me.cmdSearch.Location = New System.Drawing.Point(648, 49)
    Me.cmdSearch.Name = "cmdSearch"
    Me.cmdSearch.Size = New System.Drawing.Size(30, 23)
    Me.cmdSearch.TabIndex = 24
    Me.cmdSearch.TabStop = False
    Me.cmdSearch.UseVisualStyleBackColor = True
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
    Me.ImageList1.Images.SetKeyName(0, "print-preview@16px.bmp")
    Me.ImageList1.Images.SetKeyName(1, "localch.bmp")
    Me.ImageList1.Images.SetKeyName(2, "ImgTwixSmall2.bmp")
    Me.ImageList1.Images.SetKeyName(3, "information-resource-add-filled@16px.bmp")
    Me.ImageList1.Images.SetKeyName(4, "location-circle-filled-red@16px.png")
    Me.ImageList1.Images.SetKeyName(5, "search@16px.bmp")
    '
    'cmdGoogleMaps
    '
    Me.cmdGoogleMaps.Enabled = False
    Me.cmdGoogleMaps.ImageIndex = 4
    Me.cmdGoogleMaps.ImageList = Me.ImageList1
    Me.cmdGoogleMaps.Location = New System.Drawing.Point(720, 49)
    Me.cmdGoogleMaps.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
    Me.cmdGoogleMaps.Name = "cmdGoogleMaps"
    Me.cmdGoogleMaps.Size = New System.Drawing.Size(30, 23)
    Me.cmdGoogleMaps.TabIndex = 24
    Me.cmdGoogleMaps.TabStop = False
    Me.cmdGoogleMaps.UseVisualStyleBackColor = True
    '
    'Lagerort
    '
    Me.Lagerort.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Lagerort.DataField = "Lagerort"
    Me.Lagerort.DataSource = Nothing
    Me.Lagerort.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Lagerort.LabelText = "Lagerort:"
    Me.Lagerort.Location = New System.Drawing.Point(760, 27)
    Me.Lagerort.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Lagerort.MaxLength = 30
    Me.Lagerort.Name = "Lagerort"
    Me.Lagerort.RowSource = "select Lager_ID, Lagername from Lagerorte order by Lager_ID"
    Me.Lagerort.SelectedIndex = -1
    Me.Lagerort.Size = New System.Drawing.Size(235, 21)
    Me.Lagerort.TabIndex = 51
    Me.Lagerort.TabStop = False
    Me.Lagerort.Value = Nothing
    '
    'cmdNeueAdresse
    '
    Me.cmdNeueAdresse.ImageIndex = 3
    Me.cmdNeueAdresse.ImageList = Me.ImageList1
    Me.cmdNeueAdresse.Location = New System.Drawing.Point(341, 3)
    Me.cmdNeueAdresse.Name = "cmdNeueAdresse"
    Me.cmdNeueAdresse.Size = New System.Drawing.Size(30, 23)
    Me.cmdNeueAdresse.TabIndex = 1
    Me.cmdNeueAdresse.TabStop = False
    Me.cmdNeueAdresse.UseVisualStyleBackColor = True
    '
    'Buchungskurs
    '
    Me.Buchungskurs.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Buchungskurs.DataField = "Buchungskurs"
    Me.Buchungskurs.DefaultValue = "1"
    Me.Buchungskurs.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Buchungskurs.Format = Comatic.Code.cmtFormat.Number
    Me.Buchungskurs.LabelText = "Wechselkurs:"
    Me.Buchungskurs.Location = New System.Drawing.Point(760, 165)
    Me.Buchungskurs.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Buchungskurs.Name = "Buchungskurs"
    Me.Buchungskurs.SelectionLength = 1
    Me.Buchungskurs.SelectionText = "1"
    Me.Buchungskurs.Size = New System.Drawing.Size(160, 21)
    Me.Buchungskurs.TabIndex = 57
    Me.Buchungskurs.TabStop = False
    Me.Buchungskurs.Value = "1"
    '
    'cmdDrct
    '
    Me.cmdDrct.Enabled = False
    Me.cmdDrct.ImageIndex = 1
    Me.cmdDrct.ImageList = Me.ImageList1
    Me.cmdDrct.Location = New System.Drawing.Point(684, 49)
    Me.cmdDrct.Name = "cmdDrct"
    Me.cmdDrct.Size = New System.Drawing.Size(30, 23)
    Me.cmdDrct.TabIndex = 24
    Me.cmdDrct.TabStop = False
    Me.cmdDrct.UseVisualStyleBackColor = True
    '
    'Lieferart
    '
    Me.Lieferart.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Lieferart.ColumnCount = 1
    Me.Lieferart.DataField = "Lieferart"
    Me.Lieferart.DataSource = Nothing
    Me.Lieferart.LabelText = "Lieferart:"
    Me.Lieferart.Location = New System.Drawing.Point(760, 50)
    Me.Lieferart.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Lieferart.MaxLength = 30
    Me.Lieferart.Name = "Lieferart"
    Me.Lieferart.RowSource = "select Lieferart from Lieferarten order by Lieferart"
    Me.Lieferart.SelectedIndex = -1
    Me.Lieferart.Size = New System.Drawing.Size(235, 21)
    Me.Lieferart.TabIndex = 52
    Me.Lieferart.TabStop = False
    Me.Lieferart.Value = Nothing
    '
    'Lieferadresse
    '
    Me.Lieferadresse.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Lieferadresse.ColumnCount = 1
    Me.Lieferadresse.DataSource = Nothing
    Me.Lieferadresse.LabelText = "Lieferadresse:"
    Me.Lieferadresse.ListEntriesOnly = False
    Me.Lieferadresse.Location = New System.Drawing.Point(380, 27)
    Me.Lieferadresse.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Lieferadresse.Name = "Lieferadresse"
    Me.Lieferadresse.SelectedIndex = -1
    Me.Lieferadresse.Size = New System.Drawing.Size(370, 21)
    Me.Lieferadresse.TabIndex = 22
    Me.Lieferadresse.Value = Nothing
    '
    'Adresse2
    '
    Me.Adresse2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Adresse2.DataField = "Adresse2"
    Me.Adresse2.LabelText = "Adresse 2:"
    Me.Adresse2.Location = New System.Drawing.Point(1, 50)
    Me.Adresse2.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Adresse2.Name = "Adresse2"
    Me.Adresse2.Protected = True
    Me.Adresse2.Size = New System.Drawing.Size(370, 21)
    Me.Adresse2.TabIndex = 3
    Me.Adresse2.TabStop = False
    Me.Adresse2.Value = Nothing
    '
    'Rayon
    '
    Me.Rayon.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Rayon.ColumnCount = 3
    Me.Rayon.DataField = "Rayon"
    Me.Rayon.DataSource = Nothing
    Me.Rayon.LabelText = "Rayon:"
    Me.Rayon.Location = New System.Drawing.Point(760, 73)
    Me.Rayon.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Rayon.MaxLength = 30
    Me.Rayon.Name = "Rayon"
    Me.Rayon.RowSource = "select Rayon, (Rayon + ' ' + Rayontext) as Txt, Prv_Adress_ID from Rayon order by" &
    " Rayon"
    Me.Rayon.SelectedIndex = -1
    Me.Rayon.Size = New System.Drawing.Size(235, 21)
    Me.Rayon.TabIndex = 53
    Me.Rayon.TabStop = False
    Me.Rayon.Value = Nothing
    '
    'VisumDat
    '
    Me.VisumDat.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.VisumDat.DataField = "VisumDat"
    Me.VisumDat.Format = Comatic.Code.cmtFormat.DateLong
    Me.VisumDat.Location = New System.Drawing.Point(630, 4)
    Me.VisumDat.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.VisumDat.Name = "VisumDat"
    Me.VisumDat.Protected = True
    Me.VisumDat.Size = New System.Drawing.Size(120, 21)
    Me.VisumDat.TabIndex = 21
    Me.VisumDat.TabStop = False
    Me.VisumDat.Value = Nothing
    '
    'Prv_Adress_ID
    '
    Me.Prv_Adress_ID.Database = Nothing
    Me.Prv_Adress_ID.DataField = "Prv_Adress_ID"
    Me.Prv_Adress_ID.EmptyMode = Comatic.Code.cmtEmptyMode.Num0
    Me.Prv_Adress_ID.LabelText = "Provision:"
    Me.Prv_Adress_ID.Location = New System.Drawing.Point(760, 96)
    Me.Prv_Adress_ID.LookUpCommand = "select Vorname + Name from Adressen where Adress_ID = ?"
    Me.Prv_Adress_ID.LookUpText = "Provisionsempfänger"
    Me.Prv_Adress_ID.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Prv_Adress_ID.MarkerCond = Comatic.Code.cmtOperator.NotEqual
    Me.Prv_Adress_ID.MarkerCondValue = "0"
    Me.Prv_Adress_ID.MarkerField = "Adress_Status"
    Me.Prv_Adress_ID.MaxLength = 30
    Me.Prv_Adress_ID.Name = "Prv_Adress_ID"
    Me.Prv_Adress_ID.SelectCommand = "select Adress_ID, Vorname + Name as Txt, Plz + ' ' + Ort as PlzOrt, Adress_Status" &
    " from Adressen where Vorname + Name like '%?%' and Ort like '?%' and Parent_ID =" &
    " 0 order by Name"
    Me.Prv_Adress_ID.Size = New System.Drawing.Size(235, 21)
    Me.Prv_Adress_ID.TabIndex = 54
    Me.Prv_Adress_ID.TabStop = False
    Me.Prv_Adress_ID.Value = Nothing
    '
    'LAnrede
    '
    Me.LAnrede.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LAnrede.DataField = "LAnrede"
    Me.LAnrede.DataSource = Nothing
    Me.LAnrede.DropDownWidth = 120
    Me.LAnrede.LabelText = "Anrede:"
    Me.LAnrede.ListEntriesOnly = False
    Me.LAnrede.Location = New System.Drawing.Point(380, 50)
    Me.LAnrede.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LAnrede.MaxLength = 20
    Me.LAnrede.Name = "LAnrede"
    Me.LAnrede.RowSource = "select Ind, Ind as Txt, Lng from DB_Xlate where Tbl='Anreden' and Ind>'' order by" &
    " Ind"
    Me.LAnrede.SelectedIndex = -1
    Me.LAnrede.Size = New System.Drawing.Size(220, 21)
    Me.LAnrede.TabIndex = 23
    Me.LAnrede.Value = Nothing
    '
    'VisumAdm
    '
    Me.VisumAdm.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.VisumAdm.DataField = "VisumAdm"
    Me.VisumAdm.Location = New System.Drawing.Point(565, 4)
    Me.VisumAdm.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.VisumAdm.Name = "VisumAdm"
    Me.VisumAdm.Protected = True
    Me.VisumAdm.Size = New System.Drawing.Size(60, 21)
    Me.VisumAdm.TabIndex = 21
    Me.VisumAdm.TabStop = False
    Me.VisumAdm.Value = Nothing
    '
    'Auftragsfaktor
    '
    Me.Auftragsfaktor.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Auftragsfaktor.DataField = "Auftragsfaktor"
    Me.Auftragsfaktor.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Auftragsfaktor.Format = Comatic.Code.cmtFormat.Number
    Me.Auftragsfaktor.LabelText = "Auftragsfaktor:"
    Me.Auftragsfaktor.Location = New System.Drawing.Point(760, 188)
    Me.Auftragsfaktor.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Auftragsfaktor.Name = "Auftragsfaktor"
    Me.Auftragsfaktor.SelectionLength = 1
    Me.Auftragsfaktor.SelectionText = "1"
    Me.Auftragsfaktor.Size = New System.Drawing.Size(160, 21)
    Me.Auftragsfaktor.TabIndex = 58
    Me.Auftragsfaktor.TabStop = False
    Me.Auftragsfaktor.Value = "1"
    '
    'LVorname
    '
    Me.LVorname.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LVorname.DataField = "LVorname"
    Me.LVorname.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LVorname.Format = Comatic.Code.cmtFormat.User_Firstname
    Me.LVorname.LabelText = "Vorname:"
    Me.LVorname.Location = New System.Drawing.Point(380, 73)
    Me.LVorname.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LVorname.Name = "LVorname"
    Me.LVorname.Size = New System.Drawing.Size(370, 21)
    Me.LVorname.TabIndex = 24
    Me.LVorname.Value = Nothing
    '
    'Währung
    '
    Me.Währung.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Währung.DataField = "Währung"
    Me.Währung.DataSource = Nothing
    Me.Währung.DropDownWidth = 270
    Me.Währung.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Währung.LabelText = "Währung:"
    Me.Währung.Location = New System.Drawing.Point(760, 142)
    Me.Währung.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Währung.MaxLength = 30
    Me.Währung.Name = "Währung"
    Me.Währung.RowSource = "select Währungscode, (Währungscode + ' ' + Bezeichnung) as Txt from Währungen ord" &
    "er by Währungscode"
    Me.Währung.SelectedIndex = -1
    Me.Währung.Size = New System.Drawing.Size(235, 21)
    Me.Währung.TabIndex = 56
    Me.Währung.TabStop = False
    Me.Währung.Value = Nothing
    '
    'Name2
    '
    Me.Name2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Name2.ColumnCount = 1
    Me.Name2.DataField = "Name2"
    Me.Name2.DataSource = Nothing
    Me.Name2.DropDownWidth = 270
    Me.Name2.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.Name2.LabelText = "Zuhanden:"
    Me.Name2.ListEntriesOnly = False
    Me.Name2.Location = New System.Drawing.Point(1, 27)
    Me.Name2.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Name2.Name = "Name2"
    Me.Name2.SelectedIndex = -1
    Me.Name2.Size = New System.Drawing.Size(370, 21)
    Me.Name2.TabIndex = 2
    Me.Name2.Value = Nothing
    '
    'LName
    '
    Me.LName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LName.DataField = "LName"
    Me.LName.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LName.LabelText = "Name:"
    Me.LName.Location = New System.Drawing.Point(380, 96)
    Me.LName.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LName.Name = "LName"
    Me.LName.Size = New System.Drawing.Size(370, 21)
    Me.LName.TabIndex = 25
    Me.LName.Value = Nothing
    '
    'Konditionen
    '
    Me.Konditionen.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Konditionen.DataField = "Konditionen"
    Me.Konditionen.DataSource = Nothing
    Me.Konditionen.DropDownWidth = 270
    Me.Konditionen.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Konditionen.LabelText = "Konditionen:"
    Me.Konditionen.Location = New System.Drawing.Point(760, 211)
    Me.Konditionen.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Konditionen.MaxLength = 30
    Me.Konditionen.Name = "Konditionen"
    Me.Konditionen.RowSource = "select Konditionencode, Konditionentext from Konditionen order by Konditionencode" &
    ""
    Me.Konditionen.SelectedIndex = -1
    Me.Konditionen.Size = New System.Drawing.Size(235, 21)
    Me.Konditionen.TabIndex = 59
    Me.Konditionen.TabStop = False
    Me.Konditionen.Value = Nothing
    '
    'Status
    '
    Me.Status.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Status.Database = Comatic.Code.cmtDatabase.ValueList
    Me.Status.DataField = "Status"
    Me.Status.DataSource = Nothing
    Me.Status.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Status.LabelText = "Status:"
    Me.Status.Location = New System.Drawing.Point(760, 4)
    Me.Status.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Status.MaxLength = 10
    Me.Status.Name = "Status"
    Me.Status.SelectedIndex = -1
    Me.Status.Size = New System.Drawing.Size(235, 21)
    Me.Status.TabIndex = 50
    Me.Status.TabStop = False
    Me.Status.Value = Nothing
    '
    'LAdresse2
    '
    Me.LAdresse2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LAdresse2.DataField = "LAdresse2"
    Me.LAdresse2.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LAdresse2.LabelText = "Adresse 2:"
    Me.LAdresse2.Location = New System.Drawing.Point(380, 142)
    Me.LAdresse2.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LAdresse2.Name = "LAdresse2"
    Me.LAdresse2.Size = New System.Drawing.Size(370, 21)
    Me.LAdresse2.TabIndex = 27
    Me.LAdresse2.Value = Nothing
    '
    'ProjektKst
    '
    Me.ProjektKst.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.ProjektKst.DataField = "ProjektKst"
    Me.ProjektKst.DataSource = Nothing
    Me.ProjektKst.DropDownWidth = 270
    Me.ProjektKst.LabelText = "Projekt-Kst:"
    Me.ProjektKst.Location = New System.Drawing.Point(760, 119)
    Me.ProjektKst.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.ProjektKst.MaxLength = 30
    Me.ProjektKst.Name = "ProjektKst"
    Me.ProjektKst.RowSource = "select Kst, (Kst + ' ' + Kostenstellentext) as Txt, Kst_Status from Kostenstellen" &
    " order by Kst"
    Me.ProjektKst.SelectedIndex = -1
    Me.ProjektKst.Size = New System.Drawing.Size(235, 21)
    Me.ProjektKst.TabIndex = 55
    Me.ProjektKst.TabStop = False
    Me.ProjektKst.Value = Nothing
    '
    'LAdresse3
    '
    Me.LAdresse3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LAdresse3.DataField = "LAdresse3"
    Me.LAdresse3.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LAdresse3.LabelText = "Adresse 3:"
    Me.LAdresse3.Location = New System.Drawing.Point(380, 165)
    Me.LAdresse3.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LAdresse3.Name = "LAdresse3"
    Me.LAdresse3.Size = New System.Drawing.Size(370, 21)
    Me.LAdresse3.TabIndex = 28
    Me.LAdresse3.Value = Nothing
    '
    'MWStType
    '
    Me.MWStType.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.MWStType.Database = Comatic.Code.cmtDatabase.ValueList
    Me.MWStType.DataField = "MWStType"
    Me.MWStType.DataSource = Nothing
    Me.MWStType.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.MWStType.LabelText = "MWSt-Typ:"
    Me.MWStType.Location = New System.Drawing.Point(760, 234)
    Me.MWStType.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.MWStType.MaxLength = 20
    Me.MWStType.Name = "MWStType"
    Me.MWStType.SelectedIndex = -1
    Me.MWStType.Size = New System.Drawing.Size(235, 21)
    Me.MWStType.TabIndex = 60
    Me.MWStType.TabStop = False
    Me.MWStType.Value = Nothing
    '
    'Pendenznummer
    '
    Me.Pendenznummer.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Pendenznummer.DataField = "Pendenznummer"
    Me.Pendenznummer.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Pendenznummer.LabelText = "Belegnummer:"
    Me.Pendenznummer.Location = New System.Drawing.Point(380, 4)
    Me.Pendenznummer.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Pendenznummer.Name = "Pendenznummer"
    Me.Pendenznummer.Size = New System.Drawing.Size(180, 21)
    Me.Pendenznummer.TabIndex = 20
    Me.Pendenznummer.TabStop = False
    Me.Pendenznummer.Value = Nothing
    '
    'LPlz
    '
    Me.LPlz.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LPlz.DataField = "LPlz"
    Me.LPlz.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LPlz.LabelText = "Plz:"
    Me.LPlz.Location = New System.Drawing.Point(380, 188)
    Me.LPlz.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LPlz.Name = "LPlz"
    Me.LPlz.Size = New System.Drawing.Size(220, 21)
    Me.LPlz.TabIndex = 29
    Me.LPlz.Value = Nothing
    '
    'LOrt
    '
    Me.LOrt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LOrt.DataField = "LOrt"
    Me.LOrt.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LOrt.LabelText = "Ort:"
    Me.LOrt.Location = New System.Drawing.Point(380, 211)
    Me.LOrt.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LOrt.Name = "LOrt"
    Me.LOrt.Size = New System.Drawing.Size(370, 21)
    Me.LOrt.TabIndex = 30
    Me.LOrt.Value = Nothing
    '
    'Adresse3
    '
    Me.Adresse3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Adresse3.DataField = "Adresse3"
    Me.Adresse3.LabelText = "Adresse 3:"
    Me.Adresse3.Location = New System.Drawing.Point(1, 73)
    Me.Adresse3.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Adresse3.Name = "Adresse3"
    Me.Adresse3.Protected = True
    Me.Adresse3.Size = New System.Drawing.Size(370, 21)
    Me.Adresse3.TabIndex = 4
    Me.Adresse3.TabStop = False
    Me.Adresse3.Value = Nothing
    '
    'Suchbegriff
    '
    Me.Suchbegriff.Database = Nothing
    Me.Suchbegriff.DataField = "Adress_ID"
    Me.Suchbegriff.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Suchbegriff.LabelText = "Name:"
    Me.Suchbegriff.Location = New System.Drawing.Point(1, 4)
    Me.Suchbegriff.LookUpCommand = "select Vorname + Name from Adressen where Adress_ID = ?"
    Me.Suchbegriff.LookUpText = "Kundenname"
    Me.Suchbegriff.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Suchbegriff.MarkerCond = Comatic.Code.cmtOperator.NotEqual
    Me.Suchbegriff.MarkerCondValue = "0"
    Me.Suchbegriff.MarkerField = "Adress_Status"
    Me.Suchbegriff.MaxLength = 50
    Me.Suchbegriff.Name = "Suchbegriff"
    Me.Suchbegriff.SelectCommand = resources.GetString("Suchbegriff.SelectCommand")
    Me.Suchbegriff.Size = New System.Drawing.Size(334, 21)
    Me.Suchbegriff.TabIndex = 0
    Me.Suchbegriff.Value = Nothing
    '
    'LLand
    '
    Me.LLand.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LLand.Database = Comatic.Code.cmtDatabase.CommonData
    Me.LLand.DataField = "LLand"
    Me.LLand.DataSource = Nothing
    Me.LLand.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.LLand.LabelText = "Land:"
    Me.LLand.Location = New System.Drawing.Point(380, 234)
    Me.LLand.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LLand.MaxLength = 30
    Me.LLand.Name = "LLand"
    Me.LLand.RowSource = "select ISO_Landcode, Bezeichnung from cRegions order by Bezeichnung"
    Me.LLand.SelectedIndex = -1
    Me.LLand.Size = New System.Drawing.Size(370, 21)
    Me.LLand.TabIndex = 31
    Me.LLand.Value = Nothing
    '
    'Plz
    '
    Me.Plz.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Plz.DataField = "Plz"
    Me.Plz.LabelText = "Plz:"
    Me.Plz.Location = New System.Drawing.Point(1, 96)
    Me.Plz.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Plz.Name = "Plz"
    Me.Plz.Protected = True
    Me.Plz.Size = New System.Drawing.Size(220, 21)
    Me.Plz.TabIndex = 5
    Me.Plz.TabStop = False
    Me.Plz.Value = Nothing
    '
    'LAdresse1
    '
    Me.LAdresse1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.LAdresse1.DataField = "LAdresse1"
    Me.LAdresse1.EmptyMode = Comatic.Code.cmtEmptyMode.EmptyString
    Me.LAdresse1.LabelText = "Adresse 1:"
    Me.LAdresse1.Location = New System.Drawing.Point(380, 119)
    Me.LAdresse1.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LAdresse1.Name = "LAdresse1"
    Me.LAdresse1.Size = New System.Drawing.Size(370, 21)
    Me.LAdresse1.TabIndex = 26
    Me.LAdresse1.Value = Nothing
    '
    'LbTeilLS
    '
    Me.LbTeilLS.LabelText = "Teil-Lief. erlaubt:"
    Me.LbTeilLS.Location = New System.Drawing.Point(257, 165)
    Me.LbTeilLS.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.LbTeilLS.Name = "LbTeilLS"
    Me.LbTeilLS.Size = New System.Drawing.Size(100, 21)
    Me.LbTeilLS.TabIndex = 10
    Me.LbTeilLS.TabStop = False
    '
    'Ort
    '
    Me.Ort.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Ort.DataField = "Ort"
    Me.Ort.LabelText = "Ort:"
    Me.Ort.Location = New System.Drawing.Point(1, 119)
    Me.Ort.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Ort.Name = "Ort"
    Me.Ort.Protected = True
    Me.Ort.Size = New System.Drawing.Size(370, 21)
    Me.Ort.TabIndex = 6
    Me.Ort.TabStop = False
    Me.Ort.Value = Nothing
    '
    'TeilLS
    '
    Me.TeilLS.BackColor = System.Drawing.Color.White
    Me.TeilLS.DataField = "TeilLS"
    Me.TeilLS.DefaultValue = "0"
    Me.TeilLS.EmptyMode = Comatic.Code.cmtEmptyMode.Num0
    Me.TeilLS.Location = New System.Drawing.Point(357, 165)
    Me.TeilLS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
    Me.TeilLS.MaxLength = 1
    Me.TeilLS.Name = "TeilLS"
    Me.TeilLS.Size = New System.Drawing.Size(14, 21)
    Me.TeilLS.TabIndex = 10
    Me.TeilLS.TabStop = False
    Me.TeilLS.Value = 0
    '
    'Referenz
    '
    Me.Referenz.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Referenz.DataField = "Referenz"
    Me.Referenz.LabelText = "Referenz:"
    Me.Referenz.Location = New System.Drawing.Point(1, 142)
    Me.Referenz.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Referenz.Name = "Referenz"
    Me.Referenz.Size = New System.Drawing.Size(370, 21)
    Me.Referenz.TabIndex = 7
    Me.Referenz.Value = Nothing
    '
    'Datum
    '
    Me.Datum.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Datum.DataField = "Datum"
    Me.Datum.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
    Me.Datum.Format = Comatic.Code.cmtFormat.DateShort
    Me.Datum.LabelText = "Liefertermin:"
    Me.Datum.Location = New System.Drawing.Point(1, 165)
    Me.Datum.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Datum.Name = "Datum"
    Me.Datum.Size = New System.Drawing.Size(180, 21)
    Me.Datum.TabIndex = 8
    Me.Datum.Value = Nothing
    '
    'Lieferdatum
    '
    Me.Lieferdatum.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.Lieferdatum.DataField = "Lieferdatum"
    Me.Lieferdatum.Format = Comatic.Code.cmtFormat.DateShort
    Me.Lieferdatum.LabelText = "Letzte Lieferung:"
    Me.Lieferdatum.Location = New System.Drawing.Point(1, 188)
    Me.Lieferdatum.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Lieferdatum.Name = "Lieferdatum"
    Me.Lieferdatum.Protected = True
    Me.Lieferdatum.Size = New System.Drawing.Size(180, 21)
    Me.Lieferdatum.TabIndex = 9
    Me.Lieferdatum.TabStop = False
    Me.Lieferdatum.Value = Nothing
    '
    'Rechnungsadresse
    '
    Me.Rechnungsadresse.Database = Nothing
    Me.Rechnungsadresse.DataField = "Rechnungsadresse"
    Me.Rechnungsadresse.EmptyMode = Comatic.Code.cmtEmptyMode.Num0
    Me.Rechnungsadresse.LabelText = "Rechnung an:"
    Me.Rechnungsadresse.Location = New System.Drawing.Point(1, 211)
    Me.Rechnungsadresse.LookUpCommand = "select Vorname + Name from Adressen where Adress_ID = ?"
    Me.Rechnungsadresse.LookUpText = "Rechnungsadresse"
    Me.Rechnungsadresse.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Rechnungsadresse.MarkerCond = Comatic.Code.cmtOperator.NotEqual
    Me.Rechnungsadresse.MarkerCondValue = "0"
    Me.Rechnungsadresse.MarkerField = "Adress_Status"
    Me.Rechnungsadresse.MaxLength = 30
    Me.Rechnungsadresse.Name = "Rechnungsadresse"
    Me.Rechnungsadresse.SelectCommand = resources.GetString("Rechnungsadresse.SelectCommand")
    Me.Rechnungsadresse.Size = New System.Drawing.Size(370, 21)
    Me.Rechnungsadresse.TabIndex = 11
    Me.Rechnungsadresse.Value = Nothing
    '
    'Zustelladresse
    '
    Me.Zustelladresse.Database = Nothing
    Me.Zustelladresse.DataField = "Zustelladresse"
    Me.Zustelladresse.EmptyMode = Comatic.Code.cmtEmptyMode.Num0
    Me.Zustelladresse.LabelText = "Zustelladresse:"
    Me.Zustelladresse.Location = New System.Drawing.Point(1, 234)
    Me.Zustelladresse.LookUpCommand = "select Vorname + Name from Adressen where Adress_ID = ?"
    Me.Zustelladresse.LookUpText = "Zustelladresse"
    Me.Zustelladresse.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
    Me.Zustelladresse.MarkerCond = Comatic.Code.cmtOperator.NotEqual
    Me.Zustelladresse.MarkerCondValue = "0"
    Me.Zustelladresse.MarkerField = "Adress_Status"
    Me.Zustelladresse.MaxLength = 30
    Me.Zustelladresse.Name = "Zustelladresse"
    Me.Zustelladresse.SelectCommand = "select Adress_ID, Vorname + Name as Txt, Adresse1, Adresse2, Adresse3, Plz + ' ' " &
    "+ Ort as PlzOrt, Adress_Status from Adressen where Vorname + Name like '%?%' and" &
    " Ort like '?%' order by Name"
    Me.Zustelladresse.Size = New System.Drawing.Size(370, 21)
    Me.Zustelladresse.TabIndex = 12
    Me.Zustelladresse.Value = Nothing
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.White
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1000, 276)
    Me.Panel2.TabIndex = 90
    Me.Panel2.TabStop = True
    '
    'TabEinleitung
    '
    Me.TabEinleitung.BackColor = System.Drawing.Color.White
    Me.TabEinleitung.Location = New System.Drawing.Point(4, 22)
    Me.TabEinleitung.Name = "TabEinleitung"
    Me.TabEinleitung.Size = New System.Drawing.Size(1000, 542)
    Me.TabEinleitung.TabIndex = 2
    Me.TabEinleitung.Text = "Einleitung"
    '
    'TabPositionen
    '
    Me.TabPositionen.BackColor = System.Drawing.Color.White
    Me.TabPositionen.Location = New System.Drawing.Point(4, 22)
    Me.TabPositionen.Name = "TabPositionen"
    Me.TabPositionen.Size = New System.Drawing.Size(1000, 542)
    Me.TabPositionen.TabIndex = 7
    Me.TabPositionen.Text = "Positionen"
    '
    'TabSchluss
    '
    Me.TabSchluss.BackColor = System.Drawing.Color.White
    Me.TabSchluss.Location = New System.Drawing.Point(4, 22)
    Me.TabSchluss.Name = "TabSchluss"
    Me.TabSchluss.Size = New System.Drawing.Size(1000, 542)
    Me.TabSchluss.TabIndex = 3
    Me.TabSchluss.Text = "Schluss"
    '
    'TabEinkauf
    '
    Me.TabEinkauf.BackColor = System.Drawing.Color.White
    Me.TabEinkauf.Location = New System.Drawing.Point(4, 22)
    Me.TabEinkauf.Name = "TabEinkauf"
    Me.TabEinkauf.Size = New System.Drawing.Size(1000, 542)
    Me.TabEinkauf.TabIndex = 4
    Me.TabEinkauf.Text = "Einkauf"
    '
    'TabLager
    '
    Me.TabLager.BackColor = System.Drawing.Color.White
    Me.TabLager.Location = New System.Drawing.Point(4, 22)
    Me.TabLager.Name = "TabLager"
    Me.TabLager.Size = New System.Drawing.Size(1000, 542)
    Me.TabLager.TabIndex = 5
    Me.TabLager.Text = "Lager"
    '
    'TabMaterial
    '
    Me.TabMaterial.BackColor = System.Drawing.Color.White
    Me.TabMaterial.Location = New System.Drawing.Point(4, 22)
    Me.TabMaterial.Name = "TabMaterial"
    Me.TabMaterial.Size = New System.Drawing.Size(1000, 542)
    Me.TabMaterial.TabIndex = 8
    Me.TabMaterial.Text = "Material-Auszug"
    '
    'TabProvisionen
    '
    Me.TabProvisionen.BackColor = System.Drawing.Color.White
    Me.TabProvisionen.Location = New System.Drawing.Point(4, 22)
    Me.TabProvisionen.Name = "TabProvisionen"
    Me.TabProvisionen.Size = New System.Drawing.Size(1000, 542)
    Me.TabProvisionen.TabIndex = 6
    Me.TabProvisionen.Text = "Provisionen"
    '
    'cmdLSV
    '
    Me.cmdLSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdLSV.Enabled = False
    Me.cmdLSV.ImageIndex = 0
    Me.cmdLSV.ImageList = Me.ImageList1
    Me.cmdLSV.Location = New System.Drawing.Point(581, 574)
    Me.cmdLSV.Name = "cmdLSV"
    Me.cmdLSV.Size = New System.Drawing.Size(30, 23)
    Me.cmdLSV.TabIndex = 207
    Me.cmdLSV.TabStop = False
    Me.cmdLSV.UseVisualStyleBackColor = True
    '
    'cmdLS
    '
    Me.cmdLS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdLS.Enabled = False
    Me.cmdLS.Location = New System.Drawing.Point(455, 574)
    Me.cmdLS.Name = "cmdLS"
    Me.cmdLS.Size = New System.Drawing.Size(120, 23)
    Me.cmdLS.TabIndex = 206
    Me.cmdLS.TabStop = False
    Me.cmdLS.Text = "Lieferschein"
    Me.cmdLS.UseVisualStyleBackColor = True
    '
    'cmdRSV
    '
    Me.cmdRSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdRSV.Enabled = False
    Me.cmdRSV.ImageIndex = 0
    Me.cmdRSV.ImageList = Me.ImageList1
    Me.cmdRSV.Location = New System.Drawing.Point(419, 574)
    Me.cmdRSV.Name = "cmdRSV"
    Me.cmdRSV.Size = New System.Drawing.Size(30, 23)
    Me.cmdRSV.TabIndex = 205
    Me.cmdRSV.TabStop = False
    Me.cmdRSV.UseVisualStyleBackColor = True
    '
    'cmdRS
    '
    Me.cmdRS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdRS.Enabled = False
    Me.cmdRS.Location = New System.Drawing.Point(293, 574)
    Me.cmdRS.Name = "cmdRS"
    Me.cmdRS.Size = New System.Drawing.Size(120, 23)
    Me.cmdRS.TabIndex = 204
    Me.cmdRS.TabStop = False
    Me.cmdRS.Text = "Rüstschein"
    Me.cmdRS.UseVisualStyleBackColor = True
    '
    'cmdBSV
    '
    Me.cmdBSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdBSV.Enabled = False
    Me.cmdBSV.ImageIndex = 0
    Me.cmdBSV.ImageList = Me.ImageList1
    Me.cmdBSV.Location = New System.Drawing.Point(257, 574)
    Me.cmdBSV.Name = "cmdBSV"
    Me.cmdBSV.Size = New System.Drawing.Size(30, 23)
    Me.cmdBSV.TabIndex = 203
    Me.cmdBSV.TabStop = False
    Me.cmdBSV.UseVisualStyleBackColor = True
    '
    'cmdBS
    '
    Me.cmdBS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdBS.Enabled = False
    Me.cmdBS.Location = New System.Drawing.Point(131, 574)
    Me.cmdBS.Name = "cmdBS"
    Me.cmdBS.Size = New System.Drawing.Size(120, 23)
    Me.cmdBS.TabIndex = 202
    Me.cmdBS.TabStop = False
    Me.cmdBS.Text = "Bestätigung"
    Me.cmdBS.UseVisualStyleBackColor = True
    '
    'cmdNew
    '
    Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdNew.Enabled = False
    Me.cmdNew.Location = New System.Drawing.Point(5, 574)
    Me.cmdNew.Name = "cmdNew"
    Me.cmdNew.Size = New System.Drawing.Size(120, 23)
    Me.cmdNew.TabIndex = 201
    Me.cmdNew.TabStop = False
    Me.cmdNew.Text = "Neuer Auftrag"
    Me.cmdNew.UseVisualStyleBackColor = True
    '
    'Form_AufträgeDetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.cmdLSV)
    Me.Controls.Add(Me.cmdNew)
    Me.Controls.Add(Me.cmdLS)
    Me.Controls.Add(Me.cmdBS)
    Me.Controls.Add(Me.cmdRSV)
    Me.Controls.Add(Me.cmdBSV)
    Me.Controls.Add(Me.cmdRS)
    Me.Name = "Form_AufträgeDetail"
    Me.Size = New System.Drawing.Size(1008, 600)
    Me.TabControl1.ResumeLayout(False)
    Me.TabHauptdaten.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Status As Comatic.Txc
  Friend WithEvents Pendenznummer As Comatic.Tx
  Friend WithEvents VisumDat As Comatic.Tx
  Friend WithEvents VisumAdm As Comatic.Tx
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabHauptdaten As System.Windows.Forms.TabPage
  Friend WithEvents cmdNew As System.Windows.Forms.Button
  Friend WithEvents cmdBSV As System.Windows.Forms.Button
  Friend WithEvents cmdBS As System.Windows.Forms.Button
  Friend WithEvents cmdRSV As System.Windows.Forms.Button
  Friend WithEvents cmdRS As System.Windows.Forms.Button
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents TabEinleitung As System.Windows.Forms.TabPage
  Friend WithEvents TabSchluss As System.Windows.Forms.TabPage
  Friend WithEvents TabEinkauf As System.Windows.Forms.TabPage
  Friend WithEvents TabLager As System.Windows.Forms.TabPage
  Friend WithEvents TabProvisionen As System.Windows.Forms.TabPage
  Friend WithEvents cmdLSV As System.Windows.Forms.Button
  Friend WithEvents cmdLS As System.Windows.Forms.Button
  Friend WithEvents Name2 As Comatic.Txc
  Friend WithEvents Ort As Comatic.Tx
  Friend WithEvents Plz As Comatic.Tx
  Friend WithEvents Adresse3 As Comatic.Tx
  Friend WithEvents Adresse2 As Comatic.Tx
  Friend WithEvents Lieferadresse As Comatic.Txc
  Friend WithEvents Lieferdatum As Comatic.Tx
  Friend WithEvents Datum As Comatic.Tx
  Friend WithEvents Referenz As Comatic.Tx
  Friend WithEvents LOrt As Comatic.Tx
  Friend WithEvents LPlz As Comatic.Tx
  Friend WithEvents LAdresse3 As Comatic.Tx
  Friend WithEvents LAdresse2 As Comatic.Tx
  Friend WithEvents LName As Comatic.Tx
  Friend WithEvents LVorname As Comatic.Tx
  Friend WithEvents LAnrede As Comatic.Txc
  Friend WithEvents LLand As Comatic.Txc
  Friend WithEvents LAdresse1 As Comatic.Tx
  Friend WithEvents Rechnungsadresse As Comatic.Txp
  Friend WithEvents Zustelladresse As Comatic.Txp
  Friend WithEvents Lagerort As Comatic.Txc
  Friend WithEvents Lieferart As Comatic.Txc
  Friend WithEvents Prv_Adress_ID As Comatic.Txp
  Friend WithEvents Rayon As Comatic.Txc
  Friend WithEvents Auftragsfaktor As Comatic.Tx
  Friend WithEvents Währung As Comatic.Txc
  Friend WithEvents Konditionen As Comatic.Txc
  Friend WithEvents ProjektKst As Comatic.Txc
  Friend WithEvents TeilLS As Comatic.Txx
  Friend WithEvents MWStType As Comatic.Txc
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Buchungskurs As Comatic.Tx
  Friend WithEvents cmdDrct As System.Windows.Forms.Button
  Friend WithEvents cmdNeueAdresse As System.Windows.Forms.Button
  Public WithEvents Suchbegriff As Comatic.Txp
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents TabPositionen As System.Windows.Forms.TabPage
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents cmdGoogleMaps As System.Windows.Forms.Button
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents cmdSearch As System.Windows.Forms.Button
  Friend WithEvents LbTeilLS As Comatic.Lb
  Friend WithEvents TabMaterial As System.Windows.Forms.TabPage

End Class
