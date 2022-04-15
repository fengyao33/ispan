using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice2
{
    class Program
    {
        static void Main(string[] args)
        {


            //int x = 156, y = 1565, z = 882;
            //int[] g = { x, y, z };
            //Array.Sort(g);



            //Console.WriteLine($"你輸入的值{g[0]}<{g[1]}<{g[2]}");
            ////Console.ReadLine();

            Console.WriteLine("pratice2 三角形 菱形");

            Console.Write("5星數量：");
            int a = Convert.ToInt32(Console.ReadLine());
           

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j < a - i + 1; j++) //輸出空格
                {
                    Console.Write(" ");
                }
                for (int t = a; t > a - i; t--) // 輸出星號
                {
                    Console.Write("*");
                }
                Console.Write("\n"); //換行
            }
            

            Console.ReadKey();
            //★

           






        }
    }
}
