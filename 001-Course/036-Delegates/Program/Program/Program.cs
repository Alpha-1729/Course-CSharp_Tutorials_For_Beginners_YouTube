// Delegates

/*
>>>> Delegates
        Delegae is a type safe function pointer. That is, it holds a reference (Pointer) to a function.

        The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get a compiler error. This is the reason delegates are called as type safe function pointers.
        
        A Delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name as parameter to the delegate constructor, and it is to this function the delegate will point to.

        Delegate syntax look very much similar to a method with a delegate keyword.
        Delegates are reference type.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;

public delegate void HelloFunctionDelegate(string message);
class Program
{
    static void Main() 
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegate");
    }

    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }
}
