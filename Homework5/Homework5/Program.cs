using System;
using System.Collections.Generic;
using System.IO;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abdessattar Karim

            string[] CustomerNames = new string[1000];
            double[] AccountBalances = new double[1000];

            string[] nameLines = File.ReadAllLines("CustomerNames.csv");
            string[] balancesLines = File.ReadAllLines("AccountBalances.csv");

            for (int i = 1; i < nameLines.Length; i++)
            {

                if (string.IsNullOrWhiteSpace(nameLines[i]) == true)
                {
                    continue;
                }

               
                CustomerNames[i - 1] = nameLines[i];

                string balance = balancesLines[i];
                balance = balance.Replace("$", " ");
                AccountBalances[i - 1] =Convert.ToDouble (balance);


                }
                Console.WriteLine("Whose account do you want to look up?");
                foreach (string name in CustomerNames)
                {
                    Console.WriteLine(name);
                }
                string answer = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < CustomerNames.Length; i++)
                {
                    if (answer.ToLower()== CustomerNames[i].ToLower())
                    {
                        Console.WriteLine($"{answer} has a balance of {AccountBalances[i].ToString("C")}");
                    }
                }

            }
            
            

        }
    }
