using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_EXER08
{
    internal class Shoes
    {
        public string brand;
        public string model;

        public Shoes(string abrand, string amodel )
        {
            brand = abrand;
            model = amodel;
            

        }

        //Method to display shoe details
        public void DisplayDetails()
        {
            Console.WriteLine("Shoe Brand: " + brand);
            Console.WriteLine("Shoe Model: " + model);
        }
    }
}
