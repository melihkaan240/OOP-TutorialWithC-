using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repostroy<Customer> repostoryCustomer = new Repostroy<Customer>();
            List<Customer> customerList = repostoryCustomer.Getir();

            Customer customer = new Customer();
            customer.id = 1;
            customer.name = "Melih";
            customer.lastName = "Araç";
            customer.emailAddress = "melih.araç@gmail.com";

            repostoryCustomer.Ekle(customer);

            Repostroy<Product> repostoryProduct = new Repostroy<Product>();
          List<Product> myProduct=  repostoryProduct.Getir();
            Product product = new Product();
            product.productId = 1;
            product.productName = "Elma";
            product.productPrice = 100;

           string output= repostoryProduct.Ekle(product);

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
