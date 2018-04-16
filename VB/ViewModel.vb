Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace PLinqDataSource
	Public Class PLinqViewModel
		Implements INotifyPropertyChanged
		Private orderDataListSource As OrderDataListSource

		Public Sub New()
			ListSource = New OrderDataListSource(1000000)
		End Sub

		Public Property ListSource() As OrderDataListSource
			Get
				Return orderDataListSource
			End Get
			Set(ByVal value As OrderDataListSource)
				If orderDataListSource Is value Then
					Return
				End If
				orderDataListSource = value
				OnPropertyChanged("ListSource")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
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
			Dim rnd As New Random()
			Dim customersCount As Integer = Data.Customers.Count
			Dim productsCount As Integer = Data.Products.Count
			For i As Integer = 0 To count - 1
				Dim orderData As New OrderData()
				orderData.OrderId = i + 1
				orderData.CustomerName = Data.Customers(rnd.Next(customersCount))
				orderData.OrderDate = DateTime.Today.Subtract(TimeSpan.FromDays(rnd.Next(180)))
				Dim product As KeyValuePair(Of String, Decimal) = Data.Products(rnd.Next(productsCount))
				orderData.ProductName = product.Key
				orderData.Price = product.Value
				orderData.Quantity = rnd.Next(200) + 1
				orders.Add(orderData)
			Next i
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
		Public ReadOnly Property ContainsListCollection() As Boolean Implements IListSource.ContainsListCollection
			Get
				Return False
			End Get
		End Property
	End Class

	Public Class OrderData
		Private privateOrderId As Integer
		Public Property OrderId() As Integer
			Get
				Return privateOrderId
			End Get
			Set(ByVal value As Integer)
				privateOrderId = value
			End Set
		End Property
		Private privateCustomerName As String
		Public Property CustomerName() As String
			Get
				Return privateCustomerName
			End Get
			Set(ByVal value As String)
				privateCustomerName = value
			End Set
		End Property
		Private privateOrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As DateTime)
				privateOrderDate = value
			End Set
		End Property
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
	End Class
End Namespace
