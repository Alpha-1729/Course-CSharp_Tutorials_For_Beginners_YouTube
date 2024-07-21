// Introduction To Interfaces

/*
>>>> Interfaces
        We create interfaces using the interface keyword. Just like classes interfaces also contain properties, methods, delegates or events, but only declarations and no implementations.

        It is a compile time error to provide implementations for any interface member.
    
        Interface members are public by default, and they don't allow explicit access modifiers.

        Interface cannot contain fields.

        If a class or a struct inherits from an interface, it must provide implementation fro all interface members. Otherwise, we get a compiler error.

        A class or a struct can inherit from more than one interface at the same time, but where as, a class cannot inherit from more than one class at the same time.

        Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation for all interface members in the entire interface inheritance chain.

        We cannot create an instance of an interface, but an interface reference variable can point to a derived class object.

        Interface Naming Convention: Interface names are prefixed with capital I.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;

interface ICustomer
{
    // Interface members are public by default.
    void Print();
}

class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("Interface print method.");
    }
}
class Program
{
    static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();

        // Interface reference variable can point to a derived class object.
        ICustomer cust = new Customer();
        cust.Print();
    }
}
