// Difference Between Classes And Struct

/*
>>>> Classes vs Structs.
        A struct is a value type where as a class is a reference type.
        All the difference that are applicable to value types and reference types are also applicable to classes and structs.

        Structs are stored on stacks, where as classes are stored on the heap.

        Value types hold their value in memory where they are declared, but reference types holds a reference to an object in memory.

        Value types are destroyed immediately after the scope is lost, where as for reference types only the reference variable is destroyed after the scope is lost. The object is later destroyed by garbage collecor.

        When you copy a struct into another struct, a new copy of that struct gets created and modifications on one struct will not affect the values contained by the other struct.

        When you copy a class into another class, we only get a copy of the reference variable. Both the reference variable point to the same object on the heap. So operations on one variable will affect the values contained by the other reference variable.
    
>>>> Value Type Example.
        builtin datatypes like int, float, boolean etc.
        Struct
        Enums
>>>> Reference Type Example.
        Classes.
        Interfaces,
        Delegates.
>>>> Structs Vs Classes.
        Structs can't have destructorsm, but classes can have destructors.
        
        Structs cannot have explicit parameter less constructor where as a class can.

        Struct can't inherit from another class where as a class can, Both structs and classes can inherit from an interface.
            Classes support both implementation and interface inheritance.
            Struct only support interface inheritance.

        Example of structs in the .NET Framework
            int(System.Int32)
            double(System.Double)

        A class or struct cannot inherit from another struct. Struct are sealed types.
            We used sealed keyword to prevent classes from being inherited.
>>>> 
>>>>
*/

using System;

// This class cant't become a parent class, because of the sealed keyword.
public sealed class Customer
{

}
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
