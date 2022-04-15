using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCmToInch_Click(object sender, EventArgs e)
        {
            
            if (txt公分.Text != "")//""空字串
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = txt公分.Text;
                    myCm = System.Convert.ToSingle(strInput);//System可省略
                    myInch = myCm * 0.3937f;
                    //txt英吋.Text = Convert.ToString(myInch);
                    //txt英吋.Text = string.Format("{0:F2}",myInch);
                    txt英吋.Text = string.Format($"{myInch:F2}");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    txt平方公尺.Clear();
                }
                finally
                {
                    txt公分.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入公分值");
            }

        }

        private void btnInchToCm_Click(object sender, EventArgs e)
        {
            //回家練習
            if (txt公分.Text != "")//""空字串
            {
                float myInch = 0.0f;
                float myCm = 0.0f;
                string strInput = txt英吋.Text;
                myInch = System.Convert.ToSingle(strInput);//System可省略
                myCm = myInch / 0.3937f;
                //txt英吋.Text = Convert.ToString(myInch);
                //txt英吋.Text = string.Format("{0:F2}",myInch);
                txt公分.Text = string.Format($"{myCm:F2}");

            }
            else
            {
                MessageBox.Show("請輸入公分值");
            }
        }

        private void btnBinToM2_Click(object sender, EventArgs e)
        {
            //double 比例3.3058
            //if (txt坪數.Text != "")
            //{
            //    double myBin = 0.0d;
            //    double myM2 = 0.0d;
            //    string strInput = txt坪數.Text;
            //    myBin = Convert.ToDouble(strInput);
            //    myM2 = myBin * 3.3058;
            //    txt平方公尺.Text = string.Format($"{myM2}");


            //}
            //else { MessageBox.Show("錯"); }
            //第二種寫法
            if (txt坪數.Text.Length>0)
            {
                double myBin, myM2 = 0.0;
                myBin = Convert.ToDouble(txt坪數.Text);
                myM2 = myBin * 3.3058;
                txt平方公尺.Text = myM2.ToString();
            }
        }

        private void btnM2ToBin_Click(object sender, EventArgs e)
        {

        }

        private void btnKgToPound_Click(object sender, EventArgs e)
        {
            //double 比例2.2
        }

        private void PountTokg_Click(object sender, EventArgs e)
        {

        }
    }
}
