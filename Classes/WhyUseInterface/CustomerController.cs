using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseInterface
{
    public class CustomerController
    {
        public void addCustomer(ICustomer database)
        {
            database.add();
        }
    }
}
