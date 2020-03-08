﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        Order GetOrder(int id);
        IList<Order> GetOrders();
    }
}
