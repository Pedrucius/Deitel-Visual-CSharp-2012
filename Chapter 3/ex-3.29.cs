using System;

/*
 * Exercise 3.29
 * Answers by Fabio Pedruci
 * write an app that calculates the squares and cubes of the numbers from 0 to 10 and displays
   the resulting values in table format, as shown below. All calculations should be done in terms of a
   variable x.
*/


class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        Console.WriteLine("Number\tSquare\tCube");
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
        x = x + 1; //or x++
        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
    }
}