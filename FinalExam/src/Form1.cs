using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Form1 : Form
    {
        String filename;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Files (*.html)|*.html"; ;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string temp = openFileDialog1.FileName;
            webBrowser1.Navigate(new Uri(temp));

            String[] arr = temp.Split('\\');
            filename = arr.Last();
            
            this.ClientSize = new System.Drawing.Size(1062, 567);

        }

        private void getResultForFirstPage(double x, double y)
        {
            if(y <= 4 * x && y <= -4 * x && y >= x * x - 5)
            {
                label4.Visible = true;
                label4.Text = "принадлежит";
                MessageBox.Show(
                 "Принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                
                label4.Visible = true;
                label4.Text = "не принадлежит";
                MessageBox.Show(
                 "Не принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void getResultForSecondPage(double x, double y)
        {
            if (y >= x && y >= -x && y <= 2)
            {
               
                label4.Visible = true;
                label4.Text = "принадлежит";
                MessageBox.Show(
                 "Принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                label4.Visible = true;
                label4.Text = "не принадлежит";
                MessageBox.Show(
                 "Не принадлежит",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isValid(textBox1.Text) && textBox2.Text != "" && isValid(textBox2.Text))
            {
                if (filename == "FirstPage.html") getResultForFirstPage(Convert.ToDouble(textBox2.Text),Convert.ToDouble(textBox1.Text));
                if (filename == "SecondPage.html") getResultForSecondPage(Convert.ToDouble(textBox2.Text),Convert.ToDouble(textBox1.Text));
            }
        }
        private bool isValid(String str)
        {
            char[] chArr = str.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (!(chArr[i] >= '0' && chArr[i] <= '9') && chArr[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 "Аюбджанов Егор Вариант 1",
                  "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
