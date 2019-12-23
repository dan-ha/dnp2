using System;
namespace assignment4
{
    public class Customer
    {
        public string Name;
        public string City;
        public Order[] Orders;
    }

    public class Order
    {
        public int Quantity;
        public Product Product;
    }

    public class Product
    {
        public string Name;
        public decimal Price;
    }
}
