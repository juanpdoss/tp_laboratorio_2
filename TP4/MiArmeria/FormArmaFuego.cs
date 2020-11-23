using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiArmeria
{
    public partial class FormArmaFuego : Form
    {
        public FormArmaFuego()
        {
            InitializeComponent();
        }

        public string Descripcion 
        { 
            get
            {
                if (string.IsNullOrEmpty(this.descripcionArmaFuegoTxt.Text))
                {
                    return "vacio";
                }
                else
                {
                    return this.descripcionArmaFuegoTxt.Text;
                }

            }

        }

        public string Nombre
        {
            get
            {
                if (string.IsNullOrEmpty(this.descripcionArmaFuegoTxt.Text))
                {
                    return "vacio";
                }
                else
                {
                    return this.nombreArmaFuegoTxt.Text;
                }

            }

        }

        public float Precio
        {
            get
            {
                 float.TryParse(this.precioArmaFuegoTxt.Text,out float aux);
                 return aux;
            }

        }
            
        public float Calibre
        {

            get
            {
                float.TryParse(this.calibreTxt.Text, out float aux);
                return aux;

            }

        }
       

        public int Cargador
        {
            get
            {
                int.TryParse(this.capacidadCargadorTxt.Text, out int aux);
                return aux;
            }
        }




    }
}
