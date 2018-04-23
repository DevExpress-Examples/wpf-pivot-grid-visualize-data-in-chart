Imports Microsoft.VisualBasic
Imports System.Windows

Namespace DXPivotGrid_ChartsIntegration
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			' Binds the pivot grid to data.
			pivotGridControl1.DataSource = (New DataSet1TableAdapters.InvoicesTableAdapter()).GetData()
		End Sub
	End Class
End Namespace
