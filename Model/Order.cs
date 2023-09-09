using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPurchaseApp.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _date;
        private static List<LineItem> _items;
        public static int Id { get;set; }
        public static DateTime Date { get;set; }
        public Order(int id,DateTime date) 
        {
            Id = id;
            Date = date;
            _items = new List<LineItem>();
        }
        public static void AddLineItem(int id,int quantity)
        {
            _items.Add(new LineItem(id,quantity));
        }
        public double CalculateOrderPrice()
        {
            double orderCost = 0;
            foreach (LineItem item in _items)
            {
                orderCost += item.CalculateLineItemCost();
            }
            return orderCost;
        }
    }
}
