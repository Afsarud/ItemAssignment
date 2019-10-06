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

        public bool AddCustomer(Customer customer)
        {
            return _CustomerRepository.AddCustomer(customer);
        }
        public bool IsNameExsist(Customer customer)
        {
            return _CustomerRepository.IsNameExsist(customer);
        }
        public DataTable Display()
        {
            return _CustomerRepository.Display();
        }
        public DataTable CustomerSearch(Customer customer)
        {
            return _CustomerRepository.CustomerSearch(customer);
        }
        public bool Update(Customer customer)
        {
            return _CustomerRepository.Update(customer);
        }
        public DataTable CustomerComboBox()
        {
           return _CustomerRepository.CustomerComboBox();
        }
    }
}
