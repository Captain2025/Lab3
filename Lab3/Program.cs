
using System;

class Program
{
    static void First()
    {
        Second(); // можно вызвать функцию, определенную ниже
        Console.WriteLine("First done");
    }

    static void Second()
    {
        Console.WriteLine("Second done");
    }

    static void Main()
    {
        First();
    }
}