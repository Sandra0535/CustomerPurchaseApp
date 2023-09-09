using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPurchaseApp.Model
{
    internal class LineItem
    {
        private int _id;
        private int _quantity;
        private static Product product;
        public static int Id { get { return _id; } set { _id = value; } }
        public static int Quantity { get { return _quantity; } set { _quantity = value; } }
        public LineItem(int id,int quantity)
        {
            Id= id;
            Quantity = quantity;
        }
        public static void AddProduct(int id,string name,double price,double discountPrice)
        {
            product = new Product(id,name,price,discountPrice);
        }
        public double CalculateLineItemCost()
        {
            double priceAfterDiscount = product.DiscountPrice();
            return Quantity* priceAfterDiscount;
        }
    }
}
