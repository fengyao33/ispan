using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("hi+ " + (i * 50));

            }
            for (int x = 2; x <= 10; x += 2)
            {
                Console.WriteLine(x);
            }
            for (int x = 10; x >= 1; x += -1)
            {
                Console.WriteLine(x);//10-1
            }


            for (int i = 0; i < 50000; i++)
            {
                if (i > 9) 
                {
                    break; //迴圈中斷
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("==========================================");
            for (int i = 0; i < 20; i++)
            {
                if (i == 8)
                {
                    continue;//跳過此次迴圈
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("+++++++++++++++++++++++++");

            for (int i = 0; i < 5; i++)
            {
               for(int j = 1; j <= 10; j += 1) 
                {
                  Console.WriteLine("*");
                }
                Console.WriteLine();  
            }

            Console.WriteLine("+++++++++++++++++++++++++");

            for (int i = 1; i <= 10; i += 1) 
            {
                for (int j = 1; j <= i; j += 1) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("+++++++++++++++++++++++++");

            for (int a = 1; a <= 9; a++) 
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.Write($"{a}X{b}={a*b}"+"\t");
                }
                Console.WriteLine();
            }

            ////////練習 : 如何輸出等腰三角形 菱形
            ////////課程作業加分題 : 請輸出聖誕樹彩色有裝飾(可以任意輸入聖誕樹的高度)

            ////////for (int a = 1; a <= 10; a++) 
            ////////{
            ////////    for (int b = 1; b <= a-b; b++) 
            ////////    {
            ////////        Console.Write("*");
            ////////    }
            ////////    Console.WriteLine();
            ////////}






            Console.ReadLine();
        }
    }
}
