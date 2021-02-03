using System;

namespace VariablesConversionFormatting
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName, lastName;
            double gpa;

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enetr your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your gpa>>");
            string gpastring = Console.ReadLine();
            gpa = Convert.ToDouble (gpastring);

            gpa = gpa + .5;
            string output = "Hello" + firstName + " " + lastName + "!" + "we boostd your gpa to " + gpa.ToString("N3");
            Console.WriteLine(output);
        }
    }
}
