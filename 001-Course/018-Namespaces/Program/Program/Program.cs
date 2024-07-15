// Namespaces

/*
>>>> Why Namespaces.
        Namespaces are used to organize your programs.
        They also provide assistance in avoiding name clashes.

        Namespaces don't corresponding to file, directory or assembly names. They could be written in separate files and / or separate assemblies and still belong to the same namespace.
>>>> Namespaces can be nested in 2 ways.
        Namespace alias directive. Sometimes you may encounter a long namespace and wish to have it shorter. This could improve readability and still avoid name clashes with similarly named method.
>>>> We can resolve the ambiguity between classes using the fully qualified names or using the alias name or namespace alias directives.
>>>> Steps to create a namespace in new file.
        Create a class libraries for two namespaces mentioned in this lesson.
        Add project reference from the current project to other class libraries.
>>>> A namespace can contain
        Another namespace
        Class
        Interface
        struct
        enum
        delegate
>>>>
>>>>
*/

using System;
using PATA = ProjectA.TeamA;    // Alias directive
using PATB = ProjectA.TeamB;    // Alias directive
class Program
{
    static void Main()
    {
        // You can also use the fully qualified names instead of this.
        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}