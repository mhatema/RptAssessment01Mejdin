Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document

Public Class Report_A_NewOne

  Public Sub New()
    On Error Resume Next
    InitializeComponent()
    Me.Document.Name = Xtext("New Report")
    On Error GoTo 0
  End Sub

  Default Property Item(ByVal Index As String) As Object
    Get
      On Error Resume Next
      Return Me.Fields(Index).Value
      On Error GoTo 0
    End Get
    Set(ByVal value As Object)
      On Error Resume Next
      Me.Fields(Index).Value = value
      On Error GoTo 0
    End Set
  End Property

  Private Sub Report_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
    On Error Resume Next
    Me.DataSource = New Snapshot("select * from WhatEver where " & Me.WhereCondition.Value)
    On Error GoTo 0
  End Sub

  Private Sub Report_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.NoData
    On Error Resume Next
    Me.Cancel()
    On Error GoTo 0
  End Sub
End Class
