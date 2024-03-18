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
        }

        private void TXM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douCM

            douM = Convert.ToDouble(TXM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXKM.Text = string.Format("{0:0.##########}", douM / 1000);
            TXCM.Text = string.Format("{0:0.##########}", douM*100);
        }

        private void TXKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM; //宣告一個double變數，變數名稱叫douCM

            douKM = Convert.ToDouble(TXKM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            TXM.Text = string.Format("{0:0.##########}", douKM*1000);
            TXCM.Text = string.Format("{0:0.##########}", douKM*100000);
        }
    }
}
