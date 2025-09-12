using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YAgonia_EXER08InheritancewithUserInput.Shoes;

namespace YAgonia_EXER08InheritancewithUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jack Anthony Dolino Yagonia
            //IT306
            //EXER08_Inheritance with User Input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t CHOOSE WHAT TYPE OF SHOES ARE YOU LOOKING FOR:");
            Console.WriteLine("\t\t\t\t\t\t1. Running Shoes");
            Console.WriteLine("\t\t\t\t\t\t2. Casual Shoes");
            Console.Write("\t\t\t\t\t Enter your choice (1 or 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t --You chose Running Shoes.--");

                Console.Write("\t\t\t\t\tEnter the brand of the shoe: ");
                string brand = Console.ReadLine();

                Console.Write("\t\t\t\t\tEnter the model of the shoe: ");
                string model = Console.ReadLine();

                Console.Write("\t\t\t\t\tEnter the foam type: ");
                string foam = Console.ReadLine();

                TypeofFoam runningShoe = new TypeofFoam(brand, model, foam);
                runningShoe.DisplayDetails();
            }
            else if (choice == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t --You chose Casual Shoes.--");

                Console.Write("\t\t\t\t\tEnter the brand of the shoe: ");
                string brand = Console.ReadLine();

                Console.Write("\t\t\t\t\tEnter the model of the shoe: ");
                string model = Console.ReadLine();

                Console.Write("\t\t\t\t\tEnter the shoe color: ");
                string color = Console.ReadLine();

                ColorofShoe casualShoe = new ColorofShoe(brand, model, color);
                casualShoe.DisplayDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\tInvalid choice. Please select 1 or 2.");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
