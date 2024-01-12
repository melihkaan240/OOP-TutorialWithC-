using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        private string name;

        public void setIsim(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }
    }
}
