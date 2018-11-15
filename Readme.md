<!-- default file list -->
*Files to look at*:

* [Internal.cs](./CS/DXPivotGrid_ChartsIntegration/Internal.cs) (VB: [Internal.vb](./VB/DXPivotGrid_ChartsIntegration/Internal.vb))
* [MainWindow.xaml](./CS/DXPivotGrid_ChartsIntegration/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_ChartsIntegration/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_ChartsIntegration/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_ChartsIntegration/MainWindow.xaml.vb))
<!-- default file list end -->
# How to visualize pivot grid data via the DXCharts Suite


<p>The following example shows how to bind a Chart Control to a Pivot Grid to visualize data.</p><p>In this example, the Chart Control is bound to the DXPivotGrid by assigning the PivotGridControl.ChartDataSource property value to the ChartControl.DataSource property.</p><p>The main form of this sample application contains the 'Transpose Data Source' check box, which defines the PivotGridControl.ChartProvideDataByColumns property value. If the check box is checked, the property is set to false, and series are created based on pivot grid rows (instead of columns, which is default behavior).</p>

<br/>


