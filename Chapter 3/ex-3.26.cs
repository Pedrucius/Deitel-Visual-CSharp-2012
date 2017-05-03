using System;

/*
 * Exercise 3.26
 * Answers by Fabio Pedruci
 * Write an app that inputs from the user the radius of a circle
   as an integer and displays the circle’s diameter, circumference and area using the floating-point value
   3.14159 for π. In this exercise we will use the constant PI from class 'math'.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert the radius of the circle (integer): ");
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine("The diameter of the circle is: {0}", 2 * radius);
        Console.WriteLine("The circumference of the circle is: {0}", 2 * Math.PI * radius);
        Console.WriteLine("The area of the circle is: {0}", (radius * radius) * Math.PI);
    }
}

