Imports Microsoft.VisualBasic
Imports System
Namespace FormatProgressBarText
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.columnName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.columnProgress = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.columnName, Me.columnProgress})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1})
			Me.treeList1.Size = New System.Drawing.Size(553, 346)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell);
			' 
			' columnName
			' 
			Me.columnName.Caption = "Name"
			Me.columnName.FieldName = "Name"
			Me.columnName.Name = "columnName"
			Me.columnName.Visible = True
			Me.columnName.VisibleIndex = 0
			' 
			' columnProgress
			' 
			Me.columnProgress.Caption = "Progress"
			Me.columnProgress.ColumnEdit = Me.repositoryItemProgressBar1
			Me.columnProgress.FieldName = "Progress"
			Me.columnProgress.Name = "columnProgress"
			Me.columnProgress.Visible = True
			Me.columnProgress.VisibleIndex = 1
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
'			Me.repositoryItemProgressBar1.CustomDisplayText += New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(Me.repositoryItemProgressBar1_CustomDisplayText);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(553, 346)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private columnName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private columnProgress As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private WithEvents repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

	End Class
End Namespace

