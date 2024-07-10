// Common Operators

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
        // Assignment operator.
        bool isMale = true;
        bool isTall = true;

        // Arithmetic operator.
        int result = 2 + 3;

        // Comparison operator.
        bool isFive = (result == 5);

        // Conditional operator.
        bool isMaleAndTall = (isMale && isTall);

        // Ternary operator.
        bool isFemale = (isMale == true) ? false : true;

        // Null Coalescing operator (??)
        // Will be discussed in following sections.        
    }
}
