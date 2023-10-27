using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kaspersky_SafeBoard_C_Sharp_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] URLs = Console.ReadLine().Split();
            List<string> HEXs = new List<string>();
            foreach (string URL in URLs)
            {
                string[] slice = URL.Split('/');
                if (slice.Count() > 2)
                {
                    slice = slice.Where(n => Regex.IsMatch(n, @"[A-F][0-9A-F]{7}")).ToArray();
                    if (slice.Count() == 1 && !HEXs.Contains(slice[0]) && URL.Contains("/" + slice[0] + "/"))
                        HEXs.Add(slice[0]);
                }
            }
            Console.WriteLine(HEXs.Count);
        }
    }
}
