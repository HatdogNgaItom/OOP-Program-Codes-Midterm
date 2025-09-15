using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_InheritanceCons_Computation
{
    internal class Shoes
    {
        // The main blueprint for all shoes
        public class Shoe
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public decimal BasePrice { get; set; }

            public Shoe(string brand, string model, decimal price)
            {
                Brand = brand;
                Model = model;
                BasePrice = price;
            }

            public virtual decimal CalculateFinalPrice(int quantity)
            {
                return BasePrice * quantity;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($" [{Brand}] {Model} - ${BasePrice:F2}");
            }
        }

        // A special type of shoe that adds a small fee
        public class Sneaker : Shoe
        {
            public Sneaker(string brand, string model, decimal price) : base(brand, model, price) { }

            public override decimal CalculateFinalPrice(int quantity)
            {
                return (BasePrice - 10.00m) * quantity;
            }
        }

        // Another special type of shoe that adds a premium fee
        public class FormalShoe : Shoe
        {
            public FormalShoe(string brand, string model, decimal price) : base(brand, model, price) { }

            public override decimal CalculateFinalPrice(int quantity)
            {
                return (BasePrice - 50.00m) * quantity;
            }
        }
    }
}
