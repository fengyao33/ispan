using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //算術運算子
            int x = 9;
            int y = 4;
            int z;
            z = x + y;
            z = x * y;
            z = x % y;
            z = x + y * y;
            z = (x + y) / y;

            int x2 = 5;
            double y2 = 1.65656;
            double z2;
            z2 = x2 * y2;//
            Console.WriteLine("z2值為" + z2);
            Console.WriteLine("-----------------------");
            //算術指定運算子
            int c = 250 ,d= 500, e=55, f=656, g=888 ;
            c += 3;
            d *= 3;
            f /= 3;
            c += d;
            Console.WriteLine($"C={c}d={d}f={f}");
            Console.WriteLine("-----------------------");
            //遞增遞減運算子
            int xx = 8;
            xx++;
            Console.WriteLine(xx);
            //關係運算子
            double m = 85.23;
            double n = 45.64;
            bool v = m == n;
            //m != n;
            //m < +n;

            //複合關西運算式
            float p = 56.78f;
            float w = 92.31f;
            bool logic;
            logic = p < w && p >= 50.0f;//and
            logic = p!=w || p!=2*w;


            Console.WriteLine("logic: "+ logic);

            Console.WriteLine("-----------------------");

            Console.WriteLine();
            

            

            Console.WriteLine("案任意鍵結束");
            Console.ReadKey();
        }
    }
}
