using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstact classlar tamamen kalıtım amaçlı geliştirilmiştir.
            //İçerisinde tanımlanmış metot imzalarının miras alan class'lar override etmek zorundadır.

            // Abstract classlar - Normal Class arasındaki fark nedir ?

            // 1-Normal classlar'da metot imza tanımı yapmaz iken Abstract classlar'da metot imzası yapılır.
            // 2-normal classlar'da new anahtar kelimesi ile nesneler oluşturabilirken Abstract classlar'da yapamayız.

            // Abstract classlar - interface Farkı nedir?

            // --> Bir sınıfa abstract class'lardan sadece birini miras alabilirken , o class birden çok interface'i İmplemente edebilir.

            //AltSinif altsinif = new AltSinif();
            //altsinif.metot1();
            //altsinif.metot2();

            //Console.ReadLine();
            AltSinif alt = new AltSinif();
            TemelSinif temel = new TemelSinif();
        }
    }
}
