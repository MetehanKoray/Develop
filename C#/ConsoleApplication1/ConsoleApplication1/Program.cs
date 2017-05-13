using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("1.sayı ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayı ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine("1.sayı büyük");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("2.sayı büyük");
            }
            else
            {
                Console.WriteLine("3.sayı büyük");
            }
            Console.ReadLine();
        }
    }
}
