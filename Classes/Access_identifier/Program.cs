using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public --- private
            Customer customer = new Customer();

            customer.firstName = "Melih";
            customer.lastName = "Arac";
            customer.salary = "20000";
            customer.gender = "Male";


        }
    }
}
