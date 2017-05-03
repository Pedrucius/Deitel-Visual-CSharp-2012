using System;

/*
 * Exercise 3.15
 * Answers by Fabio Pedruci
 * Write an app that asks the user to enter two integers, obtains them from the
   user and displays their sum, product, difference and quotient (division).
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
        Console.WriteLine("The Sum is: {0}", num1 + num2);
        Console.WriteLine("The Product is: {0}", num1 * num2);
        Console.WriteLine("The Difference is: {0}", num1 - num2);
        Console.WriteLine("The Quotient is: {0}", num1 / num2);
    }
}

