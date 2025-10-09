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
    static void SagHalloZu(string name)
    {
        Console.WriteLine("Hallo, " + name);
    }

    static void Main(string[] args)
    {
        SagHalloZu("Maria!");
        SagHalloZu("Alibaba!");
        SagHalloZu("Max!");
    }
}