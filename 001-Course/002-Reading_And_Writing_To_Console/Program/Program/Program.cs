// Reading And Writing To Console

/*
>>>>
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter you name: ");
        string userName = Console.ReadLine();

        // String concatenation.
        Console.WriteLine("Hello " + userName); 

        // Place holder syntax.
        Console.WriteLine("Hello {0}", userName);
    }
}
