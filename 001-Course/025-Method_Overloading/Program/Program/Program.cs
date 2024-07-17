// Method Overloading

/*
>>>> Method overloading.
        Function overloading and Method overloading terms are used interchangeably.

        Method overloading allows a class to have multiple methods with the same name, but with a different signature. So in C# functions can be overloaded based on the number, type(int, float etc) and kind (Value, Ref or Out) of parameters.
        The signature of a method consists of the name of the method and the type, kind (value, reference, or output) and the number of its formal parameters. The signature of a method does not include the return type and the params modifier. So, it is not possible to overload a functuion, just based on the return type or parameter modifier.
>>>> Note
        It is not possible to overload a function only based on the return type of the function or params modifier.
            It will give a compile time error.
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
        Add(2, 3, 4);
    }

    public static void Add(int num1, int num2)
    {
        Console.WriteLine("Sum = {0}", num1 + num2);
    }

    public static void Add(float num1, float num2, float num3)
    {
        Console.WriteLine("Sum = {0}", num1 + num2 + num3);
    }

    public static void Add(int num1, int num2, out int sum)
    {
        sum = num1 + num2;
        Console.WriteLine("Sum = {0}", sum);
    }

    // This will give compile time error.
    public void Product(int num1, params int[] num2)
    {
        Console.WriteLine(num1);
    }

    public void Product(int num1, int[] num2)
    {
        Console.WriteLine(num1);
    }
}
