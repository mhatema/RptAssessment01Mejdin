<System.ComponentModel.ToolboxItem(False)>
Public Class Form_AufträgeDetail
  Public mvr As cmtRole = cmtRole.Undefined
  Public WithEvents mr1 As New Rowset

  Dim mnBuchungs_ID As Integer
  Dim miLager As Integer

    'Public Sub New()
    '  On Error Resume Next
    '  InitializeComponent()
    '  Me.Tag = Xtext("Auftrag")
    '  Me.ToolTip1.SetToolTip(Me.cmdGoogleMaps, Xtext("Google Maps"))
    '  Me.ToolTip1.SetToolTip(Me.cmdDrct, Xtext("In Directories nachschauen"))
    '  Me.ToolTip1.SetToolTip(Me.cmdSearch, Xtext("Im Adressenstamm nachschauen"))
    '  Me.Status.DataSource = Erpbox(cmtERPCombo.Status_Aufträge)
    '  Me.Status.BindFormat(cmtOperator.Equal, 3, cmtColor.Yellow)
    '  Me.Status.BindFormat(cmtOperator.Equal, 6, cmtColor.Green)
    '  Me.Status.BindFormat(cmtOperator.Equal, 7, cmtColor.Red)
    '  Me.Status.BindFormat(cmtOperator.Equal, 9, cmtColor.Purple)
    '  Me.MWStType.DataSource = Erpbox(cmtERPCombo.MWStType)
    '  Me.Lieferadresse.CanTabulate = True
    '  On Error GoTo 0
    'End Sub

    'Private Sub Form_DockChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DockChanged
    '  On Error Resume Next
    '  FormLoadPlugIns(Me, Me.TabControl1)
    '  Me.SplitContainer1.SplitterDistance = GetFrmVal(Me.Name, "Splitter1", Me.SplitContainer1.SplitterDistance * gdY)
    '  On Error Resume Next
    'End Sub

    'Public WriteOnly Property OpenArgs() As Object
    '  Set(ByVal value As Object)
    '    On Error Resume Next
    '    mnBuchungs_ID = Num(GetArgs(value, 0, 0))
    '    miLager = GetArgs(value, 2, gnStandardlager)
    '    mr1.EnableEvents = False
    '    mr1.Open(
    '      "select Pendenzen.*, " &
    '      "Adressen.Adresse2, Adressen.Adresse3, Adressen.Plz, Adressen.Ort, " &
    '      "Adressen.Land, Adressen.Briefanrede, Adressen.Sprache, Adressen.E_Mail, Adressen.Adress_Status, " &
    '      "Adressen.Preisliste, Adressen.Rechnungskopien, Adressen.StandardText_ID " &
    '      "from Pendenzen left join Adressen on Pendenzen.Adress_ID = Adressen.Adress_ID " &
    '      "where Buchungs_ID = " & mnBuchungs_ID)
    '    mr1.Bind(Me.Panel1, Me.Panel1)
    '    mr1.DefaultValue("Datum") = ValDate(Today)
    '    mr1.DefaultValue("Status") = 4
    '    mr1.DefaultValue("Währung") = gavGlb(27)
    '    If mvr > cmtRole.ReadOnly Then
    '      If CheckCancel("Pendenzen", "Buchungs_ID", 50, mnBuchungs_ID) Then
    '        mvr = cmtRole.ReadOnly
    '      End If
    '    End If
    '    If mvr <= cmtRole.ReadOnly Then
    '      mr1.ReadOnly = True
    '      Me.cmdNeueAdresse.Enabled = False
    '    Else
    '      mr1.AllowAdditions = False
    '      mr1.AllowDeletions = False
    '    End If
    '    If mr1.EOF And mr1.AllowEdits Then
    '      Dim nAdress_ID As Integer = Num(GetArgs(value, 1, 0))
    '      mr1.AllowAdditions = True
    '      mr1.AddNew()
    '      If nAdress_ID > 0 Then
    '        mr1!Adress_ID = nAdress_ID
    '        SetFields()
    '      End If
    '      mr1.AllowAdditions = False
    '    End If
    '    mr1.EnableEvents = True
    '    mr1.RaisePositionChanged()
    '    On Error GoTo 0
    '  End Set
    'End Property

    'Private Sub Form_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
    '  On Error Resume Next
    '  If mr1.IsDirty Then
    '    mr1.Update()
    '  End If
    '  If (mvr > cmtRole.ReadOnly) And (mnBuchungs_ID > 0) Then
    '    ObjectLocking(cmtLockType.Unlock, "Pendenzen", mnBuchungs_ID)
    '  End If
    '  Disp(mr1)
    '  On Error GoTo 0
    'End Sub

    'Private Sub mr1_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mr1.PositionChanged
    '  On Error Resume Next
    '  Dim bOK As Boolean = (Num(mr1!Buchungs_ID) > 0) And mr1.AllowEdits
    '  If IsNull(mr1!Adress_ID) = False Then
    '    Me.Name2.RowSource =
    '      "select (Anrede + ' ' + Vorname + Name) as Txt " &
    '      "from Adressen " &
    '      "where Parent_ID = " & Num(mr1!Adress_ID) & " " &
    '      "order by Name"
    '    Me.Lieferadresse.RowSource =
    '     "select Adress_ID, (Vorname + Name + ', ' + Ort) as Txt " &
    '     "from Adressen " &
    '     "where Parent_ID = " & Num(mr1!Adress_ID) & " and Lieferadresse <> 0 " &
    '     "order by Name"
    '  End If
    '  Me.cmdNew.Enabled = bOK
    '  Me.cmdBS.Enabled = bOK
    '  Me.cmdBSV.Enabled = bOK
    '  Me.cmdRS.Enabled = bOK
    '  Me.cmdRSV.Enabled = bOK
    '  Me.cmdLS.Enabled = bOK
    '  Me.cmdLSV.Enabled = bOK
    '  Me.cmdDrct.Enabled = bOK
    '  Me.cmdSearch.Enabled = bOK
    '  Me.cmdGoogleMaps.Enabled = bOK
    '  Me.Lieferadresse.Enabled = bOK
    '  Me.Panel2.Enabled = bOK
    '  Me.TabHauptdaten.Text = Me.Tag & " " & Me.Suchbegriff.Text
    '  Me.Parent.Text = Me.Tag & " " & Me.Suchbegriff.Text
    '  Me.TabControl1_SelectedIndexChanged(Nothing, Nothing)
    '  On Error GoTo 0
    'End Sub

    'Private Sub mr1_UpdateBegin(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mr1.UpdateBegin
    '  On Error Resume Next
    '  If IsNull(mr1!Adress_ID) Then
    '    e.Cancel = True
    '  End If
    '  If e.Cancel = False Then
    '    mr1!VisumDat = Now
    '    mr1!VisumAdm = gvUser.Login
    '    If (mr1!ProjektKst & "" > "") AndAlso (mr1!ProjektKst & "" <> mr1.OldValue("ProjektKst") & "") Then
    '      gdb.Execute(
    '        "update PendenzenZeilen " &
    '        "set Kst = '" & SetPat(mr1!ProjektKst) & "' " &
    '        "where Buchungs_ID = " & Num(mr1!Buchungs_ID) & " " &
    '        "and (Buchungstyp = 11 or Buchungstyp = 13) " &
    '        "and Menge <> 0")
    '    End If
    '    CalcAll("Pendenzen", Num(mr1!Buchungs_ID), mr1)
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    '  On Error Resume Next
    '  If IsNull(Me.TabControl1.SelectedTab.Tag) Then
    '    Me.TabControl1.SelectedTab.Tag = "OK"
    '    Select Case Me.TabControl1.SelectedTab.Name
    '      Case "TabHauptdaten"
    '        FormCreate(Me, Me.Panel2, "AufträgeDetailPos", Num(mr1!Buchungs_ID))
    '      Case "TabEinleitung"
    '        FormCreate(Me, Me.TabEinleitung, "BuchungenTexte", SetArgs(IIf((Num(mr1!Status) = 4), 1, 2), "Pendenzen", mnBuchungs_ID))
    '      Case "TabPositionen"
    '        FormCreate(Me, Me.TabPositionen, "AufträgeDetailZeilen", mnBuchungs_ID)
    '      Case "TabSchluss"
    '        FormCreate(Me, Me.TabSchluss, "BuchungenTexte", SetArgs(IIf((Num(mr1!Status) = 4), 11, 12), "Pendenzen", mnBuchungs_ID))
    '      Case "TabEinkauf"
    '        FormCreate(Me, Me.TabEinkauf, "AufträgeDetailEinkauf", mnBuchungs_ID)
    '      Case "TabLager"
    '        FormCreate(Me, Me.TabLager, "BuchungenLager", SetArgs("Pendenzen", mnBuchungs_ID))
    '      Case "TabMaterial"
    '        FormCreate(Me, Me.TabMaterial, "BuchungenMaterial", SetArgs("Pendenzen", mnBuchungs_ID, False))
    '      Case "TabProvisionen"
    '        FormCreate(Me, Me.TabProvisionen, "BuchungenProvisionen", SetArgs("Pendenzen", mnBuchungs_ID))
    '      Case Else
    '        With CType(Me.TabControl1.SelectedTab.Controls(0), Object)
    '          .OpenArgs = mnBuchungs_ID
    '          .mr1.Focus()
    '        End With
    '    End Select
    '  Else
    '    With CType(Me.TabControl1.SelectedTab.Controls(0), Object)
    '      Select Case Me.TabControl1.SelectedTab.Name
    '        Case "TabHauptdaten"
    '          mr1.Focus()
    '          Pos_Requery()
    '        Case "TabEinleitung"
    '          .OpenArgs = SetArgs(IIf((Num(mr1!Status) = 4), 1, 2), "Pendenzen", mnBuchungs_ID)
    '          .mr1.Focus()
    '        Case "TabPositionen", "TabEinkauf"
    '          .OpenArgs = mnBuchungs_ID
    '          .mr1.Focus()
    '        Case "TabSchluss"
    '          .OpenArgs = SetArgs(IIf((Num(mr1!Status) = 4), 11, 12), "Pendenzen", mnBuchungs_ID)
    '          .mr1.Focus()
    '        Case "TabLager", "TabMaterial", "TabProvisionen"
    '          .OpenArgs = SetArgs("Pendenzen", mnBuchungs_ID)
    '          .mr1.Focus()
    '        Case Else
    '          .OpenArgs = mnBuchungs_ID
    '          .mr1.Focus()
    '      End Select
    '    End With
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub TabControl1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TabControl1.Validating
    '  On Error Resume Next
    '  mr1.Update()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Panel2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Panel2.Validating
    '  On Error Resume Next
    '  If Me.Panel2.Controls.Count > 0 Then
    '    With CType(Me.Panel2.Controls(0), Object)
    '      .mr1.Update()
    '      .mr2.Update()
    '    End With
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Pos_Requery()
    '  On Error Resume Next
    '  If Me.Panel2.Controls.Count > 0 Then
    '    With CType(Me.Panel2.Controls(0), Object)
    '      .mr1.Requery()
    '      .mr2.Requery()
    '    End With
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub SetFields()
    '  On Error Resume Next
    '  Dim nLagerort_old As Integer = Num(mr1!Lagerort)
    '  Dim r1 As New Snapshot("select * from Adressen where Adress_ID = " & Num(mr1!Adress_ID))
    '  If CheckLimite(IIf(r1!Rechnungsadresse = 0, r1!Adress_ID, r1!Rechnungsadresse)) Then
    '    mr1!Konditionen = r1!VK_Konditionen
    '    mr1!Währung = r1!Währung
    '    mr1!Buchungskurs = GetKurs(mr1!Währung, mr1!Datum)
    '    mr1!Rayon = r1!Rayon
    '    mr1!Rechnungsadresse = r1!Rechnungsadresse
    '    If mr1!Rechnungsadresse > 0 Then
    '      mr1!Rayon = gdb.Lookup("Rayon", "Adressen", "Adress_ID = " & mr1!Rechnungsadresse)
    '    End If
    '    UpdateRayon()
    '    mr1!Zustelladresse = r1!Zustelladresse
    '    mr1!Name2 = r1!Adresse1
    '    If mnBuchungs_ID > 0 Then
    '      SwitchBriefanrede(mr1!Buchungs_ID, "Pendenzen", mr1!Briefanrede2 & "", r1!Briefanrede)
    '    End If
    '    mr1!Briefanrede2 = r1!Briefanrede
    '    If (mr1!Pendenznummer & "") = "" Then
    '      mr1!Pendenznummer = GetPendenzNr()
    '    End If
    '    mr1!Buchungstyp = 1
    '    mr1!Buchungstext = Xtext("Rechnung")
    '    mr1!OP = True
    '    mr1!Sammelkonto = gavGlb(9)
    '    If gdb.Lookup("Zahlart", "Konditionen", "Konditionencode = '" & mr1!Konditionen & "'") = 9 Then
    '      mr1!Status = 3
    '    Else
    '      mr1!Status = 4
    '    End If
    '    mr1!Referenz = r1!Adress_Referenz
    '    mr1!Lieferart = r1!Lieferart
    '    mr1!Lagerort = miLager
    '    mr1!ProjektKst = r1!ProjektKst
    '    mr1!TeilLS = r1!TeilLS
    '    If mr1!MWStType <> r1!MWStType Then
    '      mr1!MWStType = r1!MWStType
    '      UpdateMWSt()
    '    End If
    '    Dim r2 As New Snapshot("select * from Adressen where Parent_ID = " & Num(mr1!Adress_ID) & " and Lieferadresse <> 0 order by Name")
    '    If r2.EOF Then
    '      mr1!LAnrede = r1!Anrede
    '      mr1!LVorname = r1!Vorname
    '      mr1!LName = r1!Name
    '      mr1!LAdresse1 = r1!Adresse1
    '      mr1!LAdresse2 = r1!Adresse2
    '      mr1!LAdresse3 = r1!Adresse3
    '      mr1!LPlz = r1!Plz
    '      mr1!LOrt = r1!Ort
    '      mr1!LLand = r1!Land
    '    Else
    '      mr1!LAnrede = r2!Anrede
    '      mr1!LVorname = r2!Vorname
    '      mr1!LName = r2!Name
    '      mr1!LAdresse1 = r2!Adresse1
    '      mr1!LAdresse2 = r2!Adresse2
    '      mr1!LAdresse3 = r2!Adresse3
    '      mr1!LPlz = r2!Plz
    '      mr1!LOrt = r2!Ort
    '      mr1!LLand = r2!Land
    '    End If
    '    Disp(r2)
    '    mr1.Update()
    '    mr1.Filter = "Buchungs_ID = " & mr1!Buchungs_ID
    '    If mnBuchungs_ID = 0 Then
    '      mnBuchungs_ID = mr1!Buchungs_ID
    '      If Me.Panel2.Controls.Count > 0 Then
    '        CType(Me.Panel2.Controls(0), Object).OpenArgs = mnBuchungs_ID
    '      End If
    '      ObjectLocking(cmtLockType.Lock, "Pendenzen", mnBuchungs_ID)
    '      r2 = New Snapshot(
    '        "select * from Texte " &
    '        "where Text_ID = '" & SetPat(mr1!StandardText_ID) & "' and Texttyp < 20 and Sprache = '" & mr1!Sprache & "'")
    '      If r2.HasData Then
    '        Dim rtx1 As New RichTextBox
    '        Dim r3 As New Recordset("select * from PendenzenTexte where Buchungs_ID = 0")
    '        Dim r4 As New Snapshot(
    '          "select Pendenzen.*, Adressen.*, Konditionentext " &
    '          "from (Pendenzen " &
    '          "left join Adressen on Pendenzen.Adress_ID = Adressen.Adress_ID) " &
    '          "left join Konditionen on Pendenzen.Konditionen = Konditionen.Konditionencode " &
    '          "where Buchungs_ID = " & mr1!Buchungs_ID)
    '        While r2.HasData
    '          rtx1.Rtf = InsVar(r2!Text1 & "", r4)
    '          If rtx1.TextLength > 0 Then
    '            InsObjFrm(rtx1)
    '            r3.AddNew()
    '            r3!Zeilen_ID = GetPKey("PendenzenTexte", "Zeilen_ID")
    '            r3!Buchungs_ID = mr1!Buchungs_ID
    '            r3!Text_ID = r2!Text_ID
    '            r3!TextTyp = r2!TextTyp
    '            r3!Text1 = rtx1.Rtf
    '            r3.Update()
    '          End If
    '          r2.MoveNext()
    '        End While
    '        Disp(r4)
    '        Disp(r3)
    '        Disp(rtx1)
    '      End If
    '      Disp(r2)
    '    End If
    '  Else
    '    mr1!Adress_ID = mr1.OldValue("Adress_ID")
    '  End If
    '  Disp(r1)
    '  If mnBuchungs_ID > 0 Then
    '    If Num(DCount("Adress_ID", "AdressenHistory", "Adress_ID = " & mr1!Adress_ID & " and Geplant <> 0")) Then
    '      FormOpen("AdressenHistory", Xtext("Pendenzen"), cmtMode.Dialog, "Adress_ID = " & mr1!Adress_ID & " and Geplant <> 0")
    '    End If
    '    If nLagerort_old <> Num(mr1!Lagerort) Then
    '      Me.Lagerort_AfterUpdate(Nothing, Nothing)
    '    End If
    '    UpdateSNs()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub UpdateMWSt()
    '  On Error Resume Next
    '  LoadMWSt("Pendenzen", "VK", mr1)
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub UpdateProvisionen(ByVal nPrv_Adress_ID_old As Integer)
    '  On Error Resume Next
    '  If mr1!Prv_Adress_ID <> nPrv_Adress_ID_old Then
    '    CalcProvisionen("PendenzenZeilen", mnBuchungs_ID, nPrv_Adress_ID_old, mr1!Prv_Adress_ID, mr1!Währung)
    '  End If
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub UpdateRayon()
    '  On Error Resume Next
    '  LoadTarif("Pendenzen", "Menge", mnBuchungs_ID, mr1)
    '  Dim nPrv_Adress_ID_old As Integer = mr1!Prv_Adress_ID
    '  If mr1!Rayon & "" = "" Then
    '    mr1!Prv_Adress_ID = 0
    '  Else
    '    mr1!Prv_Adress_ID = Me.Rayon.Column(2)
    '  End If
    '  If (mr1!Prv_Adress_ID = Num(mr1!Adress_ID)) Or (mr1!Prv_Adress_ID = mr1!Rechnungsadresse) Then
    '    mr1!Prv_Adress_ID = 0
    '  End If
    '  UpdateProvisionen(nPrv_Adress_ID_old)
    '  On Error GoTo 0
    'End Sub

    'Private Sub UpdateSNs()
    '  On Error Resume Next
    '  Dim r1 As New Snapshot("select * from PendenzenZeilen where Buchungs_ID = " & mnBuchungs_ID & " and Buchungstyp = 11")
    '  While r1.HasData
    '    gdb.Execute(
    '      "update Serienummern set " &
    '      "Besteller_ID = " & mr1!Adress_ID & ", " &
    '      "Besteller_Text = '" & SetPat(Me.Suchbegriff.Text) & "', " &
    '      "Kunde_Name = '" & SetPat(mr1!LName & " " & mr1!LVorname) & "', " &
    '      "Kunde_Plz = '" & SetPat(mr1!LPlz) & "', " &
    '      "Kunde_Ort = '" & SetPat(mr1!LOrt) & "' " &
    '      "where PZeilen_ID = " & r1!Zeilen_ID)
    '    r1.MoveNext()
    '  End While
    '  Disp(r1)
    '  On Error GoTo 0
    'End Sub

    'Private Sub UpdateWährung(ByVal dKurs_old As Double, ByVal dKurs_new As Double)
    '  On Error Resume Next
    '  Dim r1 As New Recordset("select * from PendenzenZeilen where Buchungs_ID = " & mr1!Buchungs_ID & " and Buchungstyp = 11")
    '  While r1.HasData
    '    r1!Bruttobetrag = Rd((r1!Bruttobetrag * dKurs_old) / dKurs_new)
    '    r1!Einzelbetrag = Rd((r1!Einzelbetrag * dKurs_old) / dKurs_new)
    '    r1!Total = Rd(r1!Menge * r1!Einzelbetrag / GetMEf(r1![ME], r1!Faktor) * (1 - r1!Abzug / 100))
    '    r1!ZPrv_Betrag = GetProvision(r1, mr1!Währung)
    '    r1.Update()
    '    r1.MoveNext()
    '  End While
    '  Disp(r1)
    '  LoadTarif("Pendenzen", "Menge", mnBuchungs_ID, mr1)
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Name2_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Name2.AfterUpdate
    '  On Error Resume Next
    '  Dim sBriefanrede As String = GetBriefanrede("", mr1!Name2, mr1!Sprache)
    '  If sBriefanrede = "" Then
    '    sBriefanrede = Xtext("Sehr geehrte Damen und Herren")
    '  End If
    '  SwitchBriefanrede(mr1!Buchungs_ID, "Pendenzen", mr1!Briefanrede2 & "", sBriefanrede)
    '  mr1!Briefanrede2 = sBriefanrede
    '  If (Me.Suchbegriff.Text = mr1!LVorname & mr1!LName & "") AndAlso (Me.Name2.OldValue & "" = mr1!LAdresse1 & "") Then
    '    mr1!LAdresse1 = mr1!Name2
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Auftragsfaktor_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Auftragsfaktor.AfterUpdate
    '  On Error Resume Next
    '  Dim r1 As New Recordset("select * from PendenzenZeilen where Buchungs_ID = " & mr1!Buchungs_ID & " and Buchungstyp = 11")
    '  While r1.HasData
    '    r1!Einzelbetrag = Rd((r1!Einzelbetrag * mr1!Auftragsfaktor) / Me.Auftragsfaktor.OldValue)
    '    r1!Total = Rd(r1!Menge * r1!Einzelbetrag / GetMEf(r1![ME], r1!Faktor) * (1 - r1!Abzug / 100))
    '    r1!ZPrv_Betrag = GetProvision(r1, mr1!Währung)
    '    r1.Update()
    '    r1.MoveNext()
    '  End While
    '  Disp(r1)
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Buchungskurs_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Buchungskurs.AfterUpdate
    '  On Error Resume Next
    '  If mr1!Währung = gavGlb(27) Then
    '    e.Cancel = True
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdDrct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDrct.Click
    '  On Error Resume Next
    '  FormOpen("Directories", , cmtMode.DialogSizable, "X")
    '  If IsNull(gavTmp(12)) = False Then
    '    Me.Lieferadresse.Value = DBNull.Value
    '    mr1!LAnrede = gavTmp(10)
    '    mr1!LVorname = gavTmp(11)
    '    mr1!LName = gavTmp(12)
    '    mr1!LAdresse1 = gavTmp(13)
    '    mr1!LAdresse2 = gavTmp(14)
    '    mr1!LAdresse3 = gavTmp(15)
    '    mr1!LPlz = gavTmp(16)
    '    mr1!LOrt = gavTmp(17)
    '    mr1!LLand = gavTmp(23)
    '    UpdateSNs()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdBS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBS.Click
    '  On Error Resume Next
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    Dim vKopien As Object = InputBoxEx(Me, "Bestätigung", Xtext("Anzahl Exemplare:"), " ", gavGlb(70))
    '    vKopien = Int(Abs(Num(vKopien)))
    '    If vKopien > 0 Then
    '      Dim sPrinter1 As String = ""
    '      Dim iBin1 As Integer
    '      Dim bOK As Boolean
    '      MailDelay()
    '      bOK = ReportOpen("Bestätigung", , , "Buchungs_ID = " & mr1!Buchungs_ID, , vKopien, sPrinter1, iBin1, , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Bestätigungen"), mr1!Datum, Xtext("Bestätigung") & "_" & mr1!Pendenznummer))
    '      If bOK Then
    '        If mr1!Zustelladresse > 0 Then
    '          gavTmp(1) = Xtext("Bestätigung Nr.") & " " & mr1!Pendenznummer
    '          ReportOpen("Deckblatt2", , , "Buchungs_ID = " & mr1!Buchungs_ID, , , sPrinter1, iBin1)
    '        End If
    '        If mr1!Status = 4 Then
    '          mr1!Status = 5
    '          mr1.Update()
    '        End If
    '      End If
    '      MailRestart(bOK)
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdBSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBSV.Click
    '  On Error Resume Next
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    ReportOpen("Bestätigung", cmtReportMode.Preview, , "Buchungs_ID = " & mr1!Buchungs_ID, , , , , , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Bestätigungen"), mr1!Datum, Xtext("Bestätigung") & "_" & mr1!Pendenznummer))
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdGoogleMaps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoogleMaps.Click
    '  On Error Resume Next
    '  If mr1!LName & "" > "" Then
    '    GoogleMaps(False, mr1!LAdresse2, mr1!LAdresse3, mr1!LPlz, mr1!LOrt, mr1!LLand)
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdLS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLS.Click
    '  On Error Resume Next
    '  Dim sError As String = ""
    '  Dim sPrinter1 As String = ""
    '  Dim iBin1 As Integer
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    If mr1!Adress_Status > 0 Then
    '      MsgBox(Xtext("Diese Adresse ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '      mr1!Status = 7
    '      mr1.Update()
    '    ElseIf (mr1!Status <> 7) And (mr1!Status <> 3) Then
    '      If CheckLimite(IIf(mr1!Rechnungsadresse = 0, mr1!Adress_ID, mr1!Rechnungsadresse), mr1!BuchBetrag) Then
    '        If GetPrm("AufträgeLSSN", True) AndAlso CheckSN(mr1!Buchungs_ID) = False Then
    '          sError = Xtext("Fehlende Serienummer!")
    '        End If
    '        If sError = "" Then
    '          Dim vKopien As Object = InputBoxEx(Me, "Lieferschein", Xtext("Anzahl Exemplare:"), " ", gavGlb(71))
    '          vKopien = Int(Abs(Num(vKopien)))
    '          If vKopien > 0 Then
    '            Dim bOK As Boolean
    '            MailDelay()
    '            bOK = ReportOpen("Lieferschein", , , "Buchungs_ID = " & mr1!Buchungs_ID, , vKopien, sPrinter1, iBin1, , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Lieferscheine"), mr1!Datum, Xtext("Lieferschein") & "_" & GetNextNr(mr1!Pendenznummer)))
    '            If bOK Then
    '              If mr1!Zustelladresse > 0 Then
    '                gavTmp(1) = Xtext("Lieferschein Nr.") & " " & GetNextNr(mr1!Pendenznummer)
    '                ReportOpen("Deckblatt2", , , "Buchungs_ID = " & mr1!Buchungs_ID, , , sPrinter1, iBin1)
    '              End If
    '              If Lagerbuchung(mr1!Buchungs_ID) Then
    '                Me.Dispose()
    '              Else
    '                mr1.Requery()
    '              End If
    '            End If
    '            MailRestart(bOK)
    '          End If
    '        Else
    '          MsgBox(sError, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '        End If
    '      End If
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdLSV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLSV.Click
    '  On Error Resume Next
    '  Dim sError As String = ""
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    If mr1!Adress_Status > 0 Then
    '      MsgBox(Xtext("Diese Adresse ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '      mr1!Status = 7
    '      mr1.Update()
    '    Else
    '      If CheckLimite(IIf(mr1!Rechnungsadresse = 0, mr1!Adress_ID, mr1!Rechnungsadresse), mr1!BuchBetrag) Then
    '        If GetPrm("AufträgeLSSN", True) AndAlso CheckSN(mr1!Buchungs_ID) = False Then
    '          sError = Xtext("Fehlende Serienummer!")
    '        End If
    '        If sError = "" Then
    '          ReportOpen("Lieferschein", cmtReportMode.Preview, , "Buchungs_ID = " & mr1!Buchungs_ID, , , , , , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Lieferscheine"), mr1!Datum, Xtext("Lieferschein") & "_" & GetNextNr(mr1!Pendenznummer)))
    '        Else
    '          MsgBox(sError, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '        End If
    '      End If
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdNeueAdresse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNeueAdresse.Click
    '  On Error Resume Next
    '  FormOpen("Adressen", Xtext("Neue Adresse"), cmtMode.DialogSizable, SetArgs(0, 0))
    '  Me.Suchbegriff.Focus()
    '  If IsNull(gavTmp(1)) = False Then
    '    mr1!Adress_ID = gavTmp(1)
    '    SetFields()
    '    Me.Referenz.Focus()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click
    '  On Error Resume Next
    '  If CheckCancel("Pendenzen", "Buchungs_ID", 50) = False Then
    '    FormOpen("AufträgeDetail", , , SetArgs(0, 0, miLager))
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdRS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRS.Click
    '  On Error Resume Next
    '  Dim sPrinter1 As String = ""
    '  Dim iBin1 As Integer
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    If mr1!Adress_Status > 0 Then
    '      MsgBox(Xtext("Diese Adresse ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '      mr1!Status = 7
    '    Else
    '      Dim vKopien As Object = InputBoxEx(Me, "Rüstschein", Xtext("Anzahl Exemplare:"), " ", Num(GetPrm("Aufträge_RS_Kopien", 1)))
    '      vKopien = Int(Abs(Num(vKopien)))
    '      If vKopien > 0 Then
    '        Dim bOK As Boolean
    '        MailDelay()
    '        bOK = ReportOpen("Rüstschein", , , "Buchungs_ID = " & mr1!Buchungs_ID, , vKopien, sPrinter1, iBin1, , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Rüstscheine"), mr1!Datum, Xtext("Rüstschein") & "_" & GetNextNr(mr1!Pendenznummer)))
    '        If bOK Then
    '          If mr1!Zustelladresse > 0 Then
    '            gavTmp(1) = Xtext("Rüstschein Nr.") & " " & GetNextNr(mr1!Pendenznummer)
    '            ReportOpen("Deckblatt2", , , "Buchungs_ID = " & mr1!Buchungs_ID, , , sPrinter1, iBin1)
    '          End If
    '          mr1!Status = 8
    '          mr1.Update()
    '        End If
    '        MailRestart(bOK)
    '      End If
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdRSV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRSV.Click
    '  On Error Resume Next
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    If mr1!Adress_Status > 0 Then
    '      MsgBox(Xtext("Diese Adresse ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '      mr1!Status = 7
    '    Else
    '      ReportOpen("Rüstschein", cmtReportMode.Preview, , "Buchungs_ID = " & mr1!Buchungs_ID, , , , , , , mr1!Adress_ID, ReportPath(mr1!Adress_ID, Xtext("Rüstscheine"), mr1!Datum, Xtext("Rüstschein") & "_" & GetNextNr(mr1!Pendenznummer)))
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
    '  On Error Resume Next
    '  FormOpen("AdressenSuchen", , cmtMode.DialogSizable, , mvr)
    '  If gvResult IsNot Nothing Then
    '    Me.Lieferadresse.Value = DBNull.Value
    '    mr1!LAnrede = gavTmp(10)
    '    mr1!LVorname = gavTmp(11)
    '    mr1!LName = gavTmp(12)
    '    mr1!LAdresse1 = gavTmp(13)
    '    mr1!LAdresse2 = gavTmp(14)
    '    mr1!LAdresse3 = gavTmp(15)
    '    mr1!LPlz = gavTmp(16)
    '    mr1!LOrt = gavTmp(17)
    '    mr1!LLand = gavTmp(18)
    '    UpdateSNs()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Datum_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Datum.AfterUpdate
    '  On Error Resume Next
    '  mr1!Buchungskurs = GetKurs(mr1!Währung, mr1!Datum)
    '  On Error GoTo 0
    'End Sub

    'Private Sub Konditionen_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Konditionen.AfterUpdate
    '  On Error Resume Next
    '  If gdb.Lookup("Zahlart", "Konditionen", "Konditionencode = '" & mr1!Konditionen & "'") = 9 Then
    '    mr1!Status = 3
    '  End If
    '  LoadTarif("Pendenzen", "Menge", mr1!Buchungs_ID, mr1)
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Konditionen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Konditionen.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Konditionen", , cmtMode.Dialog)
    '  Me.Konditionen.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Lagerort_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lagerort.AfterUpdate
    '  On Error Resume Next
    '  Dim r1 As Recordset
    '  Dim rPns As Recordset
    '  If IsNull(mr1!Buchungs_ID) = False Then
    '    Dim bBestZ As Boolean = False
    '    rPns = New Recordset("select * from PendenzenZeilenStk where Stk_ID = 0")
    '    r1 = New Recordset("select * from PendenzenZeilen where Buchungs_ID = " & mr1!Buchungs_ID & " and Buchungstyp = 11")
    '    While r1.HasData
    '      If r1!BF Then
    '        If r1!Geliefert <> 0 Then
    '          LagerbuchungStk(r1!Buchungstyp, r1!Zeilen_ID, r1!JF, -r1!Geliefert, Xtext("Korrektur") & " " & mr1!Pendenznummer & " " & Me.Suchbegriff.Text, r1!LDatum, "Pendenzen")
    '        End If
    '        gdb.Execute("delete from PendenzenZeilenStk where Zeilen_ID = " & r1!Zeilen_ID)
    '        r1!SL = SetStk(0, rPns, r1!Zeilen_ID, mr1!Lagerort, r1!Artikel_ID, r1!Bezeichnung, r1!Variante, 1, 0, mr1!Währung, r1!Lagerwert, r1!Einzelbetrag, "Pendenzen")
    '        If r1!Geliefert <> 0 Then
    '          LagerbuchungStk(r1!Buchungstyp, r1!Zeilen_ID, r1!JF, r1!Geliefert, Xtext("Korrektur") & " " & mr1!Pendenznummer & " " & Me.Suchbegriff.Text, r1!LDatum, "Pendenzen")
    '        End If
    '        If IsNull(r1!BestZ) = False Then
    '          gdb.Execute("update PendenzenZeilen set BestZ = null where Zeilen_ID = " & r1!BestZ)
    '          r1!BestZ = Null
    '          bBestZ = True
    '        End If
    '        If r1!SNCnt > 0 Then
    '          If r1!SN = 1 Then
    '            gdb.Execute(
    '              "delete from Serienummern where PZeilen_ID = " & r1!Zeilen_ID)
    '          ElseIf r1!SN = 2 Then
    '            gdb.Execute(
    '              "update Serienummern set " &
    '              "Status = 0, " &
    '              "PZeilen_ID = Null, " &
    '              "BZeilen_ID = Null, " &
    '              "Ausgang = Null, " &
    '              "Besteller_ID = Null, " &
    '              "Besteller_Text = Null, " &
    '              "Kunde_Name = Null, " &
    '              "Kunde_Plz = Null, " &
    '              "Kunde_Ort = Null " &
    '              "where PZeilen_ID = " & r1!Zeilen_ID)
    '          End If
    '          r1!SNCnt = 0
    '        End If
    '        r1.Update()
    '      End If
    '      r1.MoveNext()
    '    End While
    '    Disp(r1)
    '    Disp(rPns)
    '    If bBestZ Then
    '      MsgBox(Xtext("Die Verbindung zur kommissionierten Einkaufsbestellung wird getrennt!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '    End If
    '    Pos_Requery()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Lagerort_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lagerort.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Lagerorte", , cmtMode.Dialog)
    '  Me.Lagerort.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Lieferadresse_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lieferadresse.AfterUpdate
    '  On Error Resume Next
    '  If Me.Lieferadresse.Value & "" > "" Then
    '    Dim r1 As New Snapshot("select * from Adressen where Adress_ID = " & Me.Lieferadresse.Value)
    '    If r1.HasData Then
    '      mr1!LAnrede = r1!Anrede
    '      mr1!LVorname = r1!Vorname
    '      mr1!LName = r1!Name
    '      mr1!LAdresse1 = r1!Adresse1
    '      mr1!LAdresse2 = r1!Adresse2
    '      mr1!LAdresse3 = r1!Adresse3
    '      mr1!LPlz = r1!Plz
    '      mr1!LOrt = r1!Ort
    '      mr1!LLand = r1!Land
    '      UpdateSNs()
    '    End If
    '    Disp(r1)
    '    Me.Lieferadresse.Value = DBNull.Value
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Lieferart_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lieferart.AfterUpdate
    '  On Error Resume Next
    '  LoadTarif("Pendenzen", "Menge", mr1!Buchungs_ID, mr1)
    '  Pos_Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Lieferart_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lieferart.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Lieferarten", , cmtMode.Dialog)
    '  Me.Lieferart.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub LName_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LName.AfterUpdate
    '  On Error Resume Next
    '  If Me.LName.Text.Trim.Length = 0 Then
    '    Dim r1 As New Snapshot("select * from Adressen where Adress_ID = " & Num(mr1!Adress_ID))
    '    If r1.HasData Then
    '      mr1!LAnrede = r1!Anrede
    '      mr1!LVorname = r1!Vorname
    '      mr1!LName = r1!Name
    '      mr1!LAdresse1 = mr1!Name2
    '      mr1!LAdresse2 = r1!Adresse2
    '      mr1!LAdresse3 = r1!Adresse3
    '      mr1!LPlz = r1!Plz
    '      mr1!LOrt = r1!Ort
    '      mr1!LLand = r1!Land
    '    End If
    '    Disp(r1)
    '    UpdateSNs()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub LOrt_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LOrt.AfterUpdate
    '  On Error Resume Next
    '  FindPlz(mr1!LPlz, mr1!LOrt, , mr1!LLand)
    '  On Error GoTo 0
    'End Sub

    'Private Sub LPlz_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LPlz.AfterUpdate
    '  On Error Resume Next
    '  FindOrt(mr1!LPlz, mr1!LOrt, , mr1!LLand)
    '  On Error GoTo 0
    'End Sub

    'Private Sub MWStType_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MWStType.AfterUpdate
    '  On Error Resume Next
    '  UpdateMWSt()
    '  On Error GoTo 0
    'End Sub

    'Private Sub ProjektKst_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProjektKst.AfterUpdate
    '  On Error Resume Next
    '  If Num(Me.ProjektKst.Column(2)) > 0 Then
    '    MsgBox(Xtext("Diese Kostenstelle ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '    e.Cancel = True
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub ProjektKst_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProjektKst.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Kostenstellen", , cmtMode.Dialog)
    '  Me.ProjektKst.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Prv_Adress_ID_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Prv_Adress_ID.AfterUpdate
    '  On Error Resume Next
    '  UpdateProvisionen(Num(Me.Prv_Adress_ID.OldValue))
    '  On Error GoTo 0
    'End Sub

    'Private Sub Prv_Adress_ID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Prv_Adress_ID.DoubleClick
    '  On Error Resume Next
    '  If mr1!Prv_Adress_ID > 0 Then
    '    FormOpen("Adressen", , , SetArgs(mr1!Prv_Adress_ID))
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Rayon_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Rayon.AfterUpdate
    '  On Error Resume Next
    '  UpdateRayon()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Rayon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rayon.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Rayon", , cmtMode.Dialog)
    '  Me.Rayon.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Rechnungsadresse_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Rechnungsadresse.AfterUpdate
    '  On Error Resume Next
    '  If Num(mr1!Rechnungsadresse) > 0 Then
    '    If gdb.Lookup("Adress_Status", "Adressen", "Adress_ID = " & mr1!Rechnungsadresse, 0) <> 0 Then
    '      MsgBox(Xtext("Diese Adresse ist inaktiv und kann deshalb nicht verwendet werden!"), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "")
    '      e.Cancel = True
    '    End If
    '  End If
    '  If e.Cancel = False Then
    '    If mnBuchungs_ID > 0 Then
    '      If mr1!Rechnungsadresse > 0 Then
    '        mr1!Rayon = gdb.Lookup("Rayon", "Adressen", "Adress_ID = " & mr1!Rechnungsadresse)
    '      Else
    '        mr1!Rayon = gdb.Lookup("Rayon", "Adressen", "Adress_ID = " & mr1!Adress_ID)
    '      End If
    '      UpdateRayon()
    '    End If
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Rechnungsadresse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rechnungsadresse.DoubleClick
    '  On Error Resume Next
    '  If mr1!Rechnungsadresse > 0 Then
    '    FormOpen("Adressen", , , SetArgs(mr1!Rechnungsadresse))
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
    '  On Error Resume Next
    '  If Me.SplitContainer1.CanFocus Then
    '    SetFrmVal(Me.Name, "Splitter1", Me.SplitContainer1.SplitterDistance)
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Status_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Status.AfterUpdate
    '  On Error Resume Next
    '  mr1.Update()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Suchbegriff_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Suchbegriff.AfterUpdate
    '  On Error Resume Next
    '  If mr1.OldValue("Adress_ID") & "" > "" Then
    '    If MsgBoxEx(Me, "AddressChanged", Xtext("Möchten Sie diesen Beleg der Adresse '<%>' zuteilen?", Me.Suchbegriff.Text), MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
    '      e.Cancel = True
    '    End If
    '  End If
    '  If e.Cancel = False Then
    '    SetFields()
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub Suchbegriff_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Suchbegriff.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Adressen", , , SetArgs(mr1!Adress_ID))
    '  On Error GoTo 0
    'End Sub

    'Private Sub Währung_AfterUpdate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Währung.AfterUpdate
    '  On Error Resume Next
    '  Dim dKurs1 As Double = mr1!Buchungskurs
    '  Dim dKurs2 As Double = GetKurs(mr1!Währung, mr1!Datum)
    '  mr1!Buchungskurs = dKurs2
    '  UpdateWährung(dKurs1, dKurs2)
    '  On Error GoTo 0
    'End Sub

    'Private Sub Währung_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Währung.DoubleClick
    '  On Error Resume Next
    '  FormOpen("Währungen", , cmtMode.Dialog)
    '  Me.Währung.Requery()
    '  On Error GoTo 0
    'End Sub

    'Private Sub Zustelladresse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Zustelladresse.DoubleClick
    '  On Error Resume Next
    '  If mr1!Zustelladresse > 0 Then
    '    Dim nZustelladresse As Int32 = gdb.Lookup("Parent_ID", "Adressen", "Adress_ID = " & mr1!Zustelladresse)
    '    If nZustelladresse = 0 Then
    '      nZustelladresse = mr1!Zustelladresse
    '    End If
    '    FormOpen("Adressen", , , SetArgs(nZustelladresse))
    '  End If
    '  On Error GoTo 0
    'End Sub

    'Private Sub LAdresse1_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LAdresse1.AfterUpdate

    'End Sub

    'Private Sub LLand_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LLand.AfterUpdate

    'End Sub

    'Private Sub LAdresse3_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LAdresse3.AfterUpdate

    'End Sub

    'Private Sub LAdresse2_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LAdresse2.AfterUpdate

    'End Sub

    'Private Sub LVorname_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LVorname.AfterUpdate

    'End Sub

    'Private Sub LAnrede_AfterUpdate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LAnrede.AfterUpdate

    'End Sub
End Class
