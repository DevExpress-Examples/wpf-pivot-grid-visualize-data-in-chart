<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579024/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2913)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [MainWindow.xaml](./CS/DXPivotGrid_ChartsIntegration/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_ChartsIntegration/MainWindow.xaml))
<!-- default file list end -->

# How to Visualize PivotGrid Data with the ChartControl


This example demonstrates how to bind a ChartControl to a PivotGridControl. For this, assign the [PivotGridControl.ChartDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartDataSource) property value to the [ChartControl.DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.DataSource) property.

The _Transpose Data Source_ check box is bound to the [PivotGridControl.ChartProvideDataByColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideDataByColumns) property. If the check box is checked, the property is set to false, and chart series are based on pivot grid rows instead of columns.

![screenshot](/images/screenshot.png)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-visualize-data-in-chart&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-visualize-data-in-chart&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
