using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_Inheritance_with_computation
{
    internal class Shoes
    {
        public double Discount { get; set; }
        public double Price { get; set; }

        public virtual double FinalPrice
        {
            get { return Price - Discount; }
        }
    }

    class Sneakers : Shoes
    {
        public virtual double FinalPrice
        {
            get { return Price - Discount; }
        }
    }

    class Boots : Shoes
    {
        public virtual double FinalPrice
        {
            get { return Price - Discount; }
        }
    }
}
