using System;

/*
 * Exercise 3.16
 * Answers by Fabio Pedruci
 * Write an app that asks the user to enter two integers, obtains them
   from the user and displays the larger number followed by the words "is larger". 
   If the numbers are equal, display the message "These numbers are equal."
*/


class Program
{
    static void Main(string[] args)
    {
        int num1, num2; //In a more complex problem, we should initialize the variables.
        Console.Write("Please, insert first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please, insert second number: ");
        num2 = int.Parse(Console.ReadLine());

        //There are several ways to do the comparison. The Chapter 3 use only if statements, but we can use if...else.
        if (num1 > num2)
        {
            Console.WriteLine("{0} is larger.", num1);
        }
        if (num2 > num1)
        {
            Console.WriteLine("{0} is larger.", num2);
        }
        if (num1 == num2)
        {
            Console.WriteLine("These numbers are equal.");
        }
    }
}

