using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Repostroy<T>
    {
        public List<T> Getir()
        {
            //Veritabanında ilgili tabloya git ve kayıtları getir
            return null;
        }

        public string Ekle(T data)
        {
            // Veritabanına git ilgili tabloya T tipindeki datayı ekle

            return "Data başarılı bir şekilde eklenmiştir";
        }
    }
}
