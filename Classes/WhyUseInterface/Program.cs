using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseInterface
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Interface'imizi implement'e eden classlarımızdan oluşturduğumuz örneği INTERFACE KARŞILAYABİLİR.

            // Sqlserver Mysql  Oracle

            CustomerController customerController = new CustomerController();
            customerController.addCustomer(new MySql());
            customerController.addCustomer(new SqlServer());

            Console.ReadLine();
        }
    }
}
