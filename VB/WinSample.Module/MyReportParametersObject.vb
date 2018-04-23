Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.Xpo.DB
Imports DevExpress.ExpressApp

Namespace WinSample.Module
    <NonPersistent()> _
    Public Class MyReportParametersObject
        Inherits ReportParametersObjectBase
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal reportDataType As Type)
            MyBase.New(objectSpace, reportDataType)
        End Sub
        Public Overrides Function GetCriteria() As DevExpress.Data.Filtering.CriteriaOperator
            Return Nothing
        End Function
        Public Overrides Function GetSorting() As SortProperty()
            Return New SortProperty() {New SortProperty("MasterName", SortingDirection.Ascending)}
        End Function
        Private _StartDate As DateTime
        <Index(0)> _
        Public Property StartDate() As DateTime
            Get
                Return _StartDate
            End Get
            Set(ByVal value As DateTime)
                _StartDate = value
            End Set
        End Property
        Private _EndDate As DateTime
        <Index(1)> _
        Public Property EndDate() As DateTime
            Get
                Return _EndDate
            End Get
            Set(ByVal value As DateTime)
                _EndDate = value
            End Set
        End Property
    End Class

End Namespace
