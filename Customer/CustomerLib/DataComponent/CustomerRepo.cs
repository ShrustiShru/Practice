using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.DataComponent
{
    public class CustomerRepo : ICustomer
    {
        private bool isValidEmail(string email)
        {
            var context = new CustomerEntities();
            var found = context.Customers.SingleOrDefault((m) => m.CustomerEmail == email);
            return found == null;
        }
        public void RegisterCustomer(Customer customer)
        {
            if (isValidEmail(customer.CustomerEmail))
            {
                var context = new CustomerEntities();
                var data = context.Customers.Add(customer);
                context.SaveChanges();
            }
            else
                throw new Exception("Customer is already registered. Please check on forgot password ");
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer ValidateCustomer(string email, string password)
        {

            var context = new CustomerEntities();
            var found = context.Customers.SingleOrDefault((m) => m.CustomerEmail == email && m.CustomerPassword==password);
            if (context != null)
                return found;
            else
            throw new Exception("Login Error");
        }
    }
}
