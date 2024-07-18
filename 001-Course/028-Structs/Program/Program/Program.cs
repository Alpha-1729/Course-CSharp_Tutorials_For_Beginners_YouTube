// Structs

/*
>>>> Structs
        Just like classes structs can have
        Private Fields.
        Public Properties.
        Constructors.
        Methods.
        
        Object initializer syntac instroduced in C# 3.0 can be used to initialize either a struct or a class.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;

public struct Customer
{
    private int _id;
    private string _name;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }
}
class Program
{
    static void Main()
    {
        Customer C1 = new Customer(101, "Mark");
        C1.PrintDetails();

        Customer C2 = new Customer();
        C2.Id = 102;
        C2.Name = "Peter";
        C2.PrintDetails();

        // Object initializer syntax.
        Customer C3 = new Customer() 
        {
            Id = 103,
            Name = "Sam"
        };
        C3.PrintDetails(); 
    }
}
