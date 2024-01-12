using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.lastFirstNameShow();
            Employee.gatherNumbers(3, 6);
            
            Console.ReadLine();
        }
    }
}
