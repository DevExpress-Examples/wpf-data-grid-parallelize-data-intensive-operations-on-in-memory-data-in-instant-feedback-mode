Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace PLinqDataSource

    Public Class PLinqViewModel

        Public Sub New()
            ListSource = New OrderDataListSource(1000000)
        End Sub

        Public Overridable Property ListSource As OrderDataListSource
    End Class

    Public Class OrderDataListSource
        Implements IListSource

        Private orders As List(Of OrderData)

        Private count As Integer = 0

        Private Shared Locker As Object = New Object()

        Public Sub New(ByVal count As Integer)
            Me.count = count
        End Sub

        Private Sub GenerateOrders()
            orders = New List(Of OrderData)(count)
            Dim rnd As Random = New Random()
            Dim customersCount As Integer = Customers.Count
            Dim productsCount As Integer = Products.Count
            For i As Integer = 0 To count - 1
                Dim orderData As OrderData = New OrderData()
                orderData.OrderId = i + 1
                orderData.CustomerName = Customers(rnd.Next(customersCount))
                orderData.OrderDate = Date.Today.Subtract(TimeSpan.FromDays(rnd.Next(180)))
                Dim product As KeyValuePair(Of String, Decimal) = Products(rnd.Next(productsCount))
                orderData.ProductName = product.Key
                orderData.Price = product.Value
                orderData.Quantity = rnd.Next(200) + 1
                orders.Add(orderData)
            Next
        End Sub

        Public Function GetList() As IList Implements IListSource.GetList
            If orders Is Nothing Then
                SyncLock Locker
                    If orders Is Nothing Then
                        GenerateOrders()
                    End If

                End SyncLock
            End If

            Return orders
        End Function

        Public ReadOnly Property ContainsListCollection As Boolean Implements IListSource.ContainsListCollection
            Get
                Return False
            End Get
        End Property
    End Class

    Public Class OrderData

        Public Property OrderId As Integer

        Public Property CustomerName As String

        Public Property OrderDate As Date

        Public Property ProductName As String

        Public Property Price As Decimal

        Public Property Quantity As Integer
    End Class
End Namespace
