using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorMethodExample
{
    internal class User
    {
        private int userID { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private static int salary { get; set; }


        static User()
        {
            salary = 20000;
        }

        public User(int _userID, string _firstName , string _lastName)
        {
            userID = _userID;
            firstName = _firstName;
            lastName = _lastName;

        }

        public void showUserInformation()
        {
            Console.WriteLine("Kullanıcı bilgileri: "+ userID + firstName + lastName + salary);
        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor...");
            Console.WriteLine("Şu anki maaşı:" + (salary+zamMiktarı));

        }
    }
}
