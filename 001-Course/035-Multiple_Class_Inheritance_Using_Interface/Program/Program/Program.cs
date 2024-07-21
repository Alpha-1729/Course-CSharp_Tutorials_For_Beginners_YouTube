// Multiple Class Inheritance Using Interface

/*
>>>>
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;
using System.Xml.Serialization;

interface IA
{
    void AMethod();
}

class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
interface IB
{
    void BMethod();
}

class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

// Inheriting from class A and class B using interface.
class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}
class Program
{
    static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}
