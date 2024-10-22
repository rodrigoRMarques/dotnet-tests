//What's the output of this code? Why?

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Incremental();
        Delegate();
        Array();
    }

    public static void Incremental()
    {
        Console.WriteLine("Incremental");

        int number = 0;
        Console.WriteLine(number);
        Console.WriteLine(number++);
        Console.WriteLine(++number);
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

    public static void Array()
    {
        int[] i = new int[0];
        Console.WriteLine(i[0]);
    }
}
