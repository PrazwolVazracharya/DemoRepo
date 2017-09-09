using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Prajwol");
            customer.Orders.Add(new Order()); // adding order to customer
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
            Console.WriteLine("Order is");
            Console.WriteLine("Program is ");


        }
    }
}
