using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection = new ArrayList();

            collection.Add("Melih");
            collection.Add("Kaan");
            collection.Add("Araç");

            collection.Remove("Kaan"); // Kaan adındaki indexi siler
            int count = collection.Count; // arrayin uzunluğunu sayar
            //collection.Clear(); // arrayi komple siler

            bool control = collection.Contains("Melih"); // değer var mı yok mu kontrol eder
            //int index = collection.IndexOf("Kaan"); // index numarasına bakar
            collection.Insert(1, "Sercan");

            foreach (var item in collection) {
                Console.WriteLine(item);

            }
            Console.ReadLine();

        }
    }
}
