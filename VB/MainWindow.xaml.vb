' Developer Express Code Central Example:
' How to parallelize data-intensive operations on in-memory data in Instant Feedback UI mode
' 
' In this demo, the DevExpress Grid Control for WPF operates in Instant Feedback
' data binding mode on in-memory data. All operations on data (e.g. sorting,
' groping, filtering, summary calculation, etc.) are performed asynchronously and
' parallelized on multiple processors. This allows the computing power of your
' hardware to be utilized to the full extent without UI freezing.
' See also:
' WPF
' Data Grid Control – PLINQ Data Support
' (http://community.devexpress.com/blogs/theprogressbar/archive/2011/08/22/wpf-data-grid-control-plinq-data-support.aspx)
' Binding
' to In-Memory Data Using PLINQ
' (http://documentation.devexpress.com/#WPF/CustomDocument10472)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3382
Imports System.Windows
Imports System.Windows.Controls
Imports System.Diagnostics

Namespace PLinqDataSource

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
