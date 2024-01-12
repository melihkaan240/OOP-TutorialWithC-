using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseInterface
{
    public class MySql : ICustomer
    {
        public void add()
        {
            Console.WriteLine("MySql eklendi...");
        }

        public void delete()
        {
            Console.WriteLine("MySql silindi...");

        }

        public void update()
        {
            Console.WriteLine("MySql güncellendi...");

        }
    }
}
