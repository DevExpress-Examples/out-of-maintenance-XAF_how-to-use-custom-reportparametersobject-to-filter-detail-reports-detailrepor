Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp

Namespace WinSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			CreateReport("MasterDetailsReport")
		End Sub
		Private Sub CreateReport(ByVal reportName As String)
			Dim reportdata As ReportData = Session.FindObject(Of ReportData)(New BinaryOperator("Name", reportName))
			If reportdata Is Nothing Then
				reportdata = New ReportData(Session)
				Dim rep As New XafReport()
				rep.ReportName = reportName
				rep.ObjectSpace = New ObjectSpace(New UnitOfWork(Session.DataLayer), XafTypesInfo.Instance)
				rep.LoadLayout(Me.GetType().Assembly.GetManifestResourceStream("WinSample.Module.EmbeddedReports." & reportName & ".repx"))
				reportdata.SaveXtraReport(rep)
				reportdata.Save()
			End If
		End Sub
	End Class
End Namespace
