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
        public Form1()
        {
            InitializeComponent();
        }
        private void TXCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(TXCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXM.Text = string.Format("{0:0.##########}", douCM / 100);
            TXKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            TXinch.Text = string.Format("{0:0.##########}", douCM / 2.54);
            TXFT.Text = string.Format("{0:0.##########}", douCM / 30.48);
            TXyard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }

        private void TXM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douCM

            douM = Convert.ToDouble(TXM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXKM.Text = string.Format("{0:0.##########}", douM / 1000);
            TXCM.Text = string.Format("{0:0.##########}", douM*100);

            TXinch.Text = string.Format("{0:0.##########}", douM*100 / 2.54);
            TXFT.Text = string.Format("{0:0.##########}", douM*100 / 30.48);
            TXyard.Text = string.Format("{0:0.##########}", douM*100 / 91.44);
        }

        private void TXKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM; //宣告一個double變數，變數名稱叫douCM

            douKM = Convert.ToDouble(TXKM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXM.Text = string.Format("{0:0.##########}", douKM*1000);
            TXCM.Text = string.Format("{0:0.##########}", douKM*100000);

            TXinch.Text = string.Format("{0:0.##########}", douKM * 100000 / 2.54);
            TXFT.Text = string.Format("{0:0.##########}", douKM * 100000 / 30.48);
            TXyard.Text = string.Format("{0:0.##########}", douKM * 100000 / 91.44);
        }

        private void TXinch_KeyUp(object sender, KeyEventArgs e)
        {
            double douIN; //宣告一個double變數，變數名稱叫douCM

            douIN = Convert.ToDouble(TXinch.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXFT.Text = string.Format("{0:0.##########}", douIN/12);
            TXyard.Text = string.Format("{0:0.##########}", douIN/36);
            TXCM.Text = string.Format("{0:0.##########}", douIN * 2.54);
            TXM.Text = string.Format("{0:0.##########}", douIN * 2.54 * 0.01);
            TXKM.Text = string.Format("{0:0.##########}", douIN * 2.54 * 0.01 * 0.001);

        }

        private void TXFT_KeyUp(object sender, KeyEventArgs e)
        {
            double douFT; //宣告一個double變數，變數名稱叫douCM

            douFT = Convert.ToDouble(TXFT.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXinch.Text = string.Format("{0:0.##########}", douFT * 12);
            TXyard.Text = string.Format("{0:0.##########}", douFT/3);
            TXCM.Text = string.Format("{0:0.##########}", douFT * 30.48);
            TXM.Text = string.Format("{0:0.##########}", douFT * 30.48 * 0.01);
            TXKM.Text = string.Format("{0:0.##########}", douFT * 30.48 * 0.01 * 0.001);

        }

        private void TXyard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard; //宣告一個double變數，變數名稱叫douCM

            douYard = Convert.ToDouble(TXyard.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXinch.Text = string.Format("{0:0.##########}", douYard * 36);
            TXFT.Text = string.Format("{0:0.##########}", douYard * 3);
            TXCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            TXM.Text = string.Format("{0:0.##########}", douYard * 91.44*0.01);
            TXKM.Text = string.Format("{0:0.##########}", douYard * 91.44 * 0.01*0.001);
        }

        private void changebutton_MouseClick(object sender, MouseEventArgs e)
        {
            TXinch.Text = "";
            TXFT.Text = "";
            TXyard.Text = "";
            TXCM.Text = "";
            TXM.Text = "";
            TXKM.Text = "";
        }
    }
}
