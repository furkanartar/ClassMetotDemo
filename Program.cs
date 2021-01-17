using System;
using System.ComponentModel;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { CustomerID =1,CustomerName = "Furkan", CustomerLastName = "ARTAR" };
            Customer customer2 = new Customer() { CustomerID = 2, CustomerName = "Engin", CustomerLastName = "DEMİROĞ" };
            Customer customer3 = new Customer() { CustomerID = 3, CustomerName = "Derin", CustomerLastName = "DEMİROĞ" };
            Customer customer4 = new Customer() { CustomerID = 4, CustomerName = "Ramona", CustomerLastName = "FLOWERS" };

            Customer[] customers = { customer1,customer2,customer3 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("----------------- Add -----------------");
            customerManager.Add(customer4);

            Console.WriteLine("----------------- Delete -----------------");
            customerManager.Delete(customer4);

            Console.WriteLine("----------------- List -----------------");
            foreach (var customer in customers)
            {
                customerManager.List(customer);
            }
        }
    }
}
