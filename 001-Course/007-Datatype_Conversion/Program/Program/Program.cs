// Datatype Conversion\

/*
>>>> Implicit conversion
        It is done by compiler.
        When there is no loss of information if the conversion is done.
        If there is no possibility of throwing exceptions during the conversion.
        Eg: Converting an int to float will not loose any data and no exception will be thrown, hence and implicit conversion can be done.

>>>> Explicit conversion
        When converting a float to an int, we loose the fractional part and also a possibility of overflow exception. Hence, in this case an explicit conversion is required. For explicit conversion we can use cast operator or the convert class in C#.
>>>> Difference between Parse and TryParse.
        If the number is in a string format you have 2 options - Parse() and TryParse().
        Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed.
        Use Parse() if you are sure the value will be valid, otherwise use TryParse().
>>>>
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        float money = 3232.2324F;

        // Explicit conversion.
        // If we use the typecas operator for converting large float value, no exceptions will be thrown.
        // If we use the Convert class for converting large float value, integer overflow exception will be thrown.
        int balance = (int)money;  // Using the typecast operator.
        int profit = Convert.ToInt32(money);  // Using the convert class in C#.

        // Converting string to integer - not fail safe.
        string strNumber = "2123";
        int number = int.Parse(strNumber);

        // Convert string to integer - fail safe.
        strNumber = "23234D";
        int result = 0;
        // If the conversion is successfull, new value will be assigned to result variable.
        // TryParse will return true if conversion is successful, else false.
        bool isConversionSuccessful = int.TryParse(strNumber, out result);


    }
}
