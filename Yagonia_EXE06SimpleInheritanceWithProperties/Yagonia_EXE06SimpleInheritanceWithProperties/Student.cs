using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_EXE06SimpleInheritanceWithProperties
{
    internal class Student
    {
        //Properties of the base class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display basic info
        public void BasicInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\n\n\n\n\n\t\t\t\t\t-----------Student Information-----------");
            Console.WriteLine($"\n\t\t\t\t\tName: {Name}, \n\t\t\t\t\tProgram: {Program}");
        }
    }

    class RegularStudent : Student //Derived Class
    {
        //Properties of the derived class
        public string Section { get; set; }
        //Method to display regular student info
        public void SectionEnrolled()
        {
            Console.WriteLine($"\t\t\t\t\tSection: {Section}");

        }
    }
    //Properities of the derived class

    //Method to display regular student info
    class IrregularStudent : Student //Derived Class
    {
        //Properities of the derived class
        public string EnrolledSemUnits { get; set; }
        //Method to display irregular student info 
        public void SemUnitsEnrolled()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\n\n\n\n\t\t\t\t\t-----------Student Information-----------");
            Console.WriteLine($"\n\t\t\t\t\tName: {Name}, \n\t\t\t\t\tProgram: {Program}, \n\t\t\t\t\tEnrolled Sem Units: {EnrolledSemUnits}");
        }
    }
}
