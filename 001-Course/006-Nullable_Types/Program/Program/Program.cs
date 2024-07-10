// <topic>

/*
>>>> In C#, datatypes can be divided into 2 broad categories.
        Value Types - int, float, double, structs, enums etc.
        Reference Types - Interfaces, Class, delegates, arrays etc.
>>>> By default value types are non nullable. To make them nullable use ?
        int i -> cannot be made nullable.
        int? j -> can be made nullable.
>>>> Nullable types bridge the differences between C# types and Database types.
        We can store null in any rows in a database table.
>>>>
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        // Make nullable integer.
        int? i = null;

        // Null coalescing operator.
        // If the ticketOnSale is null, zero will be assigned to availableTickets variable.
        // Else the ticketOnSale value will be assigned to availableTickets variable.
        int? ticketOnSale = 100;
        int availableTickets = ticketOnSale ?? 0;

        // Getting the actual value from the nullable value type.
        int ticketCount = ticketOnSale.Value;
    }
}
