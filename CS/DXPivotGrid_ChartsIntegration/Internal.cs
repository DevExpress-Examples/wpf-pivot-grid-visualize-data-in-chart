using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DXPivotGrid_ChartsIntegration {
    public partial class MainWindow : Window {
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            pivotGridControl1.BestFit();
        }
    }
    public class InverseBooleanConverter : MarkupExtension, IValueConverter {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, 
                object parameter, CultureInfo culture) {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, 
                object parameter, CultureInfo culture) {
            return !(bool)value;
        }
        #endregion
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
