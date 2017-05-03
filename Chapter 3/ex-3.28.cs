using System;

/*
 * Exercise 3.28
 * Answers by Fabio Pedruci
 * Write an app that inputs one number consisting of five digits from
   the user, separates the number into its individual digits and displays 
   the digits separated from one another by three spaces each.
*/


class Program
{
    static void Main(string[] args)
    {
        //The numbers follows: num0 for the smallest, num4 for the largest
        int num0, num1, num2, num3, num4; //For more complex problems, we should initialize the variables.
        Console.Write("Please insert a five digits number: ");
        int number = int.Parse(Console.ReadLine());

        num0 = number % 10;
        num1 = (number % 100) / 10;
        num2 = (number % 1000) / 100;
        num3 = (number % 10000) / 1000;
        num4 = (number % 100000) / 10000;

        Console.WriteLine("{0} {1} {2} {3} {4}", num4, num3, num2, num1, num0);

        /*
        You can also do:
        num0 = number % 10;
        number /= 10; //divide number by 10 and replace value in the same variable
        num1 = number % 10;
        number /= 10;
        num2 = number % 10;
        number /= 10;
        num3 = number % 10;
        number /= 10;
        num4 = number % 10;
        */
    }
}