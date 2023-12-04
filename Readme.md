<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579024/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2913)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Pivot Grid for WPF - How to Visualize Pivot Grid Data with the Chart Control

This example demonstrates how to bind a Chart Control to a Pivot Grid Control. For this, assign the [PivotGridControl.ChartDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartDataSource) property value to the [ChartControl.DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.DataSource) property.

The _Transpose Data Source_ check box is bound to the [PivotGridControl.ChartProvideDataByColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideDataByColumns) property. If the check box is checked, the property is set to false, and chart series are based on pivot grid rows instead of columns.

![screenshot](/images/screenshot.png)
## Files to Review

* [MainWindow.xaml](./CS/DXPivotGrid_ChartsIntegration/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_ChartsIntegration/MainWindow.xaml))
