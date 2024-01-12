using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geter seter methodlar yada propertyler ile kapsülleme yapılabilir.
            Student student = new Student();
            student.setIsim("Melih");

            string getName = student.getName();

            if(getName == "Melih")
            {
                Console.WriteLine("name is melih");
            }
            else
            {
                Console.WriteLine("name is not melih");
            }
            Console.ReadLine();
        }
    }
}
