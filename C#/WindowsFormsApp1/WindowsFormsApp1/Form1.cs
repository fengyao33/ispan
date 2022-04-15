using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("小數位數控制 pi{0:F}",3.141592);
            //{:F} F字元小數點以下2位 F4小數點以下4位 支援四捨五入
            Console.WriteLine("百分比號:{0:P}",0.8765); 
            Console.WriteLine("科學記號:{0:E}",0.00000001515);
            Console.WriteLine("科學記號:{0:E}",1212.5646464);
            Console.WriteLine("金融符號:{0:C}", 1000000);
            //金融符號以作業系統設定為主
            Console.WriteLine("整數補零{0:D8}",123);
            Console.WriteLine("現在時間:{0}",System.DateTime.Now);
            Console.WriteLine("{0:d}",DateTime.Now);
            Console.WriteLine("{0:D}",DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
            Console.WriteLine("{0:T}", DateTime.Now);
            Console.WriteLine("{0:t}", DateTime.Now);
            Console.WriteLine("{0:M}", DateTime.Now);


            System.Windows.Forms.MessageBox.Show("歡迎使用");
            MessageBox.Show("多載的功能","標題",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            lbl標題.Text="super好喝冷飲";
            lbl回應訊息.Text = "這邊修改內容";
        }

        private void btn紅茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "紅茶 50元";
        }

        private void btn綠茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "綠茶 50元";
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "奶茶 50元";
        }

        

        private void btnwater_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "水 50元";
        }
    }
}
