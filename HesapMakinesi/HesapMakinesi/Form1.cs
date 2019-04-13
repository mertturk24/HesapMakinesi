using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int islem = 0;
        double sayi1 = 0,sayi2=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text +="1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
                textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }
        public void sifirla()
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesapla().ToString("#,#.00");
        }
        public double hesapla()
        {
            double sonuc = 0;
            if (islem == 1)
                sonuc = sayi1 + sayi2;
            else if (islem == 2)
                sonuc = sayi1 - sayi2;
            else if (islem == 3)
                sonuc = sayi1 * sayi2;
            else if (islem == 4)
                sonuc = sayi1 / sayi2;
            else
                sonuc = 0;
            return sonuc;
        
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            textBox1.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                textBox1.Text += veri[i].ToString();
            
            }
        }
    }
}
