using System;

/*
 * Exercise 3.32
 * Answers by Fabio Pedruci
 * Create an app that calculates your daily driving cost, so that you can estimate how much money could be saved by car
   pooling, which also has other advantages such as reducing carbon emissions and reducing traffic
   congestion. The app should input the following information and display the user’s cost per day of
   driving to work:
    a) Total miles driven per day.
    b) Cost per gallon of gasoline (in cents).
    c) Average miles per gallon.
    d) Parking fees per day (in cents).
    e) Tolls per day (in cents).
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert the total miles driven per day: ");
        float totalMilesDriven = float.Parse(Console.ReadLine());
        Console.Write("Please insert the cost per gallon of gasoline (in cents): ");
        float costPerGallon = float.Parse(Console.ReadLine());
        Console.Write("Please insert the average miles per gallon: ");
        float milesPerGallon = float.Parse(Console.ReadLine());
        Console.Write("Please insert the parking fees per day (in cents): ");
        float parkingFees = float.Parse(Console.ReadLine());
        Console.Write("Please insert the tolls per day (in cents): ");
        float tolls = float.Parse(Console.ReadLine());

        //Calculating the daily cost inside the 'WriteLine' method:
        Console.WriteLine("Your daily cost is: {0} cents.", costPerGallon * (totalMilesDriven / milesPerGallon) + parkingFees + tolls);
    }
}