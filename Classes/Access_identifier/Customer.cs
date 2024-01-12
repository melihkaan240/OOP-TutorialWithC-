using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_identifier
{
    internal class Customer
    {
        public string firstName;
        public string lastName;
        public string salary;
        public string gender;

        private int age;

        public void showCustomerInformation()
        {
            Console.WriteLine("first name : " + firstName);
            Console.WriteLine("lastname : " + lastName);
            Console.WriteLine("customer salary : "+ salary);
            Console.WriteLine("customer gender : "+ gender);

        }

        private void showFirstNameLastName(string firstName, string lastName)
        {
            Console.WriteLine("first name: "+ firstName);
            Console.WriteLine("last name: "+ lastName);
        }

    }
}
