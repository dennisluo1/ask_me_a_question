using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ask_me_a_question
{
    /// <summary>
    /// Entry point for 'Ask Me a Question' program (By: Dennis Luo)
    /// </summary>
    class Program
    {
        // static string theQuestion, theAnswer;
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

                GetAnswerFromUser(theQuestion);
            }

            
            // Original color 
            Console.ForegroundColor = origColor;
        }

        /// <summary>
        /// Print the name of program and author
        /// To console
        /// </summary>
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

        // Get answer for user
        static void  GetAnswerFromUser(string theQuestion)
        {
            if (theQuestion.Length == 0)
            {
                Console.WriteLine("Please type a question :) ");
                return;
            }
            if (theQuestion.ToLower() == "quit")
            {
                break;
            }

            // Insults & slurs will exit program
            if (theQuestion.ToLower() == "you suck")
            {
                Console.WriteLine("You suck even more! Exiting program...BYE");
                break;
            }
            // Get random number
            int randomNum = randomObj.Next(4);

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

    }
}
