using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.CustomerID} {customer.CustomerName} {customer.CustomerLastName} eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.CustomerID} {customer.CustomerName} {customer.CustomerLastName} silindi");
        }

        public void List(Customer customer)
        {
            Console.WriteLine($"Müşteri bilgileri: {customer.CustomerID} {customer.CustomerName} {customer.CustomerLastName}");
        }
    }
}
