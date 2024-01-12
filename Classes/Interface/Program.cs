using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface'lerden bir tane örnek oluşturamazsınız.
            //interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir.
            //interface içerisinde metotları tanımlarız. Classlarda da içeriği doldururuz.
            //interface içindeki metotların ERİŞİM BELİRLEYİCİLERİ  ve  İÇERİĞİ olmaz.
            //interface'leri miras alan sınıflar. içerisinde tanımlanan tüm metodları Implemente etmek zorundadır.
            //Bir Class sadece bir class tan türetilebilirken, bir Class birden çok Interfaceden türetilebilir.

            ICustomer customer = new Customer();
            customer.add();
            customer.delete();


            Console.ReadLine();

            // ICustomer customerinterface = new ICustomer();


        }
    }
}
