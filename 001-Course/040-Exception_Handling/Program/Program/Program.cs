// Exception Handling

/*
>>>> Exception handling
        An exception is an unforeseen error that occurs when a program is running.
        
        Example.
            Trying to read from a file that does not exist, throws FileNotFoundException.
            Trying to read from a database table that does not exist, throws a SqlException.
        
        Showing actual unhandled exceptions to the end user is bad for two reasons.
        1. Users will be annoyed as they are cryptic and does not make such sense to the end users.
        2. Exceptions contain information, that can be used for hacking into your application.

        An exception is actually a class that derives from System.Exception class. The System.Exception class has several useful properties, that provide valueable information about the exception.
            Message: Gets a message that describes the current exception.
            StackTrace: Provides the call stack to the line number in the method where the exception occured.
>>>> While adding a file in a project
        Add that file as an embedded resources in the properties of that file.
        Refer the screenshot attached.
>>>> Releasing System Resources.
        We use try, catch and finallu blocks for exception handling.
        try - The code that can possibly cause and exception will be in the try block.
        catch - Handles the exception.
        finally - Clean and free resources that the class was holding onto during the program execution. Finally block is optional.

        Note - It is a good practice to always release resources in the finally block, because finally block is guaranteed to execute, irrespective of whether there is an exception or not.
        
        Specific exceptions will be caught before the base general exception, so specific exception blocks should always be on top of the base exception block. Otherwise, you will encounter a compiler error.
>>>> Why finally block is needed.
        If any exception occur inside the catch block, all the code below it will not work.
            If we use an if block instead of finally, that if block will not work because of the exception inside the catch block.
        If we have a finally block, it will surely will exceute even if we have an exception inside the catch block.
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            // Reading a file.
            streamReader = new StreamReader("data_1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        } 
        catch (FileNotFoundException ex)
        {

            Console.WriteLine(ex.FileName + "\n\n");
            Console.WriteLine(ex.Message + "\n\n");
            Console.WriteLine(ex.StackTrace + "\n\n");
            Console.WriteLine("Please check if the file {0} exists", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
        }

    }
}
