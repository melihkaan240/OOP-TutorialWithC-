using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public string name {  get; set; }
        public Animal(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public virtual void talk()
        {
            Console.WriteLine("Hayvan Konuşuyor");
        }
    }
}
