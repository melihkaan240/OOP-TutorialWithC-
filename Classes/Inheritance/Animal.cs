using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string animalName { get; set; }
        public string animalGender { get; set;}

        public string animalColor { get; set; }
        private string animalAge { get; set; }

        public void animalInformationShow()
        {
            Console.WriteLine("Hayvan ismi: "+ animalName);
            Console.WriteLine("Hayvan cinsiyeti: "+ animalGender);
            Console.WriteLine("Hayvan rengi: "+ animalColor);
        }

    }
}
