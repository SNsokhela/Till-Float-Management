using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to read my text file
            string filePath = @"C:\Users\DELL\source\repos\myproject\input.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine();
            }

            //Code to split my lines in arrays
            string foo = Console.ReadLine();
            string[] tokens = foo.Split(",");
            List<int> nums = new List<int>();
            int oneNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }

            Console.ReadLine();
        }
    }
    
}
