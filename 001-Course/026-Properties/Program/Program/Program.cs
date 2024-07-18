// Properties

/*
>>>> Getter and Setter methods.
        Programming languages that doesnot have properties use getter and setter methods to encapsulate and protect fields.
        As a result, we can better control on what gets assigned and returned from the fields.
        Encapsulation is one of the primary pillars of the OOP.
>>>>
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

    public int GetPassMark()
    { 
        return this._passMark;
    }

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student name cannot be null or empty");
        }
        this._name = Name;
    }

    public string GetName()
    {
        if (string.IsNullOrEmpty(this._name))
        {
            return "No Name";
        }
        return this._name;
    }

    public void SetId(int Id) 
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id must be positive");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }
}
class Program
{
    static void Main()
    {
        Student S1 = new Student();
        S1.SetId(101);

        Console.WriteLine("Student Id = {0}", S1.GetId());
        Console.WriteLine("Student Name = {0}", S1.GetName());
        Console.WriteLine("PassMark = {0}", S1.GetPassMark());
    }
}
