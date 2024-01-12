using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,"renault", "kırmızı");

           

            car.motorCalistir();
            car.kapilariKilitle();

            Console.WriteLine("Araba kapı sayısı:"+car.kapiSayisi);
            Console.WriteLine("Araba rengi:"+ car.arabaRengi);
            Console.WriteLine("Arabanın modeli:"+ car.arabaModel);
            Console.WriteLine(car);
            Console.ReadLine();

        }
    }
}
