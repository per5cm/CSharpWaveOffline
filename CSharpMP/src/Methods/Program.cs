// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Hallo Welt.
    // static void SagHallo()
    // {
    //     Console.WriteLine("Hallo Welt! Ich Liebe Pizza!");
    // }

    // static void Main(string[] args)
    // {
    //     SagHallo();
    // }

    // Hallo Zu.
    // static void SagHalloZu(string name)
    // {
    //     Console.WriteLine("Hallo, " + name);
    // }

    // static void Main(string[] args)
    // {
    //     SagHalloZu("Maria!");
    //     SagHalloZu("Alibaba!");
    //     SagHalloZu("Max!");
    // }

    // Rückgabe von Methoden
    static int VerdoppleZahl(int x)
    {
        return 2 * x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("5 verdoppelt ist: " + VerdoppleZahl(5));
        Console.WriteLine("12 verdoppelt ist: " + VerdoppleZahl(12));
    }
}