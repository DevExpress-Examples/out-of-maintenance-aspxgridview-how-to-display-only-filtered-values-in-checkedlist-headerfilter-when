Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub gvProducts_HeaderFilterFillItems(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewHeaderFilterEventArgs)
		Dim gridView As ASPxGridView = TryCast(sender, ASPxGridView)
		Dim result As New List(Of FilterValue)()

		Dim columnValues As New HashSet(Of Object)()
		For i As Integer = 0 To gridView.VisibleRowCount - 1
			columnValues.Add(gridView.GetRowValues(i, e.Column.FieldName).ToString())
		Next i

		e.Values.RemoveAll(Function(filterValue) (Not columnValues.Contains(filterValue.Value)))
	End Sub
End Class