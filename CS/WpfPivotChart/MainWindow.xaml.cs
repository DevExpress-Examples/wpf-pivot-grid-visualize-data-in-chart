using System.Data;
using System.Windows;
using DevExpress.Xpf.Core;
using Microsoft.Data.Sqlite;

namespace WpfPivotChart {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }
        private void Window_Loaded(object sender,RoutedEventArgs e) {
            // Create a data source.
            DataTable dt;

            using (SqliteConnection connection = new SqliteConnection("Data Source=nwind.db")) {
                connection.Open();
                SqliteCommand cmd = (SqliteCommand)SqliteFactory.Instance.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Orders
                                    INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
                                    INNER JOIN OrderDetails ON OrderDetails.OrderID = Orders.OrderID";
                cmd.Connection = connection;
                using (SqliteDataReader dr = cmd.ExecuteReader()) {
                    do {
                        dt = new DataTable();
                        dt.BeginLoadData();
                        dt.Load(dr);
                        dt.EndLoadData();

                    } while (!dr.IsClosed && dr.NextResult());
                }
            }

            // Assign the data source to the PivotGrid control.
            pivotGridControl1.DataSource = dt;
            pivotGridControl1.BestFit();
        }
    }
}
