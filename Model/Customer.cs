using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPurchaseApp.Model
{
    internal class Customer
    {
        public int id;
        public string name;
        //public List<Order> orders = new List<Order>();
        List<Order> Orders { get; set; }
        public Customer(int id,string name) 
        {
            this.id = id;
            this.name = name;
            Orders = new List<Order>();
        }
        public void AddOrder(int id,DateTime date)
        {
            Orders.Add(new Order(id,date));
        }
        public static string PrintDetails()
        {
            return $"Customer Id:{id}\tName: {name}\nOrder No:1" +
                $"\tOrder Id:{Order.Id}\tOrder Date:{Order.Date}\nLineItemId:{LineItem.Id}\tQuantity:{LineItem.Quantity}" +
                $"Product Id:{Product.Id}\tProduct Name:{}";
        
    }
}
