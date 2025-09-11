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
    class TypeofFoam: Shoes
    {
       //Fields
       public string FoamType
       //Constructor
       public TypeofFoam(string abrand, string amodel, string afoamtype ) : base(abrand, amodel)
       {
           FoamType = afoamtype;
       }
       public void RunningDetails()
       {
           Console.WriteLine($"What type of outsole foam do you want: ");
       }
    }
    class ColorofShoe
    {
        //Fields
        public string ColorofShoe
        //Constructor
        public ColorofShoe(string abrand, string amodel, string acolorofshoe)
        {
            ColorofShoe = acolorofshoe;
        }
        //Method
        public void ColorofShoeDetails()
        {
            Console.WriteLine($"What color of shoe do you prefer:");
        }
    }
}
