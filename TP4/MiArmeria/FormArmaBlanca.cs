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
    public partial class FormArmaBlanca : Form
    {
        public FormArmaBlanca()
        {
            InitializeComponent();
        }


        public string Descripcion 
        { 
            get
            {
                if(string.IsNullOrEmpty(this.descripcionArmaBlancaTxt.Text))
                {
                    return "vacio";
                }
                else
                {
                    return this.descripcionArmaBlancaTxt.Text;
                }
               

            }

        }

        public string Nombre
        {
            get
            {
                if (string.IsNullOrEmpty(this.nombreArmaBlancaTxt.Text))
                {
                    return "vacio";
                }
                else
                {
                    return this.nombreArmaBlancaTxt.Text;
                }


            }
        }

        public string Material
        {
            get
            {
                if (string.IsNullOrEmpty(this.materialArmaBlancaTxt.Text))
                {
                    return "vacio";
                }
                else
                {
                    return this.materialArmaBlancaTxt.Text;
                }

            }


        }

        public float Precio
        {
            get
            {
                float.TryParse(this.precioArmaBlancaTxt.Text, out float aux);
                return aux;
            }

        }

        public float Longitud
        {
            get
            {
                float.TryParse(this.longitudArmaBlancaTxt.Text, out float aux);
                return aux;
            }
        }



    }
}
