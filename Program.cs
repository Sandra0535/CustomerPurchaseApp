using CustomerPurchaseApp.Model;

namespace CustomerPurchaseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Purchase App");
            Console.WriteLine("------------");
            Customer customer = new Customer(1,"Alex");

            customer.AddOrder(11, DateTime.Now);
            Order.AddLineItem(11, 2);
            LineItem.AddProduct(101, "Bag", 680, 25);
            LineItem.AddProduct(102, "Book", 85, 10);

            customer.AddOrder(12, DateTime.Now);
            Order.AddLineItem(12, 2);
            LineItem.AddProduct(103, "Iron Box", 1300, 50);
            LineItem.AddProduct(104, "Gas Stove", 2800, 15);
            Console.WriteLine(Customer.PrintDetails());
        }
    }
}