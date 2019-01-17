using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jashan_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();
            dogs.Add("bulldog");
            dogs.Add("collie");
            dogs.Add("Retriever");
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + "");
            // }
            // Console.WriteLine(dogs[0]);
            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };
            foreach (int i in a1)
            {
                Console.WriteLine(i + "");
            }
        }
    }
}
