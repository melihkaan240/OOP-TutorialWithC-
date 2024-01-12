using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.weight = 85;
            Console.WriteLine("Customer weight: "+customer.weight);
            Console.ReadLine();

        }
    }
}
