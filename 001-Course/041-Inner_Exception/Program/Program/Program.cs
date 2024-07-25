// Inner Exception

/*
>>>> Inner Exception
        The Inner Exception property returns the Exception instance that caused the current Exception.

        To retain the original exception pass it as a parameter to the constructor of the current exception.
        
        Always check if inner exception is not null before accessing any property of the inner exception object, else you may get Null Reference Exception.
        
        To get the type of the Inner Exception use GetType() method.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;
using System.Data.SqlTypes;
class Program
{
    static void Main()
    {
        try
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;

                Console.WriteLine("Result is {0}", result);
            }
            catch (Exception ex)
            {
                string filePath = "log.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a Problem, Please try later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + " is not present", ex);
                }

            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
        }


    }
}
