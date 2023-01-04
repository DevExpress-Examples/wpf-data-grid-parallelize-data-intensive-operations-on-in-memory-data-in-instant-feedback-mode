<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652045/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3382)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Parallelize Data-intensive Operations in Instant Feedback Mode

This example binds the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) to the [PLinqInstantFeedbackDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ServerMode.PLinqInstantFeedbackDataSource) to speed up in-memory data shaping operations. The grid performs these operations (sort, group, filter, summary calculation, and so on) asynchronously.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))

## Documentation

* [PLinqInstantFeedbackDataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ServerMode.PLinqInstantFeedbackDataSource)
* [Speed Up In-memory Operations with PLINQ](https://docs.devexpress.com/WPF/10472/controls-and-libraries/data-grid/bind-to-data/server-mode-and-instant-feedback/bind-to-in-memory-data-using-plinq)
* [Server Mode and Instant Feedback Mode](https://docs.devexpress.com/WPF/6279/controls-and-libraries/data-grid/bind-to-data/server-mode-and-instant-feedback-mode)

## More Examples

* [Bind the WPF Data Grid to Data](https://github.com/DevExpress-Examples/how-to-bind-wpf-grid-to-data)
