<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Einstellungsdialog
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Einstellungsdialog))
        Me.cmdStandardImportPfad = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtStandardImportPfad = New Comatic.Tx()
        Me.cmdArchivPfad = New System.Windows.Forms.Button()
        Me.txtArchivPfad = New Comatic.Tx()
        Me.txcGKKartenzahlung = New Comatic.Txc()
        Me.txcGKBarzahlung = New Comatic.Txc()
        Me.txcGKGutscheine = New Comatic.Txc()
        Me.txcGKKundenflucht = New Comatic.Txc()
        Me.SuspendLayout()
        '
        'cmdStandardImportPfad
        '
        Me.cmdStandardImportPfad.ImageIndex = 5
        Me.cmdStandardImportPfad.ImageList = Me.ImageList1
        Me.cmdStandardImportPfad.Location = New System.Drawing.Point(380, 12)
        Me.cmdStandardImportPfad.Name = "cmdStandardImportPfad"
        Me.cmdStandardImportPfad.Size = New System.Drawing.Size(30, 23)
        Me.cmdStandardImportPfad.TabIndex = 27
        Me.cmdStandardImportPfad.TabStop = False
        Me.cmdStandardImportPfad.UseVisualStyleBackColor = True
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
        'txtStandardImportPfad
        '
        Me.txtStandardImportPfad.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txtStandardImportPfad.LabelText = "Importpfad:"
        Me.txtStandardImportPfad.Location = New System.Drawing.Point(9, 13)
        Me.txtStandardImportPfad.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txtStandardImportPfad.Name = "txtStandardImportPfad"
        Me.txtStandardImportPfad.Protected = True
        Me.txtStandardImportPfad.Size = New System.Drawing.Size(370, 21)
        Me.txtStandardImportPfad.TabIndex = 26
        Me.txtStandardImportPfad.TabStop = False
        Me.txtStandardImportPfad.Value = Nothing
        '
        'cmdArchivPfad
        '
        Me.cmdArchivPfad.ImageIndex = 5
        Me.cmdArchivPfad.ImageList = Me.ImageList1
        Me.cmdArchivPfad.Location = New System.Drawing.Point(380, 38)
        Me.cmdArchivPfad.Name = "cmdArchivPfad"
        Me.cmdArchivPfad.Size = New System.Drawing.Size(30, 23)
        Me.cmdArchivPfad.TabIndex = 29
        Me.cmdArchivPfad.TabStop = False
        Me.cmdArchivPfad.UseVisualStyleBackColor = True
        '
        'txtArchivPfad
        '
        Me.txtArchivPfad.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txtArchivPfad.LabelText = "Archivpfad:"
        Me.txtArchivPfad.Location = New System.Drawing.Point(9, 39)
        Me.txtArchivPfad.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txtArchivPfad.Name = "txtArchivPfad"
        Me.txtArchivPfad.Protected = True
        Me.txtArchivPfad.Size = New System.Drawing.Size(370, 21)
        Me.txtArchivPfad.TabIndex = 28
        Me.txtArchivPfad.TabStop = False
        Me.txtArchivPfad.Value = Nothing
        '
        'txcGKKartenzahlung
        '
        Me.txcGKKartenzahlung.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txcGKKartenzahlung.DataField = "Konto"
        Me.txcGKKartenzahlung.DataSource = Nothing
        Me.txcGKKartenzahlung.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
        Me.txcGKKartenzahlung.LabelText = "GK Kartenzahlung:"
        Me.txcGKKartenzahlung.Location = New System.Drawing.Point(9, 62)
        Me.txcGKKartenzahlung.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txcGKKartenzahlung.MaxLength = 10
        Me.txcGKKartenzahlung.Name = "txcGKKartenzahlung"
        Me.txcGKKartenzahlung.RowSource = "Select Konto, Konto + ' ' + Kontobezeichnung from Konten"
        Me.txcGKKartenzahlung.SelectedIndex = -1
        Me.txcGKKartenzahlung.Size = New System.Drawing.Size(370, 21)
        Me.txcGKKartenzahlung.TabIndex = 51
        Me.txcGKKartenzahlung.TabStop = False
        Me.txcGKKartenzahlung.Value = Nothing
        '
        'txcGKBarzahlung
        '
        Me.txcGKBarzahlung.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txcGKBarzahlung.DataField = "Konto"
        Me.txcGKBarzahlung.DataSource = Nothing
        Me.txcGKBarzahlung.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
        Me.txcGKBarzahlung.LabelText = "GK Barzahlung:"
        Me.txcGKBarzahlung.Location = New System.Drawing.Point(9, 85)
        Me.txcGKBarzahlung.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txcGKBarzahlung.MaxLength = 10
        Me.txcGKBarzahlung.Name = "txcGKBarzahlung"
        Me.txcGKBarzahlung.RowSource = "Select Konto, Konto + ' ' + Kontobezeichnung from Konten"
        Me.txcGKBarzahlung.SelectedIndex = -1
        Me.txcGKBarzahlung.Size = New System.Drawing.Size(370, 21)
        Me.txcGKBarzahlung.TabIndex = 52
        Me.txcGKBarzahlung.TabStop = False
        Me.txcGKBarzahlung.Value = Nothing
        '
        'txcGKGutscheine
        '
        Me.txcGKGutscheine.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txcGKGutscheine.DataField = "Konto"
        Me.txcGKGutscheine.DataSource = Nothing
        Me.txcGKGutscheine.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
        Me.txcGKGutscheine.LabelText = "GK Gutscheine:"
        Me.txcGKGutscheine.Location = New System.Drawing.Point(9, 131)
        Me.txcGKGutscheine.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txcGKGutscheine.MaxLength = 10
        Me.txcGKGutscheine.Name = "txcGKGutscheine"
        Me.txcGKGutscheine.RowSource = "Select Konto, Konto + ' ' + Kontobezeichnung from Konten"
        Me.txcGKGutscheine.SelectedIndex = -1
        Me.txcGKGutscheine.Size = New System.Drawing.Size(370, 21)
        Me.txcGKGutscheine.TabIndex = 54
        Me.txcGKGutscheine.TabStop = False
        Me.txcGKGutscheine.Value = Nothing
        '
        'txcGKKundenflucht
        '
        Me.txcGKKundenflucht.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.txcGKKundenflucht.DataField = "Konto"
        Me.txcGKKundenflucht.DataSource = Nothing
        Me.txcGKKundenflucht.EmptyMode = Comatic.Code.cmtEmptyMode.NotNullable
        Me.txcGKKundenflucht.LabelText = "GK Kundenflucht:"
        Me.txcGKKundenflucht.Location = New System.Drawing.Point(9, 108)
        Me.txcGKKundenflucht.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.txcGKKundenflucht.MaxLength = 10
        Me.txcGKKundenflucht.Name = "txcGKKundenflucht"
        Me.txcGKKundenflucht.RowSource = "Select Konto, Konto + ' ' + Kontobezeichnung from Konten"
        Me.txcGKKundenflucht.SelectedIndex = -1
        Me.txcGKKundenflucht.Size = New System.Drawing.Size(370, 21)
        Me.txcGKKundenflucht.TabIndex = 53
        Me.txcGKKundenflucht.TabStop = False
        Me.txcGKKundenflucht.Value = Nothing
        '
        'Form_Einstellungsdialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txcGKGutscheine)
        Me.Controls.Add(Me.txcGKKundenflucht)
        Me.Controls.Add(Me.txcGKBarzahlung)
        Me.Controls.Add(Me.txcGKKartenzahlung)
        Me.Controls.Add(Me.cmdArchivPfad)
        Me.Controls.Add(Me.txtArchivPfad)
        Me.Controls.Add(Me.cmdStandardImportPfad)
        Me.Controls.Add(Me.txtStandardImportPfad)
        Me.Name = "Form_Einstellungsdialog"
        Me.Size = New System.Drawing.Size(1008, 600)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdStandardImportPfad As Button
    Friend WithEvents txtStandardImportPfad As Tx
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cmdArchivPfad As Button
    Friend WithEvents txtArchivPfad As Tx
    Friend WithEvents txcGKKartenzahlung As Txc
    Friend WithEvents txcGKBarzahlung As Txc
    Friend WithEvents txcGKGutscheine As Txc
    Friend WithEvents txcGKKundenflucht As Txc
End Class
