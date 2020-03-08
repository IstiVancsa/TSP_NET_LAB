using ModelDesignFirst_L1.Interfaces;
using ModelDesignFirst_L1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Test Model Designer First");
            //TestPerson();
            //Console.ReadKey();

            //--------------------------

            IPersonRepository personRepository = new PersonRepository();
            ICustomerRepository customerRepository = new CustomerRepository();
            IOrderRepository orderRepository = new OrderRepository();

            //personRepository.AddPerson(GetPersonFromKeyboard());
            var cust = customerRepository.GetCustomer(5);
            TesTOneToMany();
        }

        private static Person GetPersonFromKeyboard()
        {
            Console.WriteLine("Write Info for person to be added: ");
            Console.WriteLine("FirstName = ");
            var firstName = Console.ReadLine();
            Console.WriteLine("MiddleName = ");
            var middleName = Console.ReadLine();
            Console.WriteLine("LastName = ");
            var lastName = Console.ReadLine();
            Console.WriteLine("TelephoneNumber = ");
            var telephoneNumber = Console.ReadLine();
            return new Person
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                TelephoneNumber = telephoneNumber
            };
        }

        private static Customer GetCustomerFromKeyboard()
        {
            Console.WriteLine("Write Info for customer to be added: ");
            Console.WriteLine("Name = ");
            var name = Console.ReadLine();
            Console.WriteLine("City = ");
            var city = Console.ReadLine();
            return new Customer
            {
                Name = name,
                City = city
            };
        }

        private static Order GetOrderFromKeyboard()
        {
            Console.WriteLine("Write Info for order to be added: ");
            Console.WriteLine("TotalValue = ");
            var totalValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("OrderDate = ");
            var orderDate = Convert.ToDateTime(Console.ReadLine());
            return new Order
            {
                TotalValue = totalValue,
                OrderDate = orderDate
            };
        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                var firstName = Console.ReadLine();
                var middleName = Console.ReadLine();
                var lastName = Console.ReadLine();
                var phoneNumber = Console.ReadLine();
                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    TelephoneNumber = phoneNumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
        static void TesTOneToMany()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            IOrderRepository orderRepository = new OrderRepository();
            Console.WriteLine("One to many association");
            using (Model1Container context = new Model1Container())
            {
                Customer c = GetCustomerFromKeyboard();
                Order o1 = GetOrderFromKeyboard();
                Order o2 = GetOrderFromKeyboard();
                o1.Customer = customerRepository.GetCustomer(1);
                o2.Customer = customerRepository.GetCustomer(2);
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                    x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                        ox.OrderId, ox.OrderDate, ox.TotalValue);
                }
            }
        }
    }
}
