using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Customer
    {
        private int weight;

        public int Myproperty
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
