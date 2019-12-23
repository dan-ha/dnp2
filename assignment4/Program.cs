using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product() { Name = "bread", Price = 10 };
            Product milk = new Product() { Name = "milk", Price = 8 };
            Product butter = new Product() { Name = "butter", Price = 12 };
            Product cacao = new Product() { Name = "cacao", Price = 20 };
            Product juice = new Product() { Name = "juice", Price = 18 };

            Customer customer1 = new Customer()
            {
                Name = "Kim Foged",
                City = "Beder",
                Orders = new Order[] {
                    new Order() { Product = milk, Quantity = 3 },
                    new Order() { Product = butter, Quantity = 1 },
                    new Order() { Product = bread, Quantity = 1 }
                }
            };
            Customer customer2 = new Customer()
            {
                Name = "Ib Havn",
                City = "Horsens",
                Orders = new Order[]
                {
                    new Order() { Product = milk, Quantity = 1},
                    new Order() { Product = butter, Quantity = 3},
                    new Order() { Product = bread, Quantity = 2},
                    new Order() { Product = cacao, Quantity = 1}
                }
            };
            Customer customer3 = new Customer()
            {
                Name = "Rasmus Bjerner",
                City = "Horsens",
                Orders = new Order[]
                {
                    new Order() { Product = juice, Quantity = 12 }
                }
            };

            List<Customer> customers = new List<Customer>() { customer1, customer2, customer3 };

            var allCustomers = from customer in customers select $"{customer.Name}, {customer.City}";
            Console.WriteLine("Customers: \n" + string.Join("\n", allCustomers));

            var horsensCustomers = from customer in customers where customer.City == "Horsens" select customer.Name;
            Console.WriteLine("Horsens customers: \n" + string.Join("\n", horsensCustomers));

            var ibOrderCount = (from customer in customers from order in customer.Orders where customer.Name == "Ib Havn" select order).Count();
            Console.WriteLine("Ib order count: " + ibOrderCount);

            var milkDrinkers = from customer in customers from order in customer.Orders where order.Product.Name == "milk" select customer.Name;
            Console.WriteLine("Milk drinkers: \n" + string.Join("\n", milkDrinkers));

            var receipts = from customer in customers
                           let sum = (from order in customer.Orders select order.Quantity * order.Product.Price).Sum()
                           select $"{customer.Name}: {sum}dkk";
            Console.WriteLine("Receipts: \n" + string.Join("\n", receipts));

            var total = (from customer in customers from order in customer.Orders select order.Quantity * order.Product.Price).Sum();
            Console.WriteLine("Total sum: " + total);
        }
    }
}
