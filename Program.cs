﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupeless_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string filePath = @"folda\";
            string[] variants = { "ROBERT", "HOUSTON", "JEREMIAH", "SALAMIVENDOR", "KANDLE", "BLAKE", "RUBY", "QWERTY", "LENDY" };

            Console.WriteLine("Amount of files: ");
            int n = int.Parse(Console.ReadLine());

            List<string> usedValues = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string randomVariant = variants[random.Next(variants.Length)];
                string fileSuffix = $"{randomVariant}.txt";
                int appendix = 1;

                while (usedValues.Contains(fileSuffix))
                {
                    fileSuffix = $"{randomVariant}({appendix}).txt";
                    appendix++;
                }
                usedValues.Add(fileSuffix);
                File.Create(filePath + fileSuffix).Close();
                Console.WriteLine($"Created file: {fileSuffix}");
            }
        }
    }
}
