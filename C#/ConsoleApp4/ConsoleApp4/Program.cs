using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //if ..else 條件判斷式
            int x = 50;
            int y = 55;
            
            if (x>y)
            {
                Console.WriteLine("x大於Y");
            }else
                {
                Console.WriteLine("x小於y");
                }
            //if...else 簡式  適用結果有指定值
            int w = -3;
            int s = 6;
            s= (w < 0) ? -1 : (w * 2);
            //s = 條件 ? ture : false  
            Console.WriteLine("簡式 S: " + s);

            //switch...case
            Console.WriteLine("===============================");
            Console.WriteLine("甜點選擇:(代號a:布丁,b:冰淇淋,c:奶烙,d:紅豆湯)");
            Console.WriteLine("輸入完成請按Enter");
            string ss = Console.ReadLine();

            switch (ss)
            {
                case "a":
                    Console.WriteLine("布丁 60元");
                    break;
                case "b":
                    Console.WriteLine("冰淇淋 55元");
                    break;
                case "c":
                    Console.WriteLine("奶酪 80元");
                    break;
                case "d":
                    Console.WriteLine("紅豆湯 1元");
                    break;
                default:
                    Console.WriteLine("無此產品");
                    break;
            }



            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("案任意鍵結束");
            Console.ReadKey();
        }
    }
}
