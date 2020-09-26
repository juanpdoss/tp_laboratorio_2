using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.BackColor = Color.Empty;
        }

        private static double Operar(string num1, string num2, string operador)
        {
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
          

            double rta = Calculadora.Operar(numero1, numero2, operador);
            return rta;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text;
            string numero2 = this.txtNumero2.Text;

            if(comboBox1.Text=="")
            {
                string msg = "Ingresar operador + automaticamente";
                string titulo = "Error. No ha ingresado un operador";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult respuesta = MessageBox.Show(msg,titulo,btn);
                if (respuesta == DialogResult.OK)
                    comboBox1.Text = "+";               

            }

            double rta=Operar(numero1,numero2, comboBox1.Text);

            
            resultado.Text= Convert.ToString(rta);

        }

        private void btnConvertirABinario_click(object sender, EventArgs e)
        {
            Numero aux;
            if(resultado.Text!="")
            {
                aux = new Numero(resultado.Text);
                resultado.Text = aux.DecimalBinario(resultado.Text);
            }

        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.comboBox1.Text = "";
            resultado.Text = "";
       
        }

        private void txtresultado(object sender, EventArgs e)
        {
           
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Numero aux;
            if (resultado.Text != "")
            {
                aux = new Numero();
                resultado.Text = aux.BinarioDecimal(resultado.Text);

            }


        }
    }
}
