<!-- default file list -->
*Files to look at*:
* [MainWindow.xaml](./CS/DXPivotGrid_ChartsIntegration/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_ChartsIntegration/MainWindow.xaml))
<!-- default file list end -->

# How to Visualize PivotGrid Data with the ChartControl


This example demonstrates how to bind a ChartControl to a PivotGridControl. For this, assign the [PivotGridControl.ChartDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartDataSource) property value to the [ChartControl.DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.DataSource) property.

The _Transpose Data Source_ check box is bound to the [PivotGridControl.ChartProvideDataByColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideDataByColumns) property. If the check box is checked, the property is set to false, and chart series are based on pivot grid rows instead of columns.

![screenshot](/images/screenshot.png)
