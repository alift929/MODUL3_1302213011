using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODUL3_1302213011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        int n = -1;
        int[] arrNum = new int[50];

        private void button3_Click(object sender, EventArgs e)
        {
            num = num * 10 + 0;
            label1.Text = label1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            n++;
            arrNum[n] = num;
            num = 0;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = num * 10 + 1;
            label1.Text = label1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = num * 10 + 2;
            label1.Text = label1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = num * 10 + 3;
            label1.Text = label1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = num * 10 + 4;
            label1.Text = label1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = num * 10 + 5;
            label1.Text = label1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = num * 10 + 6;
            label1.Text = label1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = num * 10 + 7;
            label1.Text = label1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = num * 10 + 8;
            label1.Text = label1.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = num * 10 + 9;
            label1.Text = label1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            label1.Text = label1.Text + "=";
            arrNum[n] = num;
            num = 0;
            int jumlah = 0;
            for(int i = 0; i <= n; i++)
            {
                jumlah += arrNum[i];
            }
            label1.Text = "" + jumlah;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
