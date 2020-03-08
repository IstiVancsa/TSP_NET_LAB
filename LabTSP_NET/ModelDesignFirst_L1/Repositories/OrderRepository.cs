using ModelDesignFirst_L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void DeleteOrder(Order order)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        public Order GetOrder(int id)
        {
            Order order = new Order();
            using (Model1Container context = new Model1Container())
            {
                order = context.Orders.Where(x => x.OrderId == id).FirstOrDefault();
            }
            return order;
        }

        public IList<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            using (Model1Container context = new Model1Container())
            {
                orders = context.Orders.ToList();
            }
            return orders;
        }

        public void UpdateOrder(Order order)
        {
            using (Model1Container context = new Model1Container())
            {
                Order oldOrder = context.Orders.Where(x => x.OrderId == order.OrderId).FirstOrDefault();
                if (oldOrder != null)
                {
                    oldOrder.TotalValue = order.TotalValue;
                    oldOrder.OrderDate = order.OrderDate;
                    oldOrder.Customer.CustomerId = order.Customer.CustomerId;
                    oldOrder.Customer.Name = order.Customer.Name;
                    oldOrder.Customer.City = order.Customer.City;
                    context.SaveChanges();
                }
            }
        }
    }
}
