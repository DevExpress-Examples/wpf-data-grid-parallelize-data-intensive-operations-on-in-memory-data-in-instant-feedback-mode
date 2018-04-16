using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PLinqDataSource {
    public class PLinqViewModel : INotifyPropertyChanged {
        OrderDataListSource orderDataListSource;

        public PLinqViewModel() {
            ListSource = new OrderDataListSource(1000000);
        }

        public OrderDataListSource ListSource {
            get { return orderDataListSource; }
            set {
                if(orderDataListSource == value) return;
                orderDataListSource = value;
                OnPropertyChanged("ListSource");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class OrderDataListSource : IListSource {
        List<OrderData> orders;
        int count = 0;
        static object Locker = new object();

        public OrderDataListSource(int count) {
            this.count = count;
        }

        void GenerateOrders() {
            orders = new List<OrderData>(count);
            Random rnd = new Random();
            int customersCount = Data.Customers.Count;
            int productsCount = Data.Products.Count;
            for(int i = 0; i < count; i++) {
                OrderData orderData = new OrderData();
                orderData.OrderId = i + 1;
                orderData.CustomerName = Data.Customers[rnd.Next(customersCount)];
                orderData.OrderDate = DateTime.Today.Subtract(TimeSpan.FromDays(rnd.Next(180)));
                KeyValuePair<string, decimal> product = Data.Products[rnd.Next(productsCount)];
                orderData.ProductName = product.Key;
                orderData.Price = product.Value;
                orderData.Quantity = rnd.Next(200) + 1;
                orders.Add(orderData);
            }
        }
        public IList GetList() {
            if(orders == null) {
                lock(Locker) {
                    if(orders == null) {
                        GenerateOrders();
                    }
                }
            }
            return orders;
        }
        public bool ContainsListCollection {
            get { return false; }
        }
    }

    public class OrderData {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
