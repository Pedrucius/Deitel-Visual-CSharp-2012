using System;

/*
 * Exercise 3.30
 * Answers by Fabio Pedruci
 * Write an app that inputs five numbers and determines and displays the number 
   of negative numbers input, the number of positive numbers input and the number of zeros input.
*/


class Program
{
    static void Main(string[] args)
    {
        int positives = 0;
        int negatives = 0;
        int zeros = 0;
        Console.Write("Please insert first number: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            positives = positives + 1; //positives++
        }
        else if (num < 0)
        {
            negatives = negatives + 1; //negatives++
        }
        else
        {
            zeros = zeros + 1; //zeros++
        }
        Console.Write("Please insert second number: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            positives = positives + 1; //positives++
        }
        else if (num < 0)
        {
            negatives = negatives + 1; //negatives++
        }
        else
        {
            zeros = zeros + 1; //zeros++
        }
        Console.Write("Please insert third number: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            positives = positives + 1; //positives++
        }
        else if (num < 0)
        {
            negatives = negatives + 1; //negatives++
        }
        else
        {
            zeros = zeros + 1; //zeros++
        }
        Console.Write("Please insert fourth number: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            positives = positives + 1; //positives++
        }
        else if (num < 0)
        {
            negatives = negatives + 1; //negatives++
        }
        else
        {
            zeros = zeros + 1; //zeros++
        }
        Console.Write("Please insert fifth number: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            positives = positives + 1; //positives++
        }
        else if (num < 0)
        {
            negatives = negatives + 1; //negatives++
        }
        else
        {
            zeros = zeros + 1; //zeros++
        }
        Console.WriteLine("The number of positives is: {0}", positives);
        Console.WriteLine("The number of negatives is: {0}", negatives);
        Console.WriteLine("The number of zeros is: {0}", zeros);
    }
}