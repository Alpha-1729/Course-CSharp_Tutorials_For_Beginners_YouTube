// For And For Each Loop

/*
>>>> For each loop.
        It is used to iterate through the items in a collection.
        It can be used with arrays or collection such as ArrayList, HashTable and Generics.
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
        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 2;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // For each loop.
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
