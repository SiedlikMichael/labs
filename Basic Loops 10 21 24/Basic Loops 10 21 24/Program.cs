using System;

class Program
{
    static void Main()
    {
        const string correctCode = "13579"; // the correct password
        const int maxAttempts = 5; // max attempts
        int attempts = 0; 
        bool isLocked = true; // you walk up to the door, its locked..

        while (isLocked && attempts < maxAttempts)
        {
            Console.Write("Enter password");
            string userInput = Console.ReadLine(); // Read user input
            attempts++; //attempt counter..duh

            if (userInput == correctCode)
            {
                isLocked = false; // Unlock the door
                Console.WriteLine("BINGO!!!! The door is now unlocked.");
            }
            else if (attempts < maxAttempts)
            {
                Console.WriteLine("WRONG!!!!!try again.");
            }
        }

        if (isLocked)
        {
            Console.WriteLine("TO MANY ATTEMPTS!  Access denied!");
        }
    }
}