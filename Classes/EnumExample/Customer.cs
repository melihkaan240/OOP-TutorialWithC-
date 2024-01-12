using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string EmailAddress { get; set; }

        public Customer(int id, string Name, string LastName,  string Gender, string EmailAddress ) { 
            this.Id= id;
            this.Name= Name;  
            this.LastName= LastName;
            this.Gender= Gender;
            this.EmailAddress= EmailAddress;
        }

        public static ArrayList customers = new ArrayList();

        public CustomerState addCustomer( Customer C1)
        {
            customers.Add( C1 );

            return CustomerState.kayıtBasarili;
        }
    }
}
