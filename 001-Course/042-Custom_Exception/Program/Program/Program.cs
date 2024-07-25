// Custom Exception

/*
>>>> To get the list of all exception in C#.
        Shortcut: Alt + Ctrl + E
>>>> When do you usually go for creating your own custom exceptions?
        If none of the already existing exception adequately describes the problem.
        Example.
            I have an asp.net web application.
            The application should allow the user to have only one logged in session.
            If the user is already logged in, and if he opens another browser window and tries to login again, the application should throw an error stating he is already logged in another browser window.

        With in the .NET framework we don't have any exception, that adequately describes this problem. So this scenario is one of the examples where you want to create a custom exception.
>>>> Custom Exception - Steps
        Create a class that derives from System.Exception class. As a convention, end the class name with Exception suffix. All .NET exceptions end with, exception suffix.

        Provide a public contructor, that takes in a string parameter. This constructor simply passes the string parameter, to the base exception class constructor.

        Using InnerExceptions, you can also track back the original exception. If you want this capability for your custom exception class, then overload the constructor accordingly.

        If you want your Exception class object to work across application domains, then the object must be serializable. To make your exception class serializable mark it with Serializable attribute and provide a constructor that invokes the base Exception class constructor that takes in SerializationInfo and StreamingContext object as parameters.

        Note: It is also possible to provide your own custom serialization, which will discuss in a later session.
>>>>
>>>>
>>>>
*/

using System;
using System.Runtime.Serialization;
class Program
{
    static void Main()
    {
        throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base() { }

    public UserAlreadyLoggedInException(string message) : base(message) { }

    // Constructor to include inner exception.
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException) { }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
