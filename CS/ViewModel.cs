// Developer Express Code Central Example:
// How to parallelize data-intensive operations on in-memory data in Instant Feedback UI mode
// 
// In this demo, the DevExpress Grid Control for WPF operates in Instant Feedback
// data binding mode on in-memory data. All operations on data (e.g. sorting,
// groping, filtering, summary calculation, etc.) are performed asynchronously and
// parallelized on multiple processors. This allows the computing power of your
// hardware to be utilized to the full extent without UI freezing.
// See also:
// WPF
// Data Grid Control – PLINQ Data Support
// (http://community.devexpress.com/blogs/theprogressbar/archive/2011/08/22/wpf-data-grid-control-plinq-data-support.aspx)
// Binding
// to In-Memory Data Using PLINQ
// (http://documentation.devexpress.com/#WPF/CustomDocument10472)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3382

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PLinqDataSource {
    public class PLinqViewModel{

        public PLinqViewModel() {
            ListSource = new OrderDataListSource(1000000);
        }

        public virtual OrderDataListSource ListSource { get; set; }
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
