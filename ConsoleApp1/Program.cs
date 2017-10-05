using System;
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
            string input = "ace_lee_17";
            string[] arr = input.Split('_');

            int count = Convert.ToInt32(arr[1]);

            Console.WriteLine(count);

        }

        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}
