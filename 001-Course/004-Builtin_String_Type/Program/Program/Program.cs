// Builtin String Type

/*
>>>>
>>>>
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
        // String datatype.
        string name = "James";
        Console.WriteLine(name);

        // Escape sequences.
        Console.WriteLine("Jame\"s Dog");

        // Verbatim string literal.
        // Verbatim literal is a string with an @ symbol prefix.
        // Verbatim literals make escape sequences as normal printable characters to enhance readability.
        // @ is known as a verbatim identifier.
        string path = @"C:\Program\DotNet";

    }
}
