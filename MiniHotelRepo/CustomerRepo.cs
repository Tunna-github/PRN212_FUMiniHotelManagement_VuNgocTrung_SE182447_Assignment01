using BusinessObject.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        public void DeleteCustomer(int id) => CustomerDAO.Instance.DeleteCustomer(id);

        public Customer GetCustomerById(int id) => CustomerDAO.Instance.GetCustomerById(id);

        public List<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomers();

        public void AddCustomer(Customer customer) => CustomerDAO.Instance.AddCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
    }
}
