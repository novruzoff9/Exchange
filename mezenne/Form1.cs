using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mezenne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] valyutalar = { "AZN", "USD", "TRY", "RUB", "EUR" };

        double[] vrg= { 1, 1.69999, 0.194727, 0.0233807, 2.01692 };

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(valyutalar);
            comboBox2.Items.AddRange(valyutalar);
            textBox1.MaxLength = 10;
            textBox2.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(textBox1.Text);
            p = p * vrg[comboBox1.SelectedIndex] / vrg[comboBox2.SelectedIndex];
            textBox2.Text = Convert.ToString(p);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = f;
            double p = Convert.ToDouble(textBox1.Text);
            p = p * vrg[comboBox1.SelectedIndex] / vrg[comboBox2.SelectedIndex];
            textBox2.Text = Convert.ToString(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
