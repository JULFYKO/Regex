using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<string> numbers = new List<string>();
        string pattern1 = @"\b\d{4}\b";
        Regex regex1 = new Regex(pattern1);
        for (int i = 0; i < 100000; i++)
        {
            if (regex1.IsMatch(i.ToString())) numbers.Add(i.ToString());
        }
        Console.WriteLine("4-значні числа: " + string.Join(", ", numbers));

        string pattern2 = @"^[a-zA-Z]{3}\d{3}[a-zA-Z]{3}\d{3}$";
        Regex regex2 = new Regex(pattern2);
        string[] words = { "asd123zxc456", "bnm567hjk890", "09zx8c098xzc" };
        Console.WriteLine("Перевірка слів:");
        foreach (string word in words) Console.WriteLine($"{word} : {regex2.IsMatch(word)}");

        string pattern3 = @"\b[A-Z]{3}\b";
        Regex regex3 = new Regex(pattern3);
        string text = "WWW PDF RTF RTC BMP DOC";
        Console.WriteLine("Абревіатури:");
        foreach (Match match in regex3.Matches(text)) Console.WriteLine(match.Value);

        string pattern4 = @"\b(19\d{2}|20\d{2})\b";
        Regex regex4 = new Regex(pattern4);
        string years = "1900 1950 2000 2099 1899 2100";
        Console.WriteLine("Роки 1900-2099:");
        foreach (Match match in regex4.Matches(years)) Console.WriteLine(match.Value);

        string pattern5a = @"\+38-0\d{2}-\d{5}23\b";
        Regex regex5a = new Regex(pattern5a);
        string phones = "+38-067-1234567, +38-050-7654323, +38-097-0001234, +38-066-9876543";
        Console.WriteLine("Номери з '23':");
        foreach (Match match in regex5a.Matches(phones)) Console.WriteLine(match.Value);

        string pattern5b = @"\+38-0\d{2}-\d+00\d+";
        Regex regex5b = new Regex(pattern5b);
        Console.WriteLine("Номери з '00':");
        foreach (Match match in regex5b.Matches(phones)) Console.WriteLine(match.Value);
    }
}
