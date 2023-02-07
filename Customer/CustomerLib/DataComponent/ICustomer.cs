using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.DataComponent
{
    public interface ICustomer
    {
        void RegisterCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer ValidateCustomer(string email, string password);
    }
}
