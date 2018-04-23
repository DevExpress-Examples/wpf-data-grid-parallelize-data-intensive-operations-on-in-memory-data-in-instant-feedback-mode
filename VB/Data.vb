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

Imports System
Imports System.Collections.Generic

Namespace PLinqDataSource
    Public NotInheritable Class Data

        Private Sub New()
        End Sub


        Private Shared customers_Renamed As List(Of String)
        Public Shared ReadOnly Property Customers() As List(Of String)
            Get
                If customers_Renamed Is Nothing Then
                    customers_Renamed = New List(Of String)()
                    customers_Renamed.AddRange(New String() { "Maria Anders", "Ana Trujillo", "Antonio Moreno", "Thomas Hardy", "Christina Berglund", "Hanna Moos", "Frédérique Citeaux", "Martín Sommer", "Laurence Lebihan", "Elizabeth Lincoln", "Victoria Ashworth", "Patricio Simpson", "Francisco Chang", "Yang Wang", "Pedro Afonso", "Elizabeth Brown", "Sven Ottlieb", "Janine Labrune", "Ann Devon", "Roland Mendel", "Aria Cruz", "Diego Roel", "Martine Rancé", "Maria Larsson", "Peter Franken", "Carine Schmitt", "Paolo Accorti", "Lino Rodriguez ", "Eduardo Saavedra", "José Pedro Freyre", "André Fonseca", "Howard Snyder", "Manuel Pereira", "Mario Pontes", "Carlos Hernández", "Yoshi Latimer", "Patricia McKenna", "Helen Bennett", "Philip Cramer", "Daniel Tonini", "Annette Roulet", "Yoshi Tannamuri", "John Steel", "Renate Messner", "Jaime Yorres", "Carlos González", "Felipe Izquierdo", "Fran Wilson", "Giovanni Rovelli", "Catherine Dewey", "Jean Fresnière", "Alexander Feuer", "Simon Crowther", "Yvonne Moncada", "Rene Phillips", "Henriette Pfalzheim", "Marie Bertrand", "Guillermo Fernández", "Georg Pipps", "Isabel de Castro", "Bernardo Batista", "Lúcia Carvalho", "Horst Kloss", "Sergio Gutiérrez", "Paula Wilson", "Maurizio Moroni", "Janete Limeira", "Michael Holz", "Alejandra Camino", "Jonas Bergulfsen", "Jose Pavarotti", "Hari Kumar", "Jytte Petersen", "Dominique Perrier", "Art Braunschweiger", "Pascale Cartrain", "Liz Nixon", "Liu Wong", "Karin Josephs", "Miguel Angel Paolino", "Anabela Domingues", "Helvetius Nagy", "Palle Ibsen", "Mary Saveley", "Paul Henriot", "Rita Müller", "Pirkko Koskitalo", "Paula Parente", "Karl Jablonski", "Matti Karttunen", "Zbyszek Piestrzeniewicz" })
                End If
                Return customers_Renamed
            End Get
        End Property


        Private Shared products_Renamed As List(Of KeyValuePair(Of String, Decimal))
        Public Shared ReadOnly Property Products() As List(Of KeyValuePair(Of String, Decimal))
            Get
                If products_Renamed Is Nothing Then
                    products_Renamed = New List(Of KeyValuePair(Of String, Decimal))()
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chai", 18.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chang", 19.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Aniseed Syrup", 10.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chef Anton's Cajun Seasoning", 22.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chef Anton's Gumbo Mix", 21.35D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Grandma's Boysenberry Spread", 25.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Uncle Bob's Organic Dried Pears", 30.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Northwoods Cranberry Sauce", 40.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Mishi Kobe Niku", 97.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Ikura", 31.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Queso Cabrales", 21.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Queso Manchego La Pastora", 38.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Konbu", 6.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Tofu", 23.25D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Genen Shouyu", 15.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Pavlova", 17.45D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Alice Mutton", 39.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Carnarvon Tigers", 62.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Teatime Chocolate Biscuits", 9.2D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Sir Rodney's Marmalade", 81.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Sir Rodney's Scones", 10.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gustaf's Knäckebröd", 21.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Tunnbröd", 9.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Guaraná Fantástica", 4.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("NuNuCa Nuß-Nougat-Creme", 14.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gumbär Gummibärchen", 31.23D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Schoggi Schokolade", 43.9D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Rössle Sauerkraut", 45.6D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Thüringer Rostbratwurst", 123.79D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Nord-Ost Matjeshering", 25.89D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gorgonzola Telino", 12.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Mascarpone Fabioli", 32.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Geitost", 2.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Sasquatch Ale", 14.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Steeleye Stout", 18.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Inlagd Sill", 19.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gravad lax", 26.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Côte de Blaye", 263.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chartreuse verte", 18.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Boston Crab Meat", 18.4D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Jack's New England Clam Chowder", 9.65D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Singaporean Hokkien Fried Mee", 14.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Ipoh Coffee", 46.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gula Malacca", 19.45D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Røgede sild", 9.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Spegesild", 12.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Zaanse koeken", 9.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Chocolade", 12.75D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Maxilaku", 20.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Valkoinen suklaa", 16.25D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Manjimup Dried Apples", 53.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Filo Mix", 7.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Perth Pasties", 32.8D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Tourtière", 7.45D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Pâté chinois", 24.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gnocchi di nonna Alice", 38.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Ravioli Angelo", 19.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Escargots de Bourgogne", 13.25D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Raclette Courdavault", 55.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Camembert Pierrot", 34.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Sirop d'érable", 28.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Tarte au sucre", 49.3D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Vegie-spread", 43.9D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Wimmers gute Semmelknödel", 33.25D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Louisiana Fiery Hot Pepper Sauce", 21.05D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Louisiana Hot Spiced Okra", 17.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Laughing Lumberjack Lager", 14.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Scottish Longbreads", 12.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Gudbrandsdalsost", 36.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Outback Lager", 15.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Fløtemysost", 21.5D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Mozzarella di Giovanni", 34.8D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Röd Kaviar", 15.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Longlife Tofu", 10.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Rhönbräu Klosterbier", 7.75D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Lakkalikööri", 18.0D))
                    products_Renamed.Add(New KeyValuePair(Of String,Decimal)("Original Frankfurter grüne Soße", 13.0D))
                End If
                Return products_Renamed
            End Get
        End Property
    End Class
End Namespace
