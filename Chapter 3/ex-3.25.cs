using System;

/*
 * Exercise 3.25
 * Answers by Fabio Pedruci
 * Write an app that reads two integers, determines whether the first is a multiple
   of the second and displays the result.
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please, insert second number: ");
        int num2 = int.Parse(Console.ReadLine());
        if ((num1 % num2) == 0)
        {
            Console.WriteLine("{0} is a multiple of {1}", num1, num2);
        }
        else
        {
            Console.WriteLine("{0} is not a multiple of {1}", num1, num2);
        }
    }
}

