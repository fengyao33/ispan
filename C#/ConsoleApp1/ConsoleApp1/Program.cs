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
            Console.WriteLine("省略寫法");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("測試上方顏色變換");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //黃色是函式庫(api)  橘色字串  藍綠色(console)類別  
            //WriteLine 獨佔一行 ()可空白輸出
            //foregroundcolor=屬性  consolecolor列舉
            Console.WriteLine("特殊字元代碼");
            Console.WriteLine("\"雙引號\""); //  \+符號 可輸出
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t縮排");
            Console.WriteLine("\n換行");

            Console.WriteLine("按Enter結束程式");
            System.Console.ReadLine();
        }
    }
}
