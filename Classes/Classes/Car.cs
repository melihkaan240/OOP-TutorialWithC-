using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        public int kapiSayisi;
        public String arabaModel;
        public String arabaRengi;


        
        public Car(int _kapiSayisi , string _arabaModel, string _arabaRengi)
        {
            // methodun adı constructordur class ile aynı isimlendirmeyi almak zorunda 
            // main sayfada bu class çağrıldığında ilk derlenen method constuctor methodudur
            kapiSayisi = _kapiSayisi ;
            arabaModel = _arabaModel ;
            arabaRengi = _arabaRengi ;
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor Çalıştır...");
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor");
        }
    }
}
