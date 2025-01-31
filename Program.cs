using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> FDNumbers = new List<string>();
        string pattern = "\\b\\d{4}\\b";
        Regex regex = new Regex(pattern);
        for (int i = 0; i < 100000; i++)
        {
            string num = i.ToString();
            if (regex.IsMatch(num))
            {
                FDNumbers.Add(num);
            }
        }
        Console.WriteLine($"Task 1: {string.Join(", ", FDNumbers)}");

        //-------------------------------------------------------------------

        string pattern2 = "^[a-zA-Z]{3}\\d{3}[a-zA-Z]{3}\\d{3}$";
        Regex regex2 = new Regex(pattern2);
        string[] testLine = { "asd123zxc456", "bnm567hjk890", "09zx8c098xzc" };
        foreach (string word in testLine)
        {
            Console.WriteLine($"{word} : {regex2.IsMatch(word)}");
        }

        //-------------------------------------------------------------------

        string pattern3 = "\\b[A-Z]{3}\\b";
        Regex regex3 = new Regex(pattern3);
        string text = "as;ldkfjl DOC jlkjkjhasdgjkhfgkjsad PDF dfh RANO GJK1";
        MatchCollection matches3 = regex3.Matches(text);
        foreach (Match match in matches3)
        {
            Console.WriteLine("Task 3: " + match.Value);
        }

        //-------------------------------------------------------------------

        string pattern4 = "\\b(19\\d{2}|20\\d{2})\\b";
        Regex regex4 = new Regex(pattern4);
        string yearsText = "Years 1800 1901 20003 209 210d0";
        MatchCollection matches4 = regex4.Matches(yearsText);
        foreach (Match match in matches4)
        {
            Console.WriteLine("Task 4: " + match.Value);
        }

        //-------------------------------------------------------------------

        string pattern5 = @"\+38(\d{3})(\d{3})(\d{4})";
        Regex phoneRegex = new Regex(pattern5);
        string phones = "+380677328433, +3877777777, +38066666666";
        MatchCollection phoneMatches = phoneRegex.Matches(phones);
        foreach (Match match in phoneMatches)
        {
            Console.WriteLine("Task 5: " + match.Value);
        }
    }
}