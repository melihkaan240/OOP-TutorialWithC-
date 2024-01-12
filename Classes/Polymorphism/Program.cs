using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {

        // Bir method birden fazla anlamda override yapılarak kullanılabilir
        static void Main(string[] args)
        {
            //Animal animal = new Animal("Hayvan");
            //animal.talk();

            //Animal cat = new Cat("Boncuk");
            //cat.talk();

            //Animal dog = new Dog("Kara Baş");
            //dog.talk();

            //Console.ReadLine();

            AnimalstoTalk(new Cat("Tarçın"));
            AnimalstoTalk(new Dog("Karabaş"));

            Console.ReadLine();

        }

        public static void AnimalstoTalk(Animal animal)
        {
            animal.talk();
        }
    }
}
