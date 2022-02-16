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

            //Code to write on the text file. 
            lines.Add("Till Start, Transcation Total, Paid, Change Total, Change breakdwon");
            lines.Add("R500, R54, R60, R6, R2-R2-R2");
            lines.Add("R548 , R113, R200, R87, R50-R20-R10-R5-R1-R1");
            lines.Add("R526 , R73,R100,R27, R10-R10-R5-R2");
            lines.Add("R546 ,R210, R250, R40, R20-R10-R5-R2-R1-R1-R1");
            lines.Add("R670, R286, R300, R14, R10-R2-R2");
            lines.Add("R772, R66, R66, R0, R0");
            lines.Add("R566, R79, R90, R11, R5-R5-1");
            lines.Add("R568, R76, R76, R0, R0");
            lines.Add("R4696");
            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
    
}
