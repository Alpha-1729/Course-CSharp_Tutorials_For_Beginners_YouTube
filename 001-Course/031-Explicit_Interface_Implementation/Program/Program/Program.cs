// Explicit Interface Implementation

/*
>>>> Explicit interface implementation.
        A class inherits from 2 interfaces and both the interfaces have the same method name. How should the class implement the method for both the interfaces?
        
        We are using Explicit Interface Implementation technique to solve this problem.

        When a class explicitly implements, an interface member, the interface member can no longer be accessed through class reference variable, but only through the interface reference variable.

        Access modifiers are not allowed on explicitly implemented interface members.
        
>>>> Default and explicit implementation.
        If you want to make one of the interface method, the default, then implement that method normally and the other interface method explicitly. This makes the default method to be accessible through class instance.
>>>>
>>>>
>>>>
>>>>
*/

using System;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

interface I3
{
    void InterfaceMethod();
}
class Program : I1, I2, I3
{
    // Explicitly implementing an interface.
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 Interface Method");
    }

    // Implementing this interface method normally.
    public void InterfaceMethod()
    {
        Console.WriteLine("I3 Interface Method");
    }
    static void Main()
    {
        Program P = new Program();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
        P.InterfaceMethod();

        // OR
        I1 i1 = new Program();
        I2 i2 = new Program();
        I3 i3 = new Program();

        i1.InterfaceMethod();
        i2.InterfaceMethod();
        i3.InterfaceMethod();

    }
}
