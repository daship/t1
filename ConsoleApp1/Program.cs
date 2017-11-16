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
            Console.Write("init");
            Console.WriteLine(add(1, 2));
            Console.Read();
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        
    }
}
