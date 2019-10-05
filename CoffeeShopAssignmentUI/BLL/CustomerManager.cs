using CoffeeShopAssignmentUI.Model;
using CoffeeShopAssignmentUI.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopAssignmentUI.BLL
{
   public class CustomerManager
    {
        CustomerRepository _CustomerRepository = new CustomerRepository();
        Customer _customer = new Customer();

        public void addCustomer(Customer customer)
        {
            _CustomerRepository.addCustomer(customer);
        }
        public bool IsNameExsist(Customer customer)
        {
            return _CustomerRepository.IsNameExsist(customer);
        }
        public DataTable Display()
        {
            return _CustomerRepository.Display();
        }
    }
}
