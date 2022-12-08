using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class hoi : Form
    {
        public hoi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            int number = int.Parse(inputDec.Text);
            string Base = Convert.ToString(number, 2);
            textBox4.Text = Base;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inputDec.Text);
            string Base = Convert.ToString(number, 16);
            textBox4.Text = Base;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Convert.ToInt64(inputHex.Text, 16), 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string twee = inputHex.Text;
            textBox5.Text = int.Parse(twee, System.Globalization.NumberStyles.HexNumber).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string twee = inputBin.Text;
            textBox6.Text = Convert.ToInt32(twee, 2).ToString("X");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string twee = inputBin.Text;
            textBox6.Text = int.Parse(twee, System.Globalization.NumberStyles.HexNumber).ToString();
         
        }
    }
}
