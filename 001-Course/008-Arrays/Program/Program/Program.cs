// Arrays

/*
>>>> Arrays
        Arrays is a collection of similar data types.
>>>> Advantages:
        Arrays are strongly typed.
>>>> Diadvantages:
        Arrays cannot grow in size once initialized.
        Have to rely on integral indices to store or retrieve items from the array.
>>>>
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        int[] evenNumbers = new int[3];
        evenNumbers[0] = 2;
        evenNumbers[1] = 4;
        evenNumbers[2] = 6;
        Console.WriteLine(evenNumbers[2]);
    }
}
