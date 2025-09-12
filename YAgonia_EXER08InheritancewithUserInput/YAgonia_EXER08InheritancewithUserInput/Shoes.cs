using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAgonia_EXER08InheritancewithUserInput
{
    internal class Shoes
    {
        // Base class
        public class Shoe
        {
            private string brand;
            private string model;

            // Parameterless constructor
            public Shoe()
            {
                brand = "Unknown";
                model = "Unknown";
            }

            // Parameterized constructor
            public Shoe(string brand, string model)
            {
                this.brand = brand;
                this.model = model;
            }

            // Properties (Encapsulation)
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            // Method
            public virtual void DisplayDetails()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t---Here are the details for your chosen shoes---");
                Console.WriteLine($"\t\t\t\t\t\tBrand: {brand},\n\t\t\t\t\t\tModel: {model}");
                Console.ResetColor();
            }
        }

        // Derived class: Running Shoe with Foam Type
        public class TypeofFoam : Shoe
        {
            private string foamType;

            public TypeofFoam(string brand, string model, string foamType) : base(brand, model)
            {
                this.foamType = foamType;
            }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t\t\tFoam Type: {foamType}");
                Console.ResetColor();
            }
        }

        // Derived class: Casual Shoe with Color
        public class ColorofShoe : Shoe
        {
            private string color;

            public ColorofShoe(string brand, string model, string color) : base(brand, model)
            {
                this.color = color;
            }

            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t\t\tColor: {color}");
                Console.ResetColor();
            }
        }
    }
}
