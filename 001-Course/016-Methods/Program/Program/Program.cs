// Methods

/*
>>>> Methods
        Methods are also called as functions.
        Methods make the maintenance of your application easier.
>>>> Static and Instance method.
        When a method declaration includes a static modifier, that method is said to be a static method.
        When no static modifier is present, the method is said to be an instance method.

        Static method is invoked using the class name, whereas an instance method is invoked using an insance of the class.

        The difference between instance methods and satic methods is that multiple instances of a class can be created (or instantiated) and each instance has its own separate method. However, when a method is staticm there are no instances of that method, and you can invoke only that one definition of the static method.
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
        // Calling instance method.
        Program p = new Program();
        p.EvenNumbers(20);

        // Calling static method.
        Program.OddNumbers(20);

        int result = p.Add(10, 20);
        Console.WriteLine("Sum = {0}",result);
    }
     
    public void EvenNumbers(int target)
    {
        int start = 0;
        while (start < target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }

    public static void OddNumbers(int target)
    {
        int start = 1;
        while (start < target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
