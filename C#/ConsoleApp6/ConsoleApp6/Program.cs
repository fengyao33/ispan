using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 迴圈
            while (true)
            {
                Console.WriteLine("hello world");
                break;
            }
            Console.WriteLine("_______________");

            int d = 1;
            while (d <= 10) 
            {
                    Console.WriteLine($"d:{d}");
                d += 1;
            }
            Console.WriteLine("_______________");
            //do .. while 迴圈 至少執行一次
            do
            {
                Console.WriteLine("Hello world");
            } while (false);





            Console.ReadLine();

        }
    }
}
