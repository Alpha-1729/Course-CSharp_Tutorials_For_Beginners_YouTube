// Switch Statement

/*
>>>> Swtich statement.
        It is an alternative to the multiple if else statements.
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
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Your number is not between 1 and 3");
                break;
        }

        // Grouping multiple case statement.
        switch (number)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Your number is 1 2 or 3");
                break;
            default:
                Console.WriteLine("Your number is not 1 2 and 3");
                break;
        }
    }
}
