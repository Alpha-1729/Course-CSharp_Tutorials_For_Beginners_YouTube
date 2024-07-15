// Static And Instance Class Members

/*
>>>> Static and Instance class members.
        When a class member includes a static modifier, the member is called as static member.
        When no static modifier is present the member is called as non static member or instance member.

        Static members are invoked using class name, where as instance members are invoked using instance (Objects) of the class.
        
        An instance member belongs to specific instance (Object) of a class.
        if I create 3 objects of a class, I will have 3 sets of instance members in the memory, where as there will ever be only one copy of a static member, no matter how many instances of a class are created.
>>>> Note
        Class members = fields, methods, properties, events, indexers, constructors.
>>>> Static Constructors.
        Static constructors are used to initialize static fields in a class.
        You declare a static constructor by using the keyword static in front of the constructor name.

        Static constructor is called only once, no matter how many instances you create.
        Static constructors are called before instance constructors and even before you refer to any static field of that class.
>>>>
>>>>
>>>>
*/

using System;

class Circle
{
    // This class field is marked as static to avoid creating mutiple variables while creating object of the class.
    static float _PI;
    float _radius;

    // Static Constructors.
    static Circle()
    {
        Circle._PI = 3.141F;
    }

    public Circle(int radius)
    {
        _radius = radius;
    }

    public float CalculateArea()
    {
        return Circle._PI * _radius * _radius;
    }
}
class Program
{
    static void Main()
    {
        Circle C1 = new Circle(5);
        Console.WriteLine(C1.CalculateArea());
    }
}
