using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyon
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }

        public Customer(int id, string name, string lastName , string email)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;  
            this.email = email;
        }
        public override string ToString()
        {
            return "Id : " + this.id + " " + "İsim : " + this.name + " " + "Soy isim : " + this.lastName + " " + "Email : " + this.email;
        }

    }
}
