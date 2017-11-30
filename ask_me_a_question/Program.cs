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
        static void Main(string[] args)
        {
            // Leave the original console text color
            ConsoleColor origColor = Console.ForegroundColor;

            programInfo();

            // Original color 
            Console.ForegroundColor = origColor;
        }

        /// <summary>
        /// Print the name of program and author
        /// To console
        /// </summary>
        static void programInfo()
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
        }
    }
}
