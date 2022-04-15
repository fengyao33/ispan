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
            short a;
            a = 2000;
            int amount = 200000;
            long count = 20000000000000;
            uint aa = 54545; //+u=無正負號

            Console.WriteLine("short整數宣告A= " + a);
            Console.WriteLine("int amount= " + amount);
            Console.WriteLine("long count= " + count);
            Console.WriteLine("uint aa= " + aa);


            //浮點數
            float average = 888.55f;
            double pi = 3.1415;
            Console.WriteLine($"平均:{average}\n圓周率{pi}");
            //布林
            bool isSuccess = true;
            bool isFinish = false;
            Console.WriteLine($"是否成功:{isSuccess}\n是否完成{isFinish}");
            //字串
            string name = "王大維";
            string 電話 = "0933-333-333";
            string mail = "QQQ@QQ";
            Console.WriteLine($"姓名{name}電話{電話}");
            //字元 char
            char myCharOne = 'X';
            char myCharTwo = '豐';
            Console.WriteLine($"字元輸出:{myCharOne}{myCharTwo}");
            //字串插入
            Console.WriteLine("姓名:{0} 電話{1} mail{2}", name, 電話, mail);
            //變數插入
            Console.WriteLine($"名{name}電話{電話}");

            Console.WriteLine("\n任意鍵結束");
            Console.ReadKey();


           

           



            
            
            
            


           Console.ReadLine();

        }
    }
}
