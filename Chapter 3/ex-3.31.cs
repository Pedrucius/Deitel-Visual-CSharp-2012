using System;

/*
 * Exercise 3.31
 * Answers by Fabio Pedruci
 * Create a BMI calculator app that reads the user’s weight in pounds and height in inches (or, if you
   prefer, the user’s weight in kilograms and height in meters), then calculates and displays the user’s
   body mass index. The app should also display the following information from the Department of
   Health and Human Services/National Institutes of Health so the user can evaluate his/her BMI:
    BMI VALUES
    Underweight: less than 18.5
    Normal: between 18.5 and 24.9
    Overweight: between 25 and 29.9
    Obese: 30 or greater
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert your height (meters): ");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Please insert your weight (kilograms): ");
        float weight = float.Parse(Console.ReadLine());

        //We will use the kilograms -> meters relation: BMI = weight/(height * height)
        Console.WriteLine("Your BMI is: {0}", weight / (height * height));
        Console.WriteLine("BMI VALUES");
        Console.WriteLine("Underweight: less than 18.5");
        Console.WriteLine("Normal: between 18.5 and 24.9");
        Console.WriteLine("Overweight: between 25 and 29.9");
        Console.WriteLine("Obese: 30 or greater");
    }
}