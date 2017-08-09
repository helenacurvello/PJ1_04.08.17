using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ1_04._08._2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "OLÁ, SEJA BEM VINDO :D";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             

            if (checkBox1.Enabled == true)
            {
                checkBox1.Enabled = false;
                textBox1.AppendText("\n");
                textBox1.AppendText("Checkbox parou de funcionar :/ " + trackBar1.Value);
                
            }

            else 
            {
                checkBox1.Enabled = true;
                textBox1.AppendText("\n");
                textBox1.AppendText("Checkbox voltou a funcionar :D " + trackBar1.Value);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.AppendText("\n");
            textBox1.AppendText(" funcionou");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
