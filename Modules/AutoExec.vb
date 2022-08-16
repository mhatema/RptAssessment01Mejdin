Public Class AutoExec
  Public Sub Load(ByVal sUpdatedVersion As String)
    On Error Resume Next
        'MenuAdd("", "Menu_ComaticTimer", Xtext("Leistungserfassung"))
        'MenuAdd("Menu_Einstellungen", "Form_Einstellungsdialog", Xtext("Einstellungen"), , , cmtMode.Dialog, cmtMenuPicture.Form_Settings)
        MenuAdd("", "Menu_Mejdin", Xtext("Mejdin"))
        MenuAdd("Menu_Mejdin", "Form_Einstellungsdialog", Xtext("Einstellungen"), , , cmtMode.Normal, cmtMenuPicture.Form_Settings)

        'PlugInAdd("Form_Personalstamm", "Form_cleTagesübersicht")

        'Reports für E-Printing registrieren
        'ReportAdd("Report_cleRechnung", Xtext("Rechnung"), True, True)

        'Der Website werden die Parameter adrid, lng, app, frm und topic mitgegeben
        'gapp.HelpURL = "http://www.comatic.ch/help.php"

        If sUpdatedVersion.Length > 0 Then
      'Updates auf Datenbank hier durchführen
    End If

    If gbRuntime Then
      'Start-Sachen durchführen...
    End If
    On Error GoTo 0
  End Sub
End Class
