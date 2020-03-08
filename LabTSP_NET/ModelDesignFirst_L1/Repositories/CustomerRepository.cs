using ModelDesignFirst_L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            using (Model1Container context = new Model1Container())
            {
                customer = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            }
            return customer;
        }

        public IList<Customer> GetCustomers()
        {
            List<Customer> customer = new List<Customer>();
            using (Model1Container context = new Model1Container())
            {
                customer = context.Customers.ToList();
            }
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            using (Model1Container context = new Model1Container())
            {
                Customer oldCustomer = context.Customers.Where(x => x.CustomerId == customer.CustomerId).FirstOrDefault();
                if (oldCustomer != null)
                {
                    oldCustomer.City = customer.City;
                    oldCustomer.Name = customer.Name;
                    oldCustomer.Orders = customer.Orders;
                    context.SaveChanges();
                }
            }
        }
    }
}
