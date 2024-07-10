// While Loops

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
        Console.Write("Enter the target number: ");
        int target = int.Parse(Console.ReadLine());

        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }
}
