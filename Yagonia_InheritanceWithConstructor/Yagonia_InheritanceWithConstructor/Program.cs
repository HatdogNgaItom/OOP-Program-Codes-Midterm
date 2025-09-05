using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jack Anthony Dolino Yagonia 
            //IT306
            //EXER 06: Simple Inheritance
            //Create an instance of the Regular Student class
            RegularStudent regularStudent = new RegularStudent("Sky Loon", "Bachelors of Informations Technology")
            {
                Name = "Sky Loon",
                Program = "Bachelors of Informations Technology",
                Section = "IT306",
            };
            //Method to display regular student info
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();

            //Create an instance of the Irregular Student class
            IrregularStudent irregularStudent = new IrregularStudent("Louis Aian Cuyos", "Bachelors of Informations Technology")
            {
                Name = "Louis Aian Cuyos",
                Program = "Bachelors of Informations Technology",
                EnrolledSemUnits = "20 units",
            };
            irregularStudent.SemUnitsEnrolled(); //Method to display irregular student info
            Console.ReadKey();
        }
    }
}
