using System;

class Program
{
    static void Main(string[] args)
    {

        Random anyNumber = new Random();
        int number = anyNumber.Next(1, 101);
        int numGuess = -1;
        while (numGuess != number)
        {
            Console.Write("What is your Guess? ");
            numGuess = int.Parse(Console.ReadLine());
            if (number > numGuess)
            {
                Console.WriteLine("higher");

            }
            else if (number < numGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Your Guessed it!" );
            }
        }
        
    }
}