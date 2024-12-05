// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System;


public class Example
{

    public static string RandomDigits(int length)
    {
        var random = new Random();
        string s = string.Empty;
        for (int i = 0; i < length; i++)
            s = String.Concat(s, random.Next(10).ToString());
        return s;
    }

    public static void Main()
    {
       string random = RandomDigits(9);
        Console.WriteLine(random);
    }
}
