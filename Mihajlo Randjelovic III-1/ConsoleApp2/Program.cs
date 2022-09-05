using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            System.Console.Write("A=");
            a = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("B=");
            b = Convert.ToInt32(System.Console.ReadLine());
            c = a + b;
            System.Console.WriteLine("a+b=" + c);
            System.Console.ReadLine();
        }
    }
}
