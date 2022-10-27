using System;
using System.CodeDom;
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

        private void generalbutton_Click(object sender, EventArgs e)
        {
            // left
            //取得列數
            int? rows = Getrows();

            if(rows.HasValue==false)
            {
                MessageBox.Show("請輸入列數");

                return;
            }


            //判斷列數必須大於零
            if(rows.Value <= 0)
            {
                MessageBox.Show("列數必需大於零");
                return;
            }
            if (rows.Value <= 0 || rows.Value >10)
            {
                MessageBox.Show("請輸入10以内的數字");
            }

            //生成星號三角形
            string stars = Generatestars(rows.Value);
            //用 textbox 呈現
            resultTextBox.Text = stars;
        }

        private string Generatestars(int rows)
        {
            string result = string.Empty;
            for(int i = 0; i < rows; i++)
            {
                result += new string( '*',  i) + "\r\n";
            }
            return result;
        }

        private int? Getrows()
        {
            string input = rowsTextBox.Text;
            bool isInt = int.TryParse(input, out int rows);

            if(isInt)
            {
                return rows ;
            }
            else
            {
                return null;
            }
        }

        private void generalbutton01_Click(object sender, EventArgs e)
        {
            // right
            int? rows01 = Getrows01();

            if (rows01.HasValue == false)
            {
                MessageBox.Show("請輸入列數");

                return;
            }


            //判斷列數必須大於零
            if (rows01.Value <= 0)
            {
                MessageBox.Show("列數必需大於零");
                return;
            }

            if (rows01.Value <= 0 || rows01.Value > 10)
            {
                MessageBox.Show("請輸入10以内的數字");
            }
            //生成星號三角形
            string stars = Generatestars01(rows01.Value);
            //用 textbox 呈現
            resultTextBox.Text = stars;
        }

        private string Generatestars01(int rows01)
        {
            string result = string.Empty;
            for (int i = 1; i <= rows01; i++)
            {
                result += new string(' ', rows01 - i) + new string('*', i) + "\r\n";
                //for(int j= 1; j <= rows01; j++)
                //{ resultTextBox.Text += "*"; }
                ////result += new string('*', i) + "\r\n";
                //resultTextBox.Text += "\r\n";
            }
            return result;
        }
        private int? Getrows01()
        {
            string input = rowsTextBox.Text;
            bool isInt = int.TryParse(input, out int rows01);

            if (isInt)
            {
                return rows01;
            }
            else
            {
                return null;
            }
        }

        private void generalbutton02_Click(object sender, EventArgs e)
        {
            int? rows02 = Getrows02();

            if (rows02.HasValue == false)
            {
                MessageBox.Show("請輸入列數");

                return;
            }


            //判斷列數必須大於零
            if (rows02.Value <= 0)
            {
                MessageBox.Show("列數必需大於零");
                return;
            }

            if (rows02.Value <= 0 || rows02.Value > 10)
            {
                MessageBox.Show("請輸入10以内的數字");
            }

            //生成星號三角形
            string stars = Generatestars02(rows02.Value);
            //用 textbox 呈現
            resultTextBox.Text = stars;
        }
        private string Generatestars02(int rows02)
        {
            string result = string.Empty;
            for (int i = 0; i < rows02; i++)
            {

                for (int j = 0; j <= (rows02 - (i + 1)); j++)
                {

                    result += " ";

                }
                for (int j = 0; j < 2 * i + 1; j++)
                {

                    result += "*";

                }
                result += "\r\n";
            }
                //else
                //{
                //    MessageBox.Show("You must enter a number between 1 and 10",
                //              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result; //}
        }
        private int? Getrows02()
        {
            string input = rowsTextBox.Text;
            bool isInt = int.TryParse(input, out int rows02);

            if (isInt)
            {
                return rows02;
            }
            else
            {
                return null;
            }
        }


    }
}
