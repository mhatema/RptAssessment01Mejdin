<System.ComponentModel.ToolboxItem(False)> _
Public Class Form_Einstellungsdialog
    Public mvr As cmtRole = cmtRole.Undefined
    Public WithEvents mr1 As New Rowset
    Private StandardImportPath As String
    Private ArchivPath As String

    Public Sub New()
        On Error Resume Next
        InitializeComponent()
        Me.Tag = Xtext("Einstellungsdialog")


        'If mvr <= cmtRole.Normal Then
        '    Me.Enabled = False
        '    Exit Sub
        'End If

        StandardImportPath = GetPrm("prmStandardImportPath") ' 
        ArchivPath = GetPrm("prmStandardArchivPath")

        If StandardImportPath = "" Then
            StandardImportPath = My.Application.Info.DirectoryPath & "\Import"
            My.Computer.FileSystem.CreateDirectory(StandardImportPath)
            SetPrm("prmStandardImportPath", StandardImportPath)
        End If
        If ArchivPath = "" Then
            ArchivPath = My.Application.Info.DirectoryPath & "\Archiv"
            My.Computer.FileSystem.CreateDirectory(ArchivPath)
            SetPrm("prmStandardArchivPath", ArchivPath)
        End If

        On Error GoTo 0
    End Sub

    Private Sub Form_DockChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DockChanged
        On Error Resume Next
        '
        'Hier ist das Form noch nicht sichtbar, aber alle Controls sind in endgültiger Grösse platziert.
        'Der Event eignet sich gut, um z.B. die SplitContainer auf eine vom Kunden definierte Grösse zu bringen.
        '
        'Me.SplitContainer1.SplitterDistance = GetFrmValue(Me.Name, "Splitter1", Me.SplitContainer1.SplitterDistance)
        '
        ' und weiter unten heisst es dann z.B.:
        '
        'Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        '  On Error Resume Next
        '  If Me.SplitContainer1.Focused Then
        '    SetFrmValue(Me.Name, "Splitter1", Me.SplitContainer1.SplitterDistance)
        '  End If
        ' On Error GoTo 0
        'End Sub
        '
        On Error GoTo 0
    End Sub

    Public WriteOnly Property OpenArgs() As Object
        Set(ByVal value As Object)
            On Error Resume Next
            txtStandardImportPfad.Value = StandardImportPath
            txtArchivPfad.Value = ArchivPath
            txcGKKartenzahlung.Value = GetPrm("prmGegenKontoKartenzahlung")
            txcGKBarzahlung.Value = GetPrm("prmGegenKontoBarzahlung")
            txcGKKundenflucht.Value = GetPrm("prmGegenKontoKundenflucht")
            txcGKGutscheine.Value = GetPrm("prmGegenKontoGutscheine")


            On Error GoTo 0
        End Set
    End Property

    Private Sub Form_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        On Error Resume Next
        Disp(mr1)
        On Error GoTo 0
    End Sub

    Private Sub cmdStandardImportPfad_Click(sender As Object, e As EventArgs) Handles cmdStandardImportPfad.Click
        Dim bfd As New FolderBrowserDialog
        bfd.SelectedPath = StandardImportPath
        Dim newPath As String = bfd.ShowDialog()
        If bfd.SelectedPath <> "" Then
            StandardImportPath = bfd.SelectedPath
            txtStandardImportPfad.Value = StandardImportPath
            SetPrm("prmStandardImportPath", StandardImportPath)
        End If
    End Sub

    Private Sub cmdArchivPfad_Click(sender As Object, e As EventArgs) Handles cmdArchivPfad.Click
        Dim bfd As New FolderBrowserDialog
        bfd.SelectedPath = ArchivPath
        Dim newPath As String = bfd.ShowDialog()
        If bfd.SelectedPath <> "" Then
            ArchivPath = bfd.SelectedPath
            txtArchivPfad.Value = ArchivPath
            SetPrm("prmStandardArchivPath", ArchivPath)
        End If
    End Sub


    Private Sub txcGKKartenzahlung_AfterUpdate(sender As Object, e As CancelEventArgs) Handles txcGKKartenzahlung.AfterUpdate
        SetPrm("prmGegenKontoKartenzahlung", txcGKKartenzahlung.Value)
    End Sub

    Private Sub txcGKBarzahlung_AfterUpdate(sender As Object, e As CancelEventArgs) Handles txcGKBarzahlung.AfterUpdate
        SetPrm("prmGegenKontoBarzahlung", txcGKBarzahlung.Value)
    End Sub

    Private Sub txcGKKundenflucht_AfterUpdate(sender As Object, e As CancelEventArgs) Handles txcGKKundenflucht.AfterUpdate
        SetPrm("prmGegenKontoKundenflucht", txcGKKundenflucht.Value)
    End Sub

    Private Sub txcGKGutscheine_AfterUpdate(sender As Object, e As CancelEventArgs) Handles txcGKGutscheine.AfterUpdate
        SetPrm("prmGegenKontoGutscheine", txcGKGutscheine.Value)
    End Sub
End Class
