using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat :Animal
    {
        public Cat(string name):base(name) { 
        
         
        }

        public override void talk()
        {
            Console.WriteLine(getName() + " miyavlıyor...");
        }

    }
}
