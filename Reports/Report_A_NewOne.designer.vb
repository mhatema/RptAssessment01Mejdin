<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Report_A_NewOne
  Inherits GrapeCity.ActiveReports.SectionReport

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
    End If
    MyBase.Dispose(disposing)
  End Sub

  'NOTE: The following procedure is required by the ActiveReports Designer
  'It can be modified using the ActiveReports Designer.
  'Do not modify it using the code editor.
  Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
  Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
  Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_A_NewOne))
    Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Me.RichTextBox1 = New GrapeCity.ActiveReports.SectionReportModel.RichTextBox
    Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
    Me.RichTextBox2 = New GrapeCity.ActiveReports.SectionReportModel.RichTextBox
    Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
    Me.RichTextBox3 = New GrapeCity.ActiveReports.SectionReportModel.RichTextBox
    Me.WhereCondition = New GrapeCity.ActiveReports.SectionReportModel.Parameter
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'PageHeader1
    '
    Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.RichTextBox1})
    Me.PageHeader1.Height = 0.1968504!
    Me.PageHeader1.Name = "PageHeader1"
    '
    'RichTextBox1
    '
    Me.RichTextBox1.AutoReplaceFields = True
    Me.RichTextBox1.BackColor = System.Drawing.Color.Transparent
    Me.RichTextBox1.Border.BottomColor = System.Drawing.Color.Black
    Me.RichTextBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox1.Border.LeftColor = System.Drawing.Color.Black
    Me.RichTextBox1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox1.Border.RightColor = System.Drawing.Color.Black
    Me.RichTextBox1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox1.Border.TopColor = System.Drawing.Color.Black
    Me.RichTextBox1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox1.DataField = "Text1"
    Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
    Me.RichTextBox1.Height = 0.1968504!
    Me.RichTextBox1.Left = 0.0!
    Me.RichTextBox1.Name = "RichTextBox1"
    Me.RichTextBox1.RTF = resources.GetString("RichTextBox1.RTF")
    Me.RichTextBox1.Top = 0.0!
    Me.RichTextBox1.Width = 7.086614!
    '
    'Detail1
    '
    Me.Detail1.ColumnSpacing = 0.0!
    Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.RichTextBox2})
    Me.Detail1.Height = 0.1968504!
    Me.Detail1.Name = "Detail1"
    '
    'RichTextBox2
    '
    Me.RichTextBox2.AutoReplaceFields = True
    Me.RichTextBox2.BackColor = System.Drawing.Color.Transparent
    Me.RichTextBox2.Border.BottomColor = System.Drawing.Color.Black
    Me.RichTextBox2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox2.Border.LeftColor = System.Drawing.Color.Black
    Me.RichTextBox2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox2.Border.RightColor = System.Drawing.Color.Black
    Me.RichTextBox2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox2.Border.TopColor = System.Drawing.Color.Black
    Me.RichTextBox2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox2.DataField = "Text2"
    Me.RichTextBox2.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.RichTextBox2.ForeColor = System.Drawing.Color.Black
    Me.RichTextBox2.Height = 0.1968504!
    Me.RichTextBox2.Left = 0.0!
    Me.RichTextBox2.Name = "RichTextBox2"
    Me.RichTextBox2.RTF = resources.GetString("RichTextBox2.RTF")
    Me.RichTextBox2.Top = 0.0!
    Me.RichTextBox2.Width = 7.086614!
    '
    'PageFooter1
    '
    Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.RichTextBox3})
    Me.PageFooter1.Height = 0.1968504!
    Me.PageFooter1.Name = "PageFooter1"
    '
    'RichTextBox3
    '
    Me.RichTextBox3.AutoReplaceFields = True
    Me.RichTextBox3.BackColor = System.Drawing.Color.Transparent
    Me.RichTextBox3.Border.BottomColor = System.Drawing.Color.Black
    Me.RichTextBox3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox3.Border.LeftColor = System.Drawing.Color.Black
    Me.RichTextBox3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox3.Border.RightColor = System.Drawing.Color.Black
    Me.RichTextBox3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox3.Border.TopColor = System.Drawing.Color.Black
    Me.RichTextBox3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
    Me.RichTextBox3.DataField = "Text3"
    Me.RichTextBox3.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.RichTextBox3.ForeColor = System.Drawing.Color.Black
    Me.RichTextBox3.Height = 0.1968504!
    Me.RichTextBox3.Left = 0.0!
    Me.RichTextBox3.Name = "RichTextBox3"
    Me.RichTextBox3.RTF = resources.GetString("RichTextBox3.RTF")
    Me.RichTextBox3.Top = 0.0!
    Me.RichTextBox3.Width = 7.086614!
    '
    'WhereCondition
    '
    Me.WhereCondition.DefaultValue = Nothing
    Me.WhereCondition.Key = "WhereCondition"
    Me.WhereCondition.Prompt = Nothing
    Me.WhereCondition.PromptUser = False
    Me.WhereCondition.QueryCreated = False
    Me.WhereCondition.Tag = Nothing
    Me.WhereCondition.Type = GrapeCity.ActiveReports.SectionReportModel.Parameter.DataType.[String]
    '
    'Report_Dokument01
    '
    Me.MasterReport = False
    Me.PageSettings.DefaultPaperSize = False
    Me.PageSettings.Margins.Bottom = 0.5511811!
    Me.PageSettings.Margins.Left = 0.7874016!
    Me.PageSettings.Margins.Right = 0.1181102!
    Me.PageSettings.Margins.Top = 0.3937008!
    Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
    Me.PageSettings.PaperHeight = 11.69291!
    Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
    Me.PageSettings.PaperWidth = 8.267716!
    Me.Parameters.Add(Me.WhereCondition)
    Me.PrintWidth = 7.086615!
    Me.ScriptLanguage = "VB.NET"
    Me.Sections.Add(Me.PageHeader1)
    Me.Sections.Add(Me.Detail1)
    Me.Sections.Add(Me.PageFooter1)
    Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                "l; font-size: 10pt; color: Black; ddo-char-set: 0; ", "Normal"))
    Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 0; ", "Heading1", "Normal"))
    Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                "lic; ddo-char-set: 0; ", "Heading2", "Normal"))
    Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 0; ", "Heading3", "Normal"))
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Public WithEvents WhereCondition As GrapeCity.ActiveReports.SectionReportModel.Parameter
  Friend WithEvents RichTextBox1 As GrapeCity.ActiveReports.SectionReportModel.RichTextBox
  Friend WithEvents RichTextBox2 As GrapeCity.ActiveReports.SectionReportModel.RichTextBox
  Friend WithEvents RichTextBox3 As GrapeCity.ActiveReports.SectionReportModel.RichTextBox
End Class
