using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();
            

            Console.WriteLine("Name:");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets try the game...", inputName); 

            while (true) {

            Random random = new Random();

            int correctNumber = random.Next(1,10);

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNumber) 
            { 
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Insert an actual number");
                    Console.ResetColor();
                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong Number");
                    Console.ResetColor();
                }

            }
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CORRECT Number");
            Console.ResetColor();

            Console.WriteLine("Play Again? Y or N");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                } 
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David Maldonado";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
    }
}