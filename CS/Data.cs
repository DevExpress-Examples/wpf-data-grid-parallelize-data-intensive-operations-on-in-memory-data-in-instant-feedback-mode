using System;
using System.Collections.Generic;

namespace PLinqDataSource {
    public static class Data {
        static List<string> customers;
        public static List<string> Customers {
            get {
                if(customers == null) {
                    customers = new List<string>();
                    customers.AddRange(new string[] { "Maria Anders", "Ana Trujillo", "Antonio Moreno", "Thomas Hardy",
"Christina Berglund", "Hanna Moos", "Frédérique Citeaux", "Martín Sommer", "Laurence Lebihan", "Elizabeth Lincoln",
"Victoria Ashworth", "Patricio Simpson", "Francisco Chang", "Yang Wang", "Pedro Afonso", "Elizabeth Brown", "Sven Ottlieb",
"Janine Labrune", "Ann Devon", "Roland Mendel", "Aria Cruz", "Diego Roel", "Martine Rancé", "Maria Larsson", "Peter Franken",
"Carine Schmitt", "Paolo Accorti", "Lino Rodriguez ", "Eduardo Saavedra", "José Pedro Freyre", "André Fonseca", "Howard Snyder",
"Manuel Pereira", "Mario Pontes", "Carlos Hernández", "Yoshi Latimer", "Patricia McKenna", "Helen Bennett", "Philip Cramer",
"Daniel Tonini", "Annette Roulet", "Yoshi Tannamuri", "John Steel", "Renate Messner", "Jaime Yorres", "Carlos González",
"Felipe Izquierdo", "Fran Wilson", "Giovanni Rovelli", "Catherine Dewey", "Jean Fresnière", "Alexander Feuer", "Simon Crowther",
"Yvonne Moncada", "Rene Phillips", "Henriette Pfalzheim", "Marie Bertrand", "Guillermo Fernández", "Georg Pipps", "Isabel de Castro",
"Bernardo Batista", "Lúcia Carvalho", "Horst Kloss", "Sergio Gutiérrez", "Paula Wilson", "Maurizio Moroni", "Janete Limeira",
"Michael Holz", "Alejandra Camino", "Jonas Bergulfsen", "Jose Pavarotti", "Hari Kumar", "Jytte Petersen", "Dominique Perrier",
"Art Braunschweiger", "Pascale Cartrain", "Liz Nixon", "Liu Wong", "Karin Josephs", "Miguel Angel Paolino", "Anabela Domingues",
"Helvetius Nagy", "Palle Ibsen", "Mary Saveley", "Paul Henriot", "Rita Müller", "Pirkko Koskitalo", "Paula Parente", "Karl Jablonski",
"Matti Karttunen", "Zbyszek Piestrzeniewicz" });
                }
                return customers;
            }
        }

        static List<KeyValuePair<string, decimal>> products;
        public static List<KeyValuePair<string, decimal>> Products {
            get {
                if(products == null) {
                    products = new List<KeyValuePair<string, decimal>>();
                    products.Add(new KeyValuePair<string,decimal>("Chai", 18.0m));
                    products.Add(new KeyValuePair<string,decimal>("Chang", 19.0m));
                    products.Add(new KeyValuePair<string,decimal>("Aniseed Syrup", 10.0m));
                    products.Add(new KeyValuePair<string,decimal>("Chef Anton's Cajun Seasoning", 22.0m));
                    products.Add(new KeyValuePair<string,decimal>("Chef Anton's Gumbo Mix", 21.35m));
                    products.Add(new KeyValuePair<string,decimal>("Grandma's Boysenberry Spread", 25.0m));
                    products.Add(new KeyValuePair<string,decimal>("Uncle Bob's Organic Dried Pears", 30.0m));
                    products.Add(new KeyValuePair<string,decimal>("Northwoods Cranberry Sauce", 40.0m));
                    products.Add(new KeyValuePair<string,decimal>("Mishi Kobe Niku", 97.0m));
                    products.Add(new KeyValuePair<string,decimal>("Ikura", 31.0m));
                    products.Add(new KeyValuePair<string,decimal>("Queso Cabrales", 21.0m));
                    products.Add(new KeyValuePair<string,decimal>("Queso Manchego La Pastora", 38.0m));
                    products.Add(new KeyValuePair<string,decimal>("Konbu", 6.0m));
                    products.Add(new KeyValuePair<string,decimal>("Tofu", 23.25m));
                    products.Add(new KeyValuePair<string,decimal>("Genen Shouyu", 15.5m));
                    products.Add(new KeyValuePair<string,decimal>("Pavlova", 17.45m));
                    products.Add(new KeyValuePair<string,decimal>("Alice Mutton", 39.0m));
                    products.Add(new KeyValuePair<string,decimal>("Carnarvon Tigers", 62.5m));
                    products.Add(new KeyValuePair<string,decimal>("Teatime Chocolate Biscuits", 9.2m));
                    products.Add(new KeyValuePair<string,decimal>("Sir Rodney's Marmalade", 81.0m));
                    products.Add(new KeyValuePair<string,decimal>("Sir Rodney's Scones", 10.0m));
                    products.Add(new KeyValuePair<string,decimal>("Gustaf's Knäckebröd", 21.0m));
                    products.Add(new KeyValuePair<string,decimal>("Tunnbröd", 9.0m));
                    products.Add(new KeyValuePair<string,decimal>("Guaraná Fantástica", 4.5m));
                    products.Add(new KeyValuePair<string,decimal>("NuNuCa Nuß-Nougat-Creme", 14.0m));
                    products.Add(new KeyValuePair<string,decimal>("Gumbär Gummibärchen", 31.23m));
                    products.Add(new KeyValuePair<string,decimal>("Schoggi Schokolade", 43.9m));
                    products.Add(new KeyValuePair<string,decimal>("Rössle Sauerkraut", 45.6m));
                    products.Add(new KeyValuePair<string,decimal>("Thüringer Rostbratwurst", 123.79m));
                    products.Add(new KeyValuePair<string,decimal>("Nord-Ost Matjeshering", 25.89m));
                    products.Add(new KeyValuePair<string,decimal>("Gorgonzola Telino", 12.5m));
                    products.Add(new KeyValuePair<string,decimal>("Mascarpone Fabioli", 32.0m));
                    products.Add(new KeyValuePair<string,decimal>("Geitost", 2.5m));
                    products.Add(new KeyValuePair<string,decimal>("Sasquatch Ale", 14.0m));
                    products.Add(new KeyValuePair<string,decimal>("Steeleye Stout", 18.0m));
                    products.Add(new KeyValuePair<string,decimal>("Inlagd Sill", 19.0m));
                    products.Add(new KeyValuePair<string,decimal>("Gravad lax", 26.0m));
                    products.Add(new KeyValuePair<string,decimal>("Côte de Blaye", 263.5m));
                    products.Add(new KeyValuePair<string,decimal>("Chartreuse verte", 18.0m));
                    products.Add(new KeyValuePair<string,decimal>("Boston Crab Meat", 18.4m));
                    products.Add(new KeyValuePair<string,decimal>("Jack's New England Clam Chowder", 9.65m));
                    products.Add(new KeyValuePair<string,decimal>("Singaporean Hokkien Fried Mee", 14.0m));
                    products.Add(new KeyValuePair<string,decimal>("Ipoh Coffee", 46.0m));
                    products.Add(new KeyValuePair<string,decimal>("Gula Malacca", 19.45m));
                    products.Add(new KeyValuePair<string,decimal>("Røgede sild", 9.5m));
                    products.Add(new KeyValuePair<string,decimal>("Spegesild", 12.0m));
                    products.Add(new KeyValuePair<string,decimal>("Zaanse koeken", 9.5m));
                    products.Add(new KeyValuePair<string,decimal>("Chocolade", 12.75m));
                    products.Add(new KeyValuePair<string,decimal>("Maxilaku", 20.0m));
                    products.Add(new KeyValuePair<string,decimal>("Valkoinen suklaa", 16.25m));
                    products.Add(new KeyValuePair<string,decimal>("Manjimup Dried Apples", 53.0m));
                    products.Add(new KeyValuePair<string,decimal>("Filo Mix", 7.0m));
                    products.Add(new KeyValuePair<string,decimal>("Perth Pasties", 32.8m));
                    products.Add(new KeyValuePair<string,decimal>("Tourtière", 7.45m));
                    products.Add(new KeyValuePair<string,decimal>("Pâté chinois", 24.0m));
                    products.Add(new KeyValuePair<string,decimal>("Gnocchi di nonna Alice", 38.0m));
                    products.Add(new KeyValuePair<string,decimal>("Ravioli Angelo", 19.5m));
                    products.Add(new KeyValuePair<string,decimal>("Escargots de Bourgogne", 13.25m));
                    products.Add(new KeyValuePair<string,decimal>("Raclette Courdavault", 55.0m));
                    products.Add(new KeyValuePair<string,decimal>("Camembert Pierrot", 34.0m));
                    products.Add(new KeyValuePair<string,decimal>("Sirop d'érable", 28.5m));
                    products.Add(new KeyValuePair<string,decimal>("Tarte au sucre", 49.3m));
                    products.Add(new KeyValuePair<string,decimal>("Vegie-spread", 43.9m));
                    products.Add(new KeyValuePair<string,decimal>("Wimmers gute Semmelknödel", 33.25m));
                    products.Add(new KeyValuePair<string,decimal>("Louisiana Fiery Hot Pepper Sauce", 21.05m));
                    products.Add(new KeyValuePair<string,decimal>("Louisiana Hot Spiced Okra", 17.0m));
                    products.Add(new KeyValuePair<string,decimal>("Laughing Lumberjack Lager", 14.0m));
                    products.Add(new KeyValuePair<string,decimal>("Scottish Longbreads", 12.5m));
                    products.Add(new KeyValuePair<string,decimal>("Gudbrandsdalsost", 36.0m));
                    products.Add(new KeyValuePair<string,decimal>("Outback Lager", 15.0m));
                    products.Add(new KeyValuePair<string,decimal>("Fløtemysost", 21.5m));
                    products.Add(new KeyValuePair<string,decimal>("Mozzarella di Giovanni", 34.8m));
                    products.Add(new KeyValuePair<string,decimal>("Röd Kaviar", 15.0m));
                    products.Add(new KeyValuePair<string,decimal>("Longlife Tofu", 10.0m));
                    products.Add(new KeyValuePair<string,decimal>("Rhönbräu Klosterbier", 7.75m));
                    products.Add(new KeyValuePair<string,decimal>("Lakkalikööri", 18.0m));
                    products.Add(new KeyValuePair<string,decimal>("Original Frankfurter grüne Soße", 13.0m));
                }
                return products;
            }
        }
    }
}
