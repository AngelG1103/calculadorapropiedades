using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorapropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones Suma = new operaciones();
            Suma.V11 = float.Parse(textBox1.Text);
            Suma.V22 = float.Parse(textBox2.Text);
            textBox3.Text = Suma.suma().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operaciones Resta = new operaciones();
            Resta.V11 = float.Parse(textBox1.Text);
            Resta.V22 = float.Parse(textBox2.Text);
            textBox3.Text = Resta.resta().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operaciones mult = new operaciones();
            mult.V11 = float.Parse(textBox1.Text);
            mult.V22 = float.Parse(textBox2.Text);
            textBox3.Text = mult.multiplicacion().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operaciones dividir = new operaciones();
            dividir.V11 = float.Parse(textBox1.Text);
            dividir.V22 = float.Parse(textBox2.Text);
            textBox3.Text = dividir.division().ToString();
        }
    }
}
