using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebawindowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox1.Text = "hola jeje";
            this.Text = "probando";

            //se crea la instancia del form en memoria dinamica, sigue invisible
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //evento load
            MessageBox.Show(" instancia del form en memoria dinamica, sigue invisible");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
