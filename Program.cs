using System;

namespace SelectionStatements;

internal class SelectionStatements
{
    static void Main()
    {
        var r = new Random();
        int favNum = r.Next(1, 10);
        Console.WriteLine("Please guess a number between 1 and 3");
        int guessedNum = int.Parse(Console.ReadLine());

        
        if (guessedNum > favNum)
        {
            Console.WriteLine("Too high");
        }
        else if (guessedNum < favNum)
        {
            Console.WriteLine("Too low");
        }
        else
        {
            Console.WriteLine("Nevermind");
        }
    }
}   
