using System;
class program
{
    static void Main()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            int number;
            while (true)
            {
                Console.Write($"{name} enter an input between 1 and 100");

                if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine( " wrong, enter positive input between 1 and 100");
                }
            }
            if (number % 2 != 0)
            {
                if (number < 60)
                {
                    Console.WriteLine($"{number} - odd and less than 60.");
                }
                else
                {
                    Console.WriteLine($"{number} - odd and greater than 60.");
                }
            }
            else
            {
                if (number >= 2 && number <= 24)
                {
                    Console.WriteLine("even and less than 25.");
                }
                else if (number >= 26 && number <= 60)
                {
                    Console.WriteLine("even and between 26 and 60 inclusive.");
                }
                else if (number > 60)
                {
                    Console.WriteLine($"{number} - even and greater than 60.");
                }
            }

            Console.Write( "would you like to enter another number? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                continueRunning = false;
            }
        }
    }
}