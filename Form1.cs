using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sical
{
    public partial class Form1 : Form
        
    {
        double n1;
        double n2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1=Convert.ToDouble( ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 + n2;
            lb_result.Text = Convert.ToString(result);  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 - n2;
            lb_result.Text = Convert.ToString(result);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 * n2;
            lb_result.Text = Convert.ToString(result);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = Math.Pow(n1,n2);
            lb_result.Text = Convert.ToString(result);

        }

        private void ed_n2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result =(n1/n2);
            lb_result.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = Math.Pow(n1,1/n2);
            lb_result.Text = Convert.ToString(result);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
