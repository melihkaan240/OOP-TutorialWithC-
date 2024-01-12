using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> rakamlar = new List<int>();
            //rakamlar.Add(0);
            //rakamlar.Add(1);
            //rakamlar.Add(2);
            //rakamlar.Add(3);
            //rakamlar.Add(4);
            //rakamlar.Add(5);
            //rakamlar.Add(6);
            //rakamlar.Add(7);
            //rakamlar.Add(8);
            //rakamlar.Add(9);

            //foreach (int i in rakamlar)
            //{
            //    Console.WriteLine(i);
            //}

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer(1, "Melih", "Araç", "melih.araç@gmail.com"));
            customers.Add(new Customer(2, "Yakup", "Reçber", "yakup.reçber@gmail.com"));
            customers.Add(new Customer(3, "Anten", "Osman", "anten.osman@gmail.com"));


            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }
    }
}
