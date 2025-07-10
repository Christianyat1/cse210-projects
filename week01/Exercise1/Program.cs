using System;

class Program
{
    static void Main(string[] args)
    {
        // This is Exercise 1
        
        Console.Write("What is your Name? ");
        string myname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {myname} {lastname}. ");
        
    }
}