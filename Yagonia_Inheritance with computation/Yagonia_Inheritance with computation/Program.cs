using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_Inheritance_with_computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shoes sneakers = new Shoes { Price = 4999, Discount = 99 };
            Shoes boots = new Shoes { Price = 6099, Discount = 499};

            Console.WriteLine($"Final price of sneakers: {sneakers.FinalPrice}");
            Console.WriteLine($"Final price of boots: {boots.FinalPrice}");

            Console.ReadKey();

        }
    }
}
