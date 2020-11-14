using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// constructor del formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// borrará los datos de los TextBox, ComboBox y Label de la pantalla
        /// </summary>
        private void Limpiar()
        {
            this.Resultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;

        }

        /// <summary>
        /// Manejador del evento que se dispara momentos previos a que el formulario se haga visible.
        /// Llamara la metodo limpiar y asignara nombre al formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora de Juan Pablo Dos Santos del curso 2°A";
            this.Limpiar();

        }
        /// <summary>
        /// Manejador del evento que se dispara al cerrar la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }

        }

        /// <summary>
        /// borrará los datos de los TextBox, ComboBox y Label de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Utiliza el metodo estatico Operar para reflejar el resultado en el label Resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            if (!string.IsNullOrWhiteSpace(cmbOperador.Text))
            {
                resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                
            }
            else
            {
                this.cmbOperador.SelectedIndex = 1;
                resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            }

            this.Resultado.Text = resultado.ToString();

        }
        /// <summary>
        /// Realiza la operacion correspondiente entre dos numeros basandose en el operador elegido. 
        /// </summary>
        /// <param name="numero1" objeto de tipo Numero></param>
        /// <param name="numero2" objeto de tipo Numero></param>
        /// <param name="operador" cadena que contiene el operador></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), Convert.ToChar(operador));
        }
        /// <summary>
        /// Convertira el resultado, de existir, a su representacion en binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numAux = new Numero();
            if (!string.IsNullOrEmpty(this.Resultado.Text))
            {
                this.Resultado.Text = numAux.DecimalBinario(this.Resultado.Text);

            }
        }
        /// <summary>
        /// Convertira el resultado, de existir, a su representacion en decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numAux = new Numero();
            if (!string.IsNullOrEmpty(this.Resultado.Text))
            {
                this.Resultado.Text = numAux.BinarioDecimal(this.Resultado.Text);
            }

        }
    }
}
