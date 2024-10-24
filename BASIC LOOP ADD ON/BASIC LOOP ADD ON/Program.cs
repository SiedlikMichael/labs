
using System;

class Program
{
    static void Main()
    {
        const string correctCode = "13579"; //  // the correct password
        const int maxAttempts = 5; // max attempts
        int attempts = 0; // attempts
        bool isLocked = true; // you walk up to the door...its locked

        do
        {
            Console.Write("enter password");
            string userInput = Console.ReadLine(); // Read user input
            attempts++; //attempt counter

            if (userInput == correctCode)
            {
                isLocked = false; // unlock the door
                Console.WriteLine("BINGO!!!");
            }
            else if (attempts < maxAttempts)
            {
                Console.WriteLine("WRONG!!! try again.");
            }
        } while (isLocked && attempts < maxAttempts);

        if (isLocked)
        {
            Console.WriteLine("TOO MANY FAILED ATTEMPS! Access denied!");
        }
    }
}