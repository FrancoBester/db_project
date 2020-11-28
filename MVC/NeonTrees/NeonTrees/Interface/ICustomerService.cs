using NeonTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Interface
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        public int GetNewCustomerID(Customer customer);
    }
}
