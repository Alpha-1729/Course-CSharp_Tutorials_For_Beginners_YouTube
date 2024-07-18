// Properties Continues

/*
>>>> Properties
        In C# to encapsulate and protect fields we use properties.
        1. We use get and set accessors to implement properties.
        2. A property with both get and set accessor is a Read/Write property.
        3. A property with only get accessors is a Read only property.
        4. A property with only set accessors is a Write only property.
        5. The advantage of properties over traditional Get() and Set() methods is that, you can access the, as if they were public fields.
>>>> Auto Implemented Properties.
        If there is no additional logic in the property accessors, then we can make use of auto-implemented properties introduced in C# 3.0.

        Auto-implemented properties reduce the amount of code that we have to write.
        When you use auto-implemented properties, the compiler creates a private, anonymous field that can only be accessed through the property's get and set accessors.
>>>>
>>>>
>>>>
>>>>
*/

using System;

class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    // Auto implemented properties.
    public string City { get; set; }
    public string Email { get; set; }

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student Id should be positive");
            }
            this._id = value;
        }

        get
        {
            return this._id;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = value;
        }
        get
        {
            return this._name;
        }
    }
}

class Program
{
    static void Main()
    {
        Student S1 = new Student();
        S1.Name = "Sam";
        S1.Id = 101;

        Console.WriteLine("Student Id = {0}", S1.Id);
        Console.WriteLine("Student Name = {0}", S1.Name);
        Console.WriteLine("passMark = {0}", S1.PassMark);
    }
}
