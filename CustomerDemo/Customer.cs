using System.Collections.Generic;

namespace CustomerDemo
{
    partial class Program
    {
        public class Customer
        {
            int Id;
            string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer()
            {

            }

            public Customer(int id)
            {
                this.Id = id;
            }

            public Customer(int id, string name)
                :this(id)
            {
                this.Name = name;
            }

        }
    }
}
