using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projBitABit
{
    public partial class Form1 : Form
    {
        private Bits bits;

        public Form1()
        {
            InitializeComponent();
            bits = this.bits = new Bits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bits.setBits(byte.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(bits.getBits());
            label2.Text = Convert.ToString(bits.getBits(), 2);
            label3.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            lblBit1.Text = (bits.getBits(1)) ? "1" : "0";
            lblBit2.Text = (bits.getBits(2)) ? "1" : "0";
            lblBit3.Text = (bits.getBits(3)) ? "1" : "0";
            lblBit4.Text = (bits.getBits(4)) ? "1" : "0";
            lblBit5.Text = (bits.getBits(5)) ? "1" : "0";
            lblBit6.Text = (bits.getBits(6)) ? "1" : "0";
            lblBit7.Text = (bits.getBits(7)) ? "1" : "0";
            lblBit8.Text = (bits.getBits(8)) ? "1" : "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 23; // qualquer valor entre 0..255
            int y1 = 1;
            int y2 = 2;
            int y3 = 4;
            int y4 = 8;
            int y5 = 16;
            int y6 = 32;
            int y7 = 64;
            int y8 = 128;

            int z1 = x & y1;
            int z2 = x & y2;
            int z3 = x & y3;
            int z4 = x & y4;
            int z5 = x & y5;
            int z6 = x & y6;
            int z7 = x & y7;
            int z8 = x & y8;

            label4.Text = z8.ToString() + " " +
                z7.ToString() + " " +
                z6.ToString() + " " +
                z5.ToString() + " " +
                z4.ToString() + " " +
                z3.ToString() + " " +
                z2.ToString() + " " +
                z1.ToString();

            
        }

        private void btnLiga_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse(txtBit.Text));
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse(txtBit.Text));
        }
    }
}
