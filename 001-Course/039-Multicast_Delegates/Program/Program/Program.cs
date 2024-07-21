// Multicast Delegates

/*
>>>> Multicast delegates.
        A multicast delegate is a delegate that has references to more than one function. When you invoke a multicast delegate, all the functions the delegate is pointing to, are invoked.
        
        There are 2 approaches to create a multicast delegate. Depending on the approach you use.
            + or += to register a method with the delegate.
            - or -= to un-register a method with the delegate.

        Note: A multicast delegate, invokes the methods in the invocation list, in the same order in which they are added.

        If the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of the last invoked method will be returned. Along the same lines, if the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.
>>>> Where do you use multicast delegates.
        Multicast delegates makes implementation of observer design a pattern very simple. Observer pattern is also called as publish/subscribe pattern.
>>>>
>>>>
>>>>
>>>>
*/

using System;
using System.Collections.Concurrent;


public delegate void SampleDelegate();
public delegate int SampleReturnDelegate();
public delegate void SampleOutDelegate(out int num);
class Program
{
    public static void Main()
    {
        // Method 1
        SampleDelegate del1, del2, del3, del4;
        del1 = new SampleDelegate(SampleMethodOne);
        del2 = new SampleDelegate(SampleMethodTwo);
        del3 = new SampleDelegate(SampleMethodThree);

        // del4 is called as multicast delegate.
        del4 = del1 + del2 + del3 - del2;
        del4();


        // Method 2
        // These functions will be invoked in the same order in which it is added.
        SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;
        del += SampleMethodThree;
        del -= SampleMethodTwo;
        del();

        // If the function is returning a value.
        SampleReturnDelegate retDelegate = new SampleReturnDelegate(SampleReturnMethodOne);
        retDelegate += SampleReturnMethodTwo;

        int delegateReturnValue = retDelegate();
        Console.WriteLine("Delegate Return Value = {0}", delegateReturnValue);

        // If the function has an out parameter.
        SampleOutDelegate outDelegate = new SampleOutDelegate(SampleOutMethodOne);
        outDelegate += SampleOutMethodTwo;

        int delegateOutParameterValue = -1;
        outDelegate(out delegateOutParameterValue);

        Console.WriteLine("DelegateOutParameterValue = {0}", delegateOutParameterValue);
    }
    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne Invoked");
    }
    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethodTwo Invoked");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree Invoked");
    }

    public static int SampleReturnMethodOne()
    {
        return 1;
    }

    public static int SampleReturnMethodTwo()
    {
        return 2;
    }
    public static void SampleOutMethodOne(out int number)
    {
        number = 1;
    }
    public static void SampleOutMethodTwo(out int number)
    {
        number = 2;
    }
}
