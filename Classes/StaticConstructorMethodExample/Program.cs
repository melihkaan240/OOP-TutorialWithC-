using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"Melih", "Arac");

            user.showUserInformation();
            user.zamYap(5000);
            Console.ReadLine();
        }
    }
}
