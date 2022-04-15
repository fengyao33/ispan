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
            do
            {
                Console.WriteLine("輸入");
                int key = Convert.ToInt32(Console.Read());
                if (key > 5000)
                    Console.WriteLine($"{key}太大");
                else if (key < 500)
                    Console.WriteLine($"{key}太小");
                else
                {
                    Console.WriteLine($"{key}對");
                    guess
                    

                }





            }

        }
    }
}
