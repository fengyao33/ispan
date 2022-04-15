using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////做便當選單 輸入便當名稱告訴使用者有無販售多少錢
            ////建立2維陣列(string)儲存便當名與價格
            ////至少有十種便當, [20,2]//20=種便當 2=名稱價格 
            ////定義20種便當 每種2種屬性(name price)

            while (true)
            {
                Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("========好好吃便當價目表========\t");
            Console.WriteLine("================================");
            string ap = "70元", bp = "75元", cp = "80元", dp = "85元", ep = "90元", fp = "95元", gp = "100元";
            string[,] box = { { "A.雞腿飯", gp }, { "B.魯排骨飯", fp }, { "C.雞排飯", fp }, { "D.魚排飯", gp }, { "E.雞丁飯", bp }, { "F.豬肉炒飯", cp }, { "G.牛肉炒飯", gp }, { "H.羊肉炒飯", ap }, { "I.炸排骨便當", dp }, { "J.烤雞腿便當", ep } };

            for (int x = 0; x < box.GetUpperBound(0) + 1; x++)
            {
                for (int y = 0; y < 1; y++)
                {
                    int t2 = 1;
                    Console.Write("   " + "{0}\t", box[x, y]);
                    Console.WriteLine("{0}\t", box[x, t2]);
                }
            }
            Console.WriteLine(" 請輸入你想要的便當號碼: ");
                

                string cho = "你選擇的是";
            string ss = Console.ReadLine();
           

                switch (ss)
                {
                    case "A":
                        Console.WriteLine($"{cho}{box[0,0]}{box[0,1]}");
                        break;
                    case "B":
                        Console.WriteLine($"{cho}{box[1,0]}{box[1,1]}");
                        break;
                    case "C":
                        Console.WriteLine($"{cho}{box[2,0]}{box[2,1]}");
                        break;
                    case "D":
                        Console.WriteLine($"{cho}{box[3,0]}{box[3,1]}");
                        break;
                    case "E":
                        Console.WriteLine($"{cho}{box[4,0]}{box[4,1]}");
                        break;
                    case "F":
                        Console.WriteLine($"{cho}{box[5,0]}{box[5,1]}");
                        break;
                    case "G":
                        Console.WriteLine($"{cho}{box[6,0]}{box[6,1]}");
                        break;
                    case "H":
                        Console.WriteLine($"{cho}{box[7,0]}{box[7,1]}");
                        break;
                    case "I":
                        Console.WriteLine($"{cho}{box[8,0]}{box[8,1]}");
                        break;
                    case "J":
                        Console.WriteLine($"{cho}{box[9,0]}{box[9,1]}");
                        break;

                    default:
                      Console.WriteLine("   無此產品請重新輸入,退出請輸入exit");
                        break;
                }

                if (ss == "exit")
                {
                    break;
                }
                Console.ReadLine();
            }



            Console.ReadLine();

        }
    }
}

