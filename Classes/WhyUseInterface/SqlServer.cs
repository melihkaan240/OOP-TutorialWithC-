using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseInterface
{
    public class SqlServer : ICustomer
    {
        public void add()
        {
            Console.WriteLine("Sql server ekledi...");
        }

        public void delete()
        {
            Console.WriteLine("Sql server silindi...");

        }

        public void update()
        {
            Console.WriteLine("Sql server güncellendi...");

        }
    }
}
