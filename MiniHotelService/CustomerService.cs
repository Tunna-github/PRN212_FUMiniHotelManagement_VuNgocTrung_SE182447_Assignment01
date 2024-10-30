using BusinessObject.Models;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo customerRepo;
        public CustomerService() 
        {
            customerRepo = new CustomerRepo();
        }
        public void AddCustomer(Customer customer) => customerRepo.AddCustomer(customer);

        public void DeleteCustomer(int id) => customerRepo.DeleteCustomer(id);

        public Customer GetCustomerById(int id) => customerRepo.GetCustomerById(id);

        public List<Customer> GetCustomers() => customerRepo.GetCustomers();

        public void UpdateCustomer(Customer customer) => customerRepo.UpdateCustomer(customer);
    }
}
