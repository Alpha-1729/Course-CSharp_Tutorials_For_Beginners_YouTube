// Builtin Types

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
        // Boolean datatype.
        // Boolean variable can only hold true or false.
        bool isMale = true;

        // Integral datatype.
        // Refer the screenshot attached.
        // Printing the min and max value of the integer datatype.
        Console.WriteLine("Min value for integer is {0}", int.MinValue);
        Console.WriteLine("Max value for integer is {0}", int.MaxValue);

        // Floating datatype.
        double profit = 21424.24125;
        Console.WriteLine(profit);

        // Decimal datatype.
        // Decimal datatype have greater precision than the float and double.
        float moey = 123.33F;
        decimal loss = 21424.241252334;
    }
}
