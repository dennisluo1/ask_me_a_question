using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AskQuestion
{
    /// <summary>
    /// Entry point for 'Ask Me a Question' program (By: Dennis Luo)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Leave the original console text color
            ConsoleColor origColor = Console.ForegroundColor;

            ProgramInfo();

            // Create random object to return randomize numbers
            Random randomObj = new Random();

            while (true)
            {
                string theQuestion = GetQuestion();
                
                // Pause for 1-2 seconds before giving answer
                int secondsToSleep = randomObj.Next(2) + 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hmmm...thinking of an answer...");
                Thread.Sleep(secondsToSleep * 1000);

                if (theQuestion.Length == 0)
                {
                    Console.WriteLine("Please type a question :) ");
                    continue;
                }


                if (theQuestion.ToLower() == "quit")
                {
                    break;
                }

                // Insult & Slur
                if (IsInsultOrSlur(theQuestion)) return;
        

                // Get random number
                int randomNum = randomObj.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObj.Next(15);

                // Random number to display answer
                switch (randomNum)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Definitely NO!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You're awesome, YES!");
                            break;
                        }
                }
            }


            // Original color 
            Console.ForegroundColor = origColor;
        }

        // Print the name of program and author to console
        static void ProgramInfo()
        {
            // Console text colors for program name
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Ask ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Me ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Question ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("By: Dennis Luo ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Type 'quit' anytime to leave program");
        }

        // Will return text user types
        static string GetQuestion()
        {
            // Ask user for question and store in theQuestion variable
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ask Me a Question: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string theQuestion = Console.ReadLine();

            return theQuestion;
        }

        // Insults & Slurs
        static bool IsInsultOrSlur(string theQuestion)
        {
            // Insults & slurs will exit program
            if (IsSlur(theQuestion))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Wow, why do you gotta be so mean! Exiting program...BYE");
                return true;
            }
            return false;
        }

        // Short array of insults...have fun reading..
        static bool IsSlur(string theQuestion)
        {
            string[] slurs = new String[] { "you suck", "shut up", "you're fake"};
            return slurs.Contains(theQuestion.ToLower());
        }

    }
}
