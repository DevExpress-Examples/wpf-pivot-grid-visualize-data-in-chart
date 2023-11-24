Imports System.Windows

Namespace DXPivotGrid_ChartsIntegration

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ' Binds the pivot grid to data.
            Me.pivotGridControl1.DataSource =(New DataSet1TableAdapters.InvoicesTableAdapter()).GetData()
        End Sub
    End Class
End Namespace
