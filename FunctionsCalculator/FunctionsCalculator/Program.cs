using System;

namespace FunctionsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInormation ("A.K.","Develpoer_Info", "2/4") ;
            string again = "";
;            do
            {

            
            Console.WriteLine("What type of calculation do you want to perform?");
            string answer = Console.ReadLine();

            Console.WriteLine("What is the first value?");
            double value1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the second value?");
            double value2 = Convert.ToDouble(Console.ReadLine());

            
            if (answer.ToLower()== "add")
            {
                   double sum = Add(value1, value2);
                    Console.WriteLine(sum);
                    
                    
            }
                else if (answer.ToLower()== "subtract")
                {
                    double subtract = Subtract(value1, value2);
                    Console.WriteLine(subtract);
                }
                else if (answer.ToLower() == "multiply")
                {
                    double multiply= Multiply(value1, value2);
                    Console.WriteLine(multiply);
                }
                else
                {
                    double divide= Divide(value1, value2);
                    Console.WriteLine(divide);
                }



                Console.WriteLine("Do you want to do it again, yes or no?");
                again = Console.ReadLine();

            } while (again!= "no");
        }

        static double Add(double val1, double val2) 
        {
            double sum = val1 + val2;

            return sum;

            //return val1+val2;
        }

        static double Subtract (double val1, double val2)
        {
            double subtraction = val1 - val2;
            return subtraction;
        }

        static double Multiply(double v1, double v2) 
        {
            double multiplication = v1 * v2;
            return multiplication;
        
        }
        static double Divide( double v1, double v2)
        {
            double division = v1 / v2;
            return division;
        }

        static void DeveloperInormation (string name, string className, string dateWriting)
        {
            string DeveloperInormation = name + className + dateWriting;

            
        }
    }
}
