using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee    employee = new Employee();

            employee.employeeID= 1;
            employee.firstName = "Melih";
            employee.lastName = "Arac";

            Employee.salary = 25000;

            Console.WriteLine("Çalışan id: "+ employee.employeeID);
            Console.WriteLine("Çalışan isim: "+ employee.firstName);
            Console.WriteLine("Çalışan soy isim: "+ employee.lastName);
            Console.WriteLine("Çalışan maaş: "+ Employee.salary);

            Console.ReadLine();
        }
    }
}
