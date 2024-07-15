// Introduction To Classes

/*
>>>> Class
        If you want to create complex custom types,then we can make use of classes.

        A class consists of data and behaviour. Class data is represented by it's fields and behaviour is represented by its methods.
>>>> Purpose of a class constructor.
        The purpose of a class constructor is to initialize class fields.
        A class constructor is automatically called when an instance of a class is created.
        
        Constructors do not return values and always have the same name as the class.
        
        Constructors are not mandatory. If we do not provide a constructor, a default parameter less constructor is automatically provided.

        Constructors can be overloaded by the number and type of parameters.
>>>> Destuctors
        Destructors have the same name as the class with ~ symbol in front of them.
        They don't take any parameters and do not return a value.

        Destructors are places where you could put code to release any resources your class was holding during its lifetime.
        They are noramally called when the C# garbage collector decides to clean your object from memory.

        In Csharp we don't require destructors.
>>>>
>>>>
>>>>
*/

using System;

class Customer
{
    string _firstName;
    string _lastName;

    // Creating parameter less constructor and calling the parameter constructor.
    public Customer() : this("No FirstName", "No LastName")
    {

    }
    public Customer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;

    }
    public void PrintFullName()
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }

    // Destructors.
    ~Customer()
    {
        // Clean up code goes here.
    }
    class Program
    {
        static void Main()
        {
            // Create an instance of class.
            Customer C1 = new Customer("Sam", "Beno");
            C1.PrintFullName();

            Customer C2 = new Customer();
            C2.PrintFullName();
        }
    }
}
