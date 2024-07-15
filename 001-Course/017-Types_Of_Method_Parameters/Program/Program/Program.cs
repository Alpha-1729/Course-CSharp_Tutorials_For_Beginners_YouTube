// Types Of Method Parameters

/*
>>>> Method parameter types.
        There are 4 different types of parameters a method can have.
        1. Value Parameteres
            Creates a copy of the parameter passed, so modifications does not affect each other.
        2. Reference Parameters
            The ref method parameter keyword on a method parameter causes a method to refer to the same variables that was passed into the method. Any change made to the parameter in the method will be reflected in that variable when control passes back to the calling method.
        3. Out Parameters
            Use when you want a method to retuen more than one value.
        4. Parameter Arrays.
            The params keyword lets you specify a method parameter that takes a variable number of arguments. You can send a comma separated list of arguments, or an array, or no arguments. Params keyword should be the last one in a method declaration, and only one params keyword id permitted in a method declaration.
>>>> Method parameter and Method argument.
        The values insides the method declaration is called method parameter.
        The actual values passed into the method is called the method arguments.
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
        // Pass by value. (Value Parameter)
        // This will not change the value of the variable i.
        int i = 0;
        Program.ValueParameterMethod(i);
        Console.WriteLine(i);

        // Pass by reference. (Reference Parameter)
        // This will change the value of the k.
        int k = 0;
        Program.ReferenceParameterMethod(ref k);
        Console.WriteLine(k);

        // Out Parameter.
        // Sum and product will be assigned to the out variables.
        int sum = 0;
        int product = 0;
        Calculate(2, 3, out sum, out product);
        Console.WriteLine("Sum = {0} and Product = {1}", sum, product);

        // Parameter Arrays.
        Program.ParamsMethod();
        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        Program.ParamsMethod(numbers);
        Program.ParamsMethod(1, 2, 3, 4, 5, 6);
    }

    public static void ValueParameterMethod(int j)
    {
        j = 101;
    }

    public static void ReferenceParameterMethod(ref int j)
    {
        j = 101;
    }

    public static void Calculate(int firstNum, int secondNum, out int sum, out int product)
    {
        sum = firstNum + secondNum;
        product = firstNum * secondNum;
    }

    // params keyword to used to make the paramter optional.
    // We can call this method with or without the parameter.
    // If the method contain multiple paramter, parameter array should be the last one in the parameter.
    // There should be only parameter array in a method.
    public static void ParamsMethod(params int[] numbers)
    {
        Console.WriteLine("There are {0} elements", numbers.Length);
        foreach (int num in numbers) 
        {
            Console.WriteLine(num);
        }
    }
}
