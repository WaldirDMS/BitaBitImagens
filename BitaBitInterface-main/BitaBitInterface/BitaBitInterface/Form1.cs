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
            atualizaBits();

        }

        private void desligaGeral_CheckedChanged_1(object sender, EventArgs e)
        {
            string x;
            x = "0";
            bits.setBits(byte.Parse(x));

            atualizaBits();
        }

        private void LigaGeral_CheckedChanged(object sender, EventArgs e)
        {
            string x;
            x = "255";
            bits.setBits(byte.Parse(x));

            atualizaBits();
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            bits.setBits(byte.Parse(textBox1.Text));

            atualizaBits();
        }

        public void atualizaBits()
        {
            label1.Text = Convert.ToString(bits.getBits());
            label2.Text = Convert.ToString(bits.getBits(), 2);
            label3.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            picLampada1.Image = (bits.getBits(1)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada2.Image = (bits.getBits(2)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada3.Image = (bits.getBits(3)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada4.Image = (bits.getBits(4)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada5.Image = (bits.getBits(5)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada6.Image = (bits.getBits(6)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada7.Image = (bits.getBits(7)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            picLampada8.Image = (bits.getBits(8)) ? BitaBitInterface.Properties.Resources.motor_on : BitaBitInterface.Properties.Resources.motor_off;
            radLamp1On.Checked = bits.getBits(1);
            radLamp2On.Checked = bits.getBits(2);
            radLamp3On.Checked = bits.getBits(3);
            radLamp4On.Checked = bits.getBits(4);
            radLamp5On.Checked = bits.getBits(5);
            radLamp6On.Checked = bits.getBits(6);
            radLamp7On.Checked = bits.getBits(7);
            radLamp8On.Checked = bits.getBits(8);
            radLamp1Off.Checked = !bits.getBits(1);
            radLamp2Off.Checked = !bits.getBits(2);
            radLamp3Off.Checked = !bits.getBits(3);
            radLamp4Off.Checked = !bits.getBits(4);
            radLamp5Off.Checked = !bits.getBits(5);
            radLamp6Off.Checked = !bits.getBits(6);
            radLamp7Off.Checked = !bits.getBits(7);
            radLamp8Off.Checked = !bits.getBits(8);

        }

      
        private void radLamp1On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("1"));

            atualizaBits();
        }

        private void radLamp2On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("2"));

            atualizaBits();
        }

        private void radLamp3On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("3"));

            atualizaBits();
        }

        private void radLamp4On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("4"));

            atualizaBits();
        }

        private void radLamp5On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("5"));

            atualizaBits();
        }

        private void radLamp6On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("6"));

            atualizaBits();
        }

        private void radLamp7On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("7"));

            atualizaBits();
        }

        private void radLamp8On_Click(object sender, EventArgs e)
        {
            bits.setBit1(int.Parse("8"));

            atualizaBits();
        }

        private void radLamp1Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("1"));

            atualizaBits();
        }

        private void radLamp2Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("2"));

            atualizaBits();
        }

        private void radLamp3Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("3"));

            atualizaBits();
        }

        private void radLamp4Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("4"));

            atualizaBits();
        }

        private void radLamp5Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("5"));

            atualizaBits();
        }

        private void radLamp6Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("6"));

            atualizaBits();
        }

        private void radLamp7Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("7"));

            atualizaBits();
        }

        private void radLamp8Off_Click(object sender, EventArgs e)
        {
            bits.setBit0(int.Parse("8"));

            atualizaBits();
        }

      
    }
}
