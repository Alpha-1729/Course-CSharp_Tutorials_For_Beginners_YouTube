// Do While Loop

/*
>>>> Do While Loop
        A do while loop checks its condition at the end of the loop.
        This means that the do while loop is guaranteed to execute atleast one time.
        Do while loops are used to present a menu to the user.
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
        string userChoice = string.Empty;

        do
        {
            Console.WriteLine("Please enter your target?");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start < userTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");
                userChoice = Console.ReadLine().ToUpper();
                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice, please say Yes or No");
                }
            } while (userChoice != "YES" && userChoice != "NO");

        } while (userChoice == "YES");
    }
}
