using System;

class Program
{
    static void Main()
    {
        // ---- Aktive Aufgabe hier aufrufen ----
        
        // SagHalloZu("Maria!");
        // SagHalloZu("Alibaba!");
        // SagHalloZu("Max!");
        // SchreibeErgebnis(VerdoppleZahl(5));
        TemperaturProgramm();
    }

    #region Demo Methoden
    static void SagHallo()
    {
        // Hallo Welt.
        {
            Console.WriteLine("Hallo Welt! Ich Liebe Pizza!");
        }
    }

    static void SagHalloZu(string name)
    {
        Console.WriteLine($"Hallo {name}!");
        // Console.WriteLine("Hallo, " + name);
    }


    static int VerdoppleZahl(int x)
    {
        return x * 2;
    }


    static int Addiere(int a, int b)
    {
        return a + b;
    }

    static void SchreibeErgebnis(int wert)
    {
        Console.WriteLine($"Das Ergebnis ist: {wert}");
    }
    #endregion

    #region Temperatur (Aufgabe)
    static double LiesTemperatur()
    {
        while (true)
        {
            Console.Write("Temperatur in °C eingeben: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x))
                return x;

            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double CelsiusZuFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static void TemperaturBewertung(double celsius)
    {
        if (celsius < 0) Console.WriteLine("Es ist sehr kalt!");
        else if (celsius > 30) Console.WriteLine("Es ist heiß!");
        else Console.WriteLine("Das Wetter ist angenehm.");
    }

    static void TemperaturProgramm()
    {
        double celsius = LiesTemperatur();
        double fahrenheit = CelsiusZuFahrenheit(celsius);

        Console.WriteLine($"{celsius:F1}°C sind {fahrenheit:F1}°F");
        TemperaturBewertung(celsius);
    }

    #endregion
}
