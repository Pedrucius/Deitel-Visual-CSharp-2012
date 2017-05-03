using System;

/*
 * Exercise 3.27
 * Answers by Fabio Pedruci
 * write an app that displays the integer equivalents of some uppercase letters, 
   lowercase letters, digits and special symbols. Display the integer equivalents 
   of the following: A B C a b c 0 1 2 $ * + / and the space character.
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The character {0} has the value: {1}", 'A', (int)'A');
        Console.WriteLine("The character {0} has the value: {1}", 'B', (int)'B');
        Console.WriteLine("The character {0} has the value: {1}", 'C', (int)'C');
        Console.WriteLine("The character {0} has the value: {1}", 'a', (int)'a');
        Console.WriteLine("The character {0} has the value: {1}", 'b', (int)'b');
        Console.WriteLine("The character {0} has the value: {1}", 'c', (int)'c');
        Console.WriteLine("The character {0} has the value: {1}", '0', (int)'0');
        Console.WriteLine("The character {0} has the value: {1}", '1', (int)'1');
        Console.WriteLine("The character {0} has the value: {1}", '2', (int)'2');
        Console.WriteLine("The character {0} has the value: {1}", '$', (int)'$');
        Console.WriteLine("The character {0} has the value: {1}", '*', (int)'*');
        Console.WriteLine("The character {0} has the value: {1}", '+', (int)'+');
        Console.WriteLine("The character {0} has the value: {1}", '/', (int)'/');
        Console.WriteLine("The character {0} has the value: {1}", ' ', (int)' ');
    }
}