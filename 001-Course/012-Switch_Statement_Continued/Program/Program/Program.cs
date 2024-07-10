// Switch Statement Continued

/*
>>>> Go to statement.
        You can either jump to another case statement, or to a specific label.
        Warning: Using goto is a bad programming style. We should avoid goto by all means.
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
        int totalCoffeeCost = 0;

    Start:
        Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                totalCoffeeCost += 1;
                break;
            case 2:
                totalCoffeeCost += 2;
                break;
            case 3:
                totalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid", userChoice);
                goto Start;
        }

    Decide:
        Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        string userDecision = Console.ReadLine();

        switch (userDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Please try gain...", userDecision);
                goto Decide;
        }

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("bill Amount = {0}", totalCoffeeCost);


        // Using goto with case statement to jump from one case to another.
        int input = 1;
        switch (input)
        {
            case 1:
                Console.WriteLine("One");
                goto case 2;
            case 2:
                Console.WriteLine("Two");
                goto case 3;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                break;
        }
    }
}
