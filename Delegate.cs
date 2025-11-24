//What's the output of this code? Why?

using System;
using System.Collections.Generic;

public class Delegate   
{
    public static void Main()
    {
        Delegate();
    }

    public delegate void Printer();
    public static void Delegate()
    {
        Console.WriteLine("Delegate");
        List<Printer> printers = new List<Printer>();

        for (int i = 0; i < 10; i++)
        {
            printers.Add(delegate { Console.WriteLine(i); });
        }

        foreach (var printer in printers)
        {
            printer();
        }
    }
}
