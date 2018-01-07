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
            Console.WriteLine("init");
            Console.WriteLine(add(1, 2));
            Console.WriteLine(minus(1, 2));
            Console.WriteLine(multiply(1, 2));
            Console.WriteLine(devide(8, 2));
            Console.Read();
            //config add but i don't want to add in conifg
            //master branch
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
        static int add(int a, int b)
        {
            return a + b;
        }
        
        static int multiply(int a, int b)
        {
            return a * b;
        }
        static int devide(int a, int b)
        {
            return a / b;
        }
        
    }
}
