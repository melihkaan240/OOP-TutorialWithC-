using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enumerations(Numaralandırmalar) anlamına gelir. Eğer ki 1 gelirse şunu yap, 2 gelirse şunu yap
            // 2 ye bunu yap dediğimiz yerlerde ve bunun gibi işlemlerde oldukça faydalı olan bir yapıdır.
            // Büyük projelerde önemi ölçülemeyecek kadar büyüktür.

            // Enum içerisinde değer vermezsek, değerler 0'dan başlar ve birer birer artar. 
           Days day= Days.Wednesday;

            if(day == Days.Monday)
            {
                Console.WriteLine("this day Monday");
            }
            else if (day== Days.Tuesday)
            {
                Console.WriteLine("this day Tuesday");
            }
            else if (day == Days.Wednesday)
            {
                Console.WriteLine("this day Wednesday");
            }
            else if (day == Days.Thursday)
            {
                Console.WriteLine("this day Thursday");
            }
            else if (day == Days.Friday)
            {
                Console.WriteLine("this day Friday");
            }
            else if (day == Days.Saturday)
            {
                Console.WriteLine("this day Saturday");
            }
            else if (day == Days.Sunday)
            {
                Console.WriteLine("this day Sunday");
            }
            else                                   
                    Console.WriteLine("Lütfen geçerli bir gün giriniz");

            Console.ReadLine();
        }

        
    }
}
