using System;
using System.Collections.Generic;

namespace InclassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gpas = new List<double>();
            List<double>itemPrices = new List<double>();

            string response = "";

            while (response!= "no")
            {
                double gpa = ValidateInputisADouble("Please enetr a gpa>>");

                gpas.Add(gpa);

                Console.WriteLine("An other gpa?");
                response = Console.ReadLine();
            }



        }
        /// <summary>
        /// Validates the user gives a double response for the question
        /// </summary>
        /// <param name="message">The question to ask the user</param>
        /// <returns> A valid double response</returns>
        static double ValidateInputisADouble(string message)
        {
            Double value;
            string answer;
            do
            {

               
                Console.WriteLine(message);
                answer = Console.ReadLine();


                bool isDouble = double.TryParse(answer, out value);
            } while (double.TryParse(answer, out value) == false);

            return value;
        }
    }
}
