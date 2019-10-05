using CoffeeShopAssignmentUI.Model;
using CoffeeShopAssignmentUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopAssignmentUI.BLL
{
   public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();

        public DataTable GetAllItem()
        {
            return _orderRepository.GetAllItem();
        }
        public DataTable GetAllCustomer()
        {
            return _orderRepository.GetAllCustomer();
        }
        public bool AddOrder(Order order)
        {
            return _orderRepository.AddOrder(order);
        }
        public bool IsNullOrEmpty(Order order)
        {
            return _orderRepository.IsNullOrEmpty(order);
        }

    }
}
