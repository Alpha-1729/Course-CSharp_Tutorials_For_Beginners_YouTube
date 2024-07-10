// If Statements

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

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("One");
        }
        else if (number == 2)
        {
            Console.WriteLine("Two");
        }
        else if (number == 3)
        {
            Console.WriteLine("Three");
        }
        else
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }

        // Logical OR operator and Bitwise OR operator.
        // Logical OR operator doesnot check the second condition if the first condition is true.
        // Bitwise OR operator always check the second condition even if the first condition is true.
        if (number == 10 || number == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }
    }
}
