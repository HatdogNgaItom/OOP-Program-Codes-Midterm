using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_InheritanceCons_Computation.Shoes;

namespace Practice_InheritanceCons_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shoe Shop!");

            // Step 1: User chooses the shoe type
            Console.WriteLine("Please choose a type of shoe:");
            Console.WriteLine("1. Sneakers");
            Console.WriteLine("2. Formal Shoes");
            Console.Write("Enter your choice (1 or 2): ");
            string shoeTypeChoice = Console.ReadLine();

            // Lists of available shoes
            List<Shoe> availableShoes = new List<Shoe>();
            string chosenShoeType = "";

            if (shoeTypeChoice == "1")
            {
                availableShoes.Add(new Sneaker("Nike", "Air Max", 120.00m));
                availableShoes.Add(new Sneaker("Adidas", "Ultraboost", 150.00m));
                chosenShoeType = "Sneakers";
            }
            else if (shoeTypeChoice == "2")
            {
                availableShoes.Add(new FormalShoe("Florsheim", "Oxford", 180.00m));
                availableShoes.Add(new FormalShoe("Cole Haan", "Loafer", 200.00m));
                chosenShoeType = "Formal Shoes";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the program.");
                return;
            }

            // Step 2: User chooses the specific model
            Console.WriteLine($"\nAvailable {chosenShoeType}:");
            for (int i = 0; i < availableShoes.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                availableShoes[i].DisplayInfo();
            }

            Console.Write("Enter the number of the shoe you want to buy: ");
            int shoeModelChoice = int.Parse(Console.ReadLine()) - 1;

            if (shoeModelChoice < 0 || shoeModelChoice >= availableShoes.Count)
            {
                Console.WriteLine("Invalid choice. Please restart the program.");
                return;
            }

            Shoe chosenShoe = availableShoes[shoeModelChoice];

            // Step 3: User enters the quantity
            Console.Write($"\nHow many '{chosenShoe.Brand} {chosenShoe.Model}' do you want? ");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero. Please restart the program.");
                return;
            }

            // Step 4: Calculate and display the final total
            decimal finalPrice = chosenShoe.CalculateFinalPrice(quantity);

            Console.WriteLine("\n--- Order Summary ---");
            Console.WriteLine($"Item: {chosenShoe.Brand} {chosenShoe.Model}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Price: ${finalPrice:F2}");
            Console.WriteLine("---------------------\n");
        }
    }
}
