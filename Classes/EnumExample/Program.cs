using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Melih","Araç","Erkek","melih@gmail.com");

            CustomerState returnState  = customer.addCustomer(customer);

            if(returnState == CustomerState.kayıtBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Müşteri ekleme başarısız...");
            }

            Console.ReadLine();
        }
    }
}
