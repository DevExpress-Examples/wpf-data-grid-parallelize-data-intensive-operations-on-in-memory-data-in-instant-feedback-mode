Imports System.Collections.Generic

Namespace PLinqDataSource

    Public Module Data

        Private customersField As List(Of String)

        Public ReadOnly Property Customers As List(Of String)
            Get
                If customersField Is Nothing Then
                    customersField = New List(Of String)()
                    customersField.AddRange(New String() {"Maria Anders", "Ana Trujillo", "Antonio Moreno", "Thomas Hardy", "Christina Berglund", "Hanna Moos", "Frédérique Citeaux", "Martín Sommer", "Laurence Lebihan", "Elizabeth Lincoln", "Victoria Ashworth", "Patricio Simpson", "Francisco Chang", "Yang Wang", "Pedro Afonso", "Elizabeth Brown", "Sven Ottlieb", "Janine Labrune", "Ann Devon", "Roland Mendel", "Aria Cruz", "Diego Roel", "Martine Rancé", "Maria Larsson", "Peter Franken", "Carine Schmitt", "Paolo Accorti", "Lino Rodriguez ", "Eduardo Saavedra", "José Pedro Freyre", "André Fonseca", "Howard Snyder", "Manuel Pereira", "Mario Pontes", "Carlos Hernández", "Yoshi Latimer", "Patricia McKenna", "Helen Bennett", "Philip Cramer", "Daniel Tonini", "Annette Roulet", "Yoshi Tannamuri", "John Steel", "Renate Messner", "Jaime Yorres", "Carlos González", "Felipe Izquierdo", "Fran Wilson", "Giovanni Rovelli", "Catherine Dewey", "Jean Fresnière", "Alexander Feuer", "Simon Crowther", "Yvonne Moncada", "Rene Phillips", "Henriette Pfalzheim", "Marie Bertrand", "Guillermo Fernández", "Georg Pipps", "Isabel de Castro", "Bernardo Batista", "Lúcia Carvalho", "Horst Kloss", "Sergio Gutiérrez", "Paula Wilson", "Maurizio Moroni", "Janete Limeira", "Michael Holz", "Alejandra Camino", "Jonas Bergulfsen", "Jose Pavarotti", "Hari Kumar", "Jytte Petersen", "Dominique Perrier", "Art Braunschweiger", "Pascale Cartrain", "Liz Nixon", "Liu Wong", "Karin Josephs", "Miguel Angel Paolino", "Anabela Domingues", "Helvetius Nagy", "Palle Ibsen", "Mary Saveley", "Paul Henriot", "Rita Müller", "Pirkko Koskitalo", "Paula Parente", "Karl Jablonski", "Matti Karttunen", "Zbyszek Piestrzeniewicz"})
                End If

                Return customersField
            End Get
        End Property

        Private productsField As List(Of KeyValuePair(Of String, Decimal))

        Public ReadOnly Property Products As List(Of KeyValuePair(Of String, Decimal))
            Get
                If productsField Is Nothing Then
                    productsField = New List(Of KeyValuePair(Of String, Decimal))()
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chai", 18.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chang", 19.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Aniseed Syrup", 10.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chef Anton's Cajun Seasoning", 22.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chef Anton's Gumbo Mix", 21.35D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Grandma's Boysenberry Spread", 25.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Uncle Bob's Organic Dried Pears", 30.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Northwoods Cranberry Sauce", 40.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Mishi Kobe Niku", 97.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Ikura", 31.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Queso Cabrales", 21.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Queso Manchego La Pastora", 38.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Konbu", 6.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Tofu", 23.25D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Genen Shouyu", 15.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Pavlova", 17.45D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Alice Mutton", 39.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Carnarvon Tigers", 62.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Teatime Chocolate Biscuits", 9.2D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Sir Rodney's Marmalade", 81.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Sir Rodney's Scones", 10.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gustaf's Knäckebröd", 21.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Tunnbröd", 9.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Guaraná Fantástica", 4.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("NuNuCa Nuß-Nougat-Creme", 14.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gumbär Gummibärchen", 31.23D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Schoggi Schokolade", 43.9D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Rössle Sauerkraut", 45.6D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Thüringer Rostbratwurst", 123.79D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Nord-Ost Matjeshering", 25.89D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gorgonzola Telino", 12.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Mascarpone Fabioli", 32.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Geitost", 2.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Sasquatch Ale", 14.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Steeleye Stout", 18.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Inlagd Sill", 19.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gravad lax", 26.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Côte de Blaye", 263.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chartreuse verte", 18.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Boston Crab Meat", 18.4D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Jack's New England Clam Chowder", 9.65D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Singaporean Hokkien Fried Mee", 14.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Ipoh Coffee", 46.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gula Malacca", 19.45D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Røgede sild", 9.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Spegesild", 12.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Zaanse koeken", 9.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Chocolade", 12.75D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Maxilaku", 20.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Valkoinen suklaa", 16.25D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Manjimup Dried Apples", 53.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Filo Mix", 7.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Perth Pasties", 32.8D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Tourtière", 7.45D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Pâté chinois", 24.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gnocchi di nonna Alice", 38.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Ravioli Angelo", 19.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Escargots de Bourgogne", 13.25D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Raclette Courdavault", 55.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Camembert Pierrot", 34.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Sirop d'érable", 28.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Tarte au sucre", 49.3D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Vegie-spread", 43.9D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Wimmers gute Semmelknödel", 33.25D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Louisiana Fiery Hot Pepper Sauce", 21.05D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Louisiana Hot Spiced Okra", 17.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Laughing Lumberjack Lager", 14.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Scottish Longbreads", 12.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Gudbrandsdalsost", 36.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Outback Lager", 15.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Fløtemysost", 21.5D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Mozzarella di Giovanni", 34.8D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Röd Kaviar", 15.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Longlife Tofu", 10.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Rhönbräu Klosterbier", 7.75D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Lakkalikööri", 18.0D))
                    Call productsField.Add(New KeyValuePair(Of String, Decimal)("Original Frankfurter grüne Soße", 13.0D))
                End If

                Return productsField
            End Get
        End Property
    End Module
End Namespace
