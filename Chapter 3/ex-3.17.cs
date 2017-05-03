using System;

/*
 * Exercise 3.17
 * Answers by Fabio Pedruci
 * Write an app that inputs three integers from the user and displays the sum, average, product,
   and smallest and largest of the numbers.
   [Note: The average calculation in this exercise should result in an integer representation
   of the average. So, if the sum of the values is 7, the average should be 2, not 2.3333….]
*/

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, smallest, largest; //In a more complex problem, we should initialize the variables.

        //There are several ways of compare the numbers. We will compare them after the 'ReadLine' method.
        Console.Write("Please, insert first number: ");
        num1 = int.Parse(Console.ReadLine());
        smallest = num1;
        largest = num1;
        Console.Write("Please, insert second number: ");
        num2 = int.Parse(Console.ReadLine());
        if(num2 > largest)
        {
            largest = num2;
        }
        else if (num2 < smallest)
        {
            smallest = num2;
        }
        Console.Write("Please, insert third number: ");
        num3 = int.Parse(Console.ReadLine());
        if (num3 > largest)
        {
            largest = num3;
        }
        else if (num3 < smallest)
        {
            smallest = num3;
        }

        Console.WriteLine("The sum is: {0}", num1 + num2 + num3);
        Console.WriteLine("The average is: {0}", (num1 + num2 + num3) / 3);
        Console.WriteLine("The product is: {0}", num1 * num2 * num3);
        Console.WriteLine("The smallest is: {0}", smallest);
        Console.WriteLine("The largest is: {0}", largest);
    }
}

