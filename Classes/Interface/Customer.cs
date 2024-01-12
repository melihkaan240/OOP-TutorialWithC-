using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Customer : IEmployee
    {
        public void add()
        {
            Console.WriteLine("Müşteri eklendi...");
        }

        public int addEmployee()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            Console.WriteLine("Müşteri silindi...");

        }

        public void get()
        {
            Console.WriteLine("Müşteri getirildi...");

        }

        public void update()
        {
            Console.WriteLine("Müşteri güncellendi...");

        }
    }
}
