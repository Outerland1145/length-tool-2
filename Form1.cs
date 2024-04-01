using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_Programming
{
    public partial class Form1 : Form
    {
        string strInput;
        double douOutput;
        
        public Form1()
        {
            InitializeComponent();
            Information.Text = "請輸入數字";
        }
        private void caculateAnswer(int Caculatekind, double douOutput)
        {
            //Kind代表你輸入的數字是屬於哪一個單位，運作原理為將輸入單位轉換為公分後再進行運算
            //1是公分
            //2是公尺
            //3是公里
            //4是英寸
            //5是英尺
            //6是碼
            if (Caculatekind == 1)
            {
                TXM.Text = string.Format("{0:0.##########}", douOutput / 100);
                TXKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                TXinch.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                TXFT.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                TXyard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
                Information.Text = "";
            }
            if (Caculatekind == 2)
            {
                TXKM.Text = string.Format("{0:0.##########}", douOutput / 1000);
                TXCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                TXinch.Text = string.Format("{0:0.##########}", douOutput * 100 / 2.54);
                TXFT.Text = string.Format("{0:0.##########}", douOutput * 100 / 30.48);
                TXyard.Text = string.Format("{0:0.##########}", douOutput * 100 / 91.44);
                Information.Text = "";
            }
            if (Caculatekind == 3)
            {
                TXM.Text = string.Format("{0:0.##########}", douOutput * 1000);
                TXCM.Text = string.Format("{0:0.##########}", douOutput * 100000);
                TXinch.Text = string.Format("{0:0.##########}", douOutput * 100000 / 2.54);
                TXFT.Text = string.Format("{0:0.##########}", douOutput * 100000 / 30.48);
                TXyard.Text = string.Format("{0:0.##########}", douOutput * 100000 / 91.44);
                Information.Text = "";
            }
            if (Caculatekind == 4)
            {
                TXFT.Text = string.Format("{0:0.##########}", douOutput / 12);
                TXyard.Text = string.Format("{0:0.##########}", douOutput / 36);
                TXCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                TXM.Text = string.Format("{0:0.##########}", douOutput * 2.54 * 0.01);
                TXKM.Text = string.Format("{0:0.##########}", douOutput * 2.54 * 0.01 * 0.001);
                Information.Text = "";
            }
            if (Caculatekind == 5)
            {
                TXinch.Text = string.Format("{0:0.##########}", douOutput * 12);
                TXyard.Text = string.Format("{0:0.##########}", douOutput / 3);
                TXCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
                TXM.Text = string.Format("{0:0.##########}", douOutput * 30.48 * 0.01);
                TXKM.Text = string.Format("{0:0.##########}", douOutput * 30.48 * 0.01 * 0.001);
                Information.Text = "";
            }
            if (Caculatekind == 6)
            {
                TXinch.Text = string.Format("{0:0.##########}", douOutput * 36);
                TXFT.Text = string.Format("{0:0.##########}", douOutput * 3);
                TXCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                TXM.Text = string.Format("{0:0.##########}", douOutput * 91.44 * 0.01);
                TXKM.Text = string.Format("{0:0.##########}", douOutput * 91.44 * 0.01 * 0.001);
                Information.Text = "";
            }
            
        }
        private void TXCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput);
            }
            else
            {
                TXCM.Text = "";
                Information.Text = "請輸入數字";
            }

           
        }

        private void TXM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput);
            }
            else
            {
                TXM.Text = "";
                Information.Text = "請輸入數字";
            }

            
        }

        private void TXKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput);
            }
            else
            {
                TXKM.Text = "";
                Information.Text = "請輸入數字";
            }
                
        }

        private void TXinch_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXinch.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput);
            }
            else
            {
                TXinch.Text = "";
                Information.Text = "請輸入數字";
            }

           

        }

        private void TXFT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXFT.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput);
            }
            else
            {
                TXFT.Text = "";
                Information.Text = "請輸入數字";
            }

            

        }

        private void TXyard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = TXyard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(6, douOutput);
            }
            else
            {
                TXyard.Text = "";
                Information.Text = "請輸入數字";
            }

            
        }

        private void changebutton_MouseClick(object sender, MouseEventArgs e)
        {
            TXinch.Text = "";
            TXFT.Text = "";
            TXyard.Text = "";
            TXCM.Text = "";
            TXM.Text = "";
            TXKM.Text = "";
            Information.Text = "請輸入數字";
        }
    }
}
