﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ace_17";
            string[] arr = input.Split('_');

            int count = Convert.ToInt32(arr[1]);

            Console.WriteLine(add(count, count) + multify(count, 2));

            Console.Read();
        }

        public static int add(int a, int b)
        {
            return (IsOdd(a) ? a : 0) + (IsOdd(b) ? a : 0);
        }
        public static bool IsOdd(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        public static int multify(int a, int n )
        {
            return a * n;
        }
    }
}
