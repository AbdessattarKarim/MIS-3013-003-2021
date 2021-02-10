using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter your lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNbr = Convert.ToInt32(answer);

            bool isAnswerInteger = int.TryParse(answer, out luckyNbr);
            if (isAnswerInteger == false)
            {

                Console.WriteLine("not a valid number");
            }

            int remainder = luckyNbr % 7;

            if (remainder == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString ("N0")} is really a lucky number");
            }
            else if (luckyNbr % 13 == 0)
            {
                Console.WriteLine($"{ luckyNbr.ToString("N0")} is really an unlucky number") ;
            }
            else
                Console.WriteLine($"meh ... { luckyNbr.ToString("N0")} ");
        }

       Console.WriteLine("What is your first name >>");
            string name = Console.ReadLine();
        switch (name.ToLower)
	{
		case "Adam":
            Console.WriteLine("That's cool" );
 break;
        case "Derby":
            Console.WriteLine("cool but not much");
            break;

            default:
            Console.WriteLine( "cool");
            break;

	}
}
}
