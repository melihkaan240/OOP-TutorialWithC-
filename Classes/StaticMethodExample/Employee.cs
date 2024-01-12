using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodExample
{
    internal class Employee
    {
        public static void lastFirstNameShow()
        {
            Console.WriteLine("Melih Kaan Araç");
        }
        public static void gatherNumbers(int number1, int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
