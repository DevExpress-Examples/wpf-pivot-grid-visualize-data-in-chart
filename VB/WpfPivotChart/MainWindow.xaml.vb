Imports System.Data
Imports System.Text
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PivotGrid
Imports Microsoft.Data.Sqlite

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Partial Public Class MainWindow
    Inherits ThemedWindow
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Create a data source.
        Dim dt As DataTable
        Using connection As New SqliteConnection("Data Source=nwind.db;")
            connection.Open()
            Dim cmd As SqliteCommand = CType(SqliteFactory.Instance.CreateCommand(), SqliteCommand)
            cmd.CommandText = "SELECT * FROM Orders
                                    INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
                                    INNER JOIN OrderDetails ON OrderDetails.OrderID = Orders.OrderID"
            cmd.Connection = connection
            Using dr As SqliteDataReader = cmd.ExecuteReader()
                Do
                    dt = New DataTable()
                    dt.BeginLoadData()
                    dt.Load(dr)
                    dt.EndLoadData()
                Loop While Not dr.IsClosed AndAlso dr.NextResult()
            End Using
        End Using

        ' Assign the data source to the PivotGrid control.
        pivotGridControl1.DataSource = dt
    End Sub
End Class