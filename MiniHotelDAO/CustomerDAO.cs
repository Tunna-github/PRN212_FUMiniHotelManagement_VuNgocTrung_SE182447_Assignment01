using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class CustomerDAO
    {
        private FuminiHotelManagementContext dbcontext;
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }

        public CustomerDAO()
        {
            dbcontext = new FuminiHotelManagementContext();
        }

        public List<Customer> GetCustomers()
        {
            return dbcontext.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return dbcontext.Customers.SingleOrDefault(m => m.CustomerId.Equals(id));
        }

        public void AddCustomer(Customer customer)
        {
            bool isSuccess = false;
            Customer customer1 = GetCustomerById(customer.CustomerId);
            if (customer1 == null)
            {
                dbcontext.Customers.Add(customer);
                dbcontext.SaveChanges();
                isSuccess = true;
            }
        }

            public Customer FindCustomerById(int id)
            {
            return dbcontext.Customers.Find(id);
            }

            public bool UpdateCustomer(Customer updateCustomer)
            {
                var existingCustomer = FindCustomerById(updateCustomer.CustomerId);
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerFullName = updateCustomer.CustomerFullName;
                    existingCustomer.Telephone = updateCustomer.Telephone;
                    existingCustomer.EmailAddress = updateCustomer.EmailAddress;
                    existingCustomer.CustomerBirthday = updateCustomer.CustomerBirthday;
                    existingCustomer.CustomerStatus = updateCustomer.CustomerStatus;
                    existingCustomer.Password = updateCustomer.Password;
                    return true;
                }
                return false;
            }

            public void DeleteCustomer(int id)
            {
                var customer = FindCustomerById(id);
                if (customer != null)
                {
                    dbcontext.Remove(customer);
                }
            }
        }
    }
