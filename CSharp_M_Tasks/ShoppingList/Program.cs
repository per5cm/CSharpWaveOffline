using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> ShoppingList = new ();

        while (true)
        {
            Console.WriteLine("Optionen einkaufsliste zu bearbeiten: 1 = hinzufügen, 2 = entfernen, 3 = anzeigen, 4 = beenden");
            string option = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (option == "1" || option == "hinzufügen")
            {
                Console.WriteLine("Artikel zum Hinzufügen eingeben: ");
                string item = Console.ReadLine()?.ToLower().Trim() ?? "";
                if(!string.IsNullOrWhiteSpace(item))
                {
                    ShoppingList.Add(item);
                    Console.WriteLine();
                    Console.WriteLine($"\"{item}\" hinzugefügt");
                }              
            }
            else if (option == "2" || option == "entfernen")
            {
                Console.WriteLine("Artikel zum Entfernen: ");
                string item = Console.ReadLine()?.ToLower().Trim() ?? "";
                Console.WriteLine();
                if (ShoppingList.Remove(item)) Console.WriteLine("Entfernt!");
                else Console.WriteLine("Nicht Gefunden!");
            }
            else if (option == "3" || option == "anzeigen")
            {
                Console.WriteLine(string.Join(", ", ShoppingList));
            }
            else if (option == "4" || option == "beenden") break;
        }
    }
}