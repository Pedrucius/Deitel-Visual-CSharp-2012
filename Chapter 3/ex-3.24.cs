using System;

/*
 * Exercise 3.24
 * Answers by Fabio Pedruci
 * Write an app that reads an integer, then determines and displays whether
   it’s odd or even.
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert a number: ");
        int num = int.Parse(Console.ReadLine());
        if ((num % 2) == 0)
        {
            Console.WriteLine("This number is even");
        }
        else
        {
            Console.WriteLine("This number is odd");
        }
    }
}

