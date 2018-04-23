Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Namespace FormatProgressBarText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CreateNodes(treeList1)
			repositoryItemProgressBar1.ShowTitle = True
			repositoryItemProgressBar1.Appearance.Options.UseFont = True
			repositoryItemProgressBar1.Appearance.Font = New Font(repositoryItemProgressBar1.Appearance.Font, FontStyle.Bold)
			repositoryItemProgressBar1.Appearance.Options.UseTextOptions = True
			repositoryItemProgressBar1.Appearance.TextOptions.HAlignment = HorzAlignment.Near
		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			If e.Column.ColumnEdit IsNot Nothing AndAlso e.Column.ColumnEdit.GetType() Is GetType(RepositoryItemProgressBar) Then
				Dim val As String = e.Node(e.Column).ToString()
				e.CellText = "The progress is: " & val & "%"
				e.Appearance.Options.UseFont = True
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				e.Appearance.Options.UseTextOptions = True
				e.Appearance.TextOptions.HAlignment = HorzAlignment.Near
				CType(e.EditViewInfo, DevExpress.XtraEditors.ViewInfo.ProgressBarViewInfo).CalcViewInfo(e.Graphics)
			End If

		End Sub

		Private Sub CreateNodes(ByVal tl As DevExpress.XtraTreeList.TreeList)
			tl.BeginUnboundLoad()
			For i As Integer = 0 To 9
				tl.AppendNode(New Object() { "Item" & i, i * 10 }, -1, 0, 0, -1)
				tl.EndUnboundLoad()
			Next i
		End Sub

		Private Sub repositoryItemProgressBar1_CustomDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles repositoryItemProgressBar1.CustomDisplayText
			Dim val As String = e.Value.ToString()
			e.DisplayText = "The progress is: " & val
		End Sub
	End Class
End Namespace