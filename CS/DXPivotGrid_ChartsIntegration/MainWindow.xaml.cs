using System.Windows;

namespace DXPivotGrid_ChartsIntegration
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Binds the pivot grid to data.
            pivotGridControl1.DataSource =
                (new DataSet1TableAdapters.InvoicesTableAdapter()).GetData();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pivotGridControl1.BestFit();
        }
    }
}


