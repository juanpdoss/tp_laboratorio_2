using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiArmeria
{
    public partial class FormArmeria : Form
    {
        DataTable tablaArmas;
        DataTable tablaArmasBlancas;
        List<ArmaDeFuego> armasDeFuegoAux;
        List<ArmaBlanca> armasBlancasAux;
        Thread hiloActualizacionLabel;

        public delegate void MiDelegado(Arma aux);
        public event MiDelegado Venta;

        public FormArmeria()
        {
            InitializeComponent();
            this.armasBlancasAux = new List<ArmaBlanca>();
            this.armasDeFuegoAux = new List<ArmaDeFuego>();
            this.hiloActualizacionLabel = new Thread(this.ActualizarLabel);
        }

        private void FormArmeria_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ConfigurarTablaArmasDeFuego();
            this.ConfigurarTablaArmasBlancas();

            ServiciosSql.GetArmasDeFuego(tablaArmas);
            ServiciosSql.GetArmasBlancas(tablaArmasBlancas);

            this.btn_VenderArmaFuego.Enabled=false;
            this.btn_AgregarArmaBlanca.Enabled = false;
            this.btn_VenderArmaBlanca.Enabled = false;
            this.btn_AgregarArmaFuego.Enabled = false;
            this.btn_SerializarArmaBlanca.Enabled = false;
            this.btn_SerializarArmaFuego.Enabled = false;

            this.Venta += new MiDelegado(this.GuardarTxtVenta);

            this.hiloActualizacionLabel.Start();
            
        }

  

        private void btn_CargarArmas_Click(object sender, EventArgs e)
        {
            this.dgArmasDeFuego.DataSource = this.tablaArmas;
            this.dgArmasBlancas.DataSource = this.tablaArmasBlancas;

            this.btn_VenderArmaFuego.Enabled = true;
            this.btn_AgregarArmaBlanca.Enabled = true;
            this.btn_VenderArmaBlanca.Enabled = true;
            this.btn_AgregarArmaFuego.Enabled = true;
            this.btn_SerializarArmaBlanca.Enabled = true;
            this.btn_SerializarArmaFuego.Enabled = true;


        }

        private void btn_AgregarArmaFuego_Click(object sender, EventArgs e)
        {
            try
            {
                FormArmaFuego frm = new FormArmaFuego();
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = this.tablaArmas.NewRow();
                    row["descripcion"] = frm.Descripcion;
                    row["precio"] = frm.Precio;
                    row["nombre"] = frm.Nombre;
                    row["capacidadCargador"] = frm.Cargador;
                    row["calibre"] = frm.Calibre;

                    this.tablaArmas.Rows.Add(row);
                    this.tablaArmas.AcceptChanges();

                    this.dgArmasDeFuego.DataSource = this.tablaArmas;

                    this.armasDeFuegoAux.Add(GenerarArmaFuegoDesdeFila(row));

                }


            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        private void btn_AgregarArmaBlanca_Click(object sender, EventArgs e)
        {
            try
            {
                FormArmaBlanca frm = new FormArmaBlanca();
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = this.tablaArmasBlancas.NewRow();
                    row["descripcion"] = frm.Descripcion;
                    row["precio"] = frm.Precio;
                    row["nombre"] = frm.Nombre;
                    row["material"] = frm.Material;
                    row["longitud"] = frm.Longitud;

                    this.tablaArmasBlancas.Rows.Add(row);
                    this.tablaArmasBlancas.AcceptChanges();
                    this.dgArmasBlancas.DataSource = this.tablaArmasBlancas;

                    this.armasBlancasAux.Add(GenerarArmaBlancaDesdeFila(row));

                }

            }catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }



        }

        private void btnVenderArma_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.dgArmasDeFuego.SelectedRows[0].Index;

                DataRow row = this.tablaArmas.Rows[indice];


                ArmaDeFuego aux = this.GenerarArmaFuegoDesdeFila(row);

                if (Armeria.Vender(aux))
                {
                    this.Venta(aux);
                }


                this.tablaArmas.Rows[indice].Delete();
                this.tablaArmas.AcceptChanges();

                DialogResult respuesta = MessageBox.Show("¿Desea tambien quitar el arma de la base de datos?",
                                                      "Remover arma de la base de datos",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                     MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    if (ServiciosSql.QuitarArmaDeFuego(aux))
                    {
                        MessageBox.Show("arma removida con exito");
                    }

                }

            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);

            }
           

        }




        private void btn_VenderArmaBlanca_Click(object sender, EventArgs e)
        { 
            try
            {
                int indice = this.dgArmasBlancas.SelectedRows[0].Index;

                DataRow row = this.tablaArmasBlancas.Rows[indice];

                ArmaBlanca aux = this.GenerarArmaBlancaDesdeFila(row);

                if (Armeria.Vender(aux))
                {
                    this.Venta(aux);
                }

                this.tablaArmasBlancas.Rows[indice].Delete();
                this.tablaArmasBlancas.AcceptChanges();

                DialogResult respuesta = MessageBox.Show("¿Desea tambien quitar el arma de la base de datos?",
                                         "Remover arma de la base de datos",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    if (ServiciosSql.QuitarArmaBlanca(aux))
                    {
                        MessageBox.Show("arma removida con exito");
                    }

                }



            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }


        private void FormArmeria_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea agregar las armas de esta sesion a la base de datos?",
                                                    "Guardar armas en base de datos",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                if (this.armasDeFuegoAux.Count != 0)
                {
                    foreach (ArmaDeFuego item in this.armasDeFuegoAux)
                    {
                        ServiciosSql.InsertarArmaDeFuego(item);

                    }

                }

                if (this.armasBlancasAux.Count != 0)
                {
                    foreach (ArmaBlanca item in this.armasBlancasAux)
                    {
                        ServiciosSql.InsertarArmaBlanca(item);

                    }

                }

            }
            else
            {
                MessageBox.Show("No se han guardado las armas en la base datos.");


            }

            this.hiloActualizacionLabel.Abort();
        }
        private void btn_SerializarArma_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.dgArmasDeFuego.SelectedRows[0].Index;

                DataRow row = this.tablaArmas.Rows[indice];

                ArmaDeFuego aux = this.GenerarArmaFuegoDesdeFila(row);

                Serializador<ArmaDeFuego> serializador = new Serializador<ArmaDeFuego>();

                if (serializador.Serializar(aux))
                    MessageBox.Show("arma de fuego serializada");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }
        private void btn_SerializarArmaBlanca_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.dgArmasBlancas.SelectedRows[0].Index;

                DataRow row = this.tablaArmasBlancas.Rows[indice];

                ArmaBlanca aux = this.GenerarArmaBlancaDesdeFila(row);

                Serializador<ArmaBlanca> serializador = new Serializador<ArmaBlanca>();

                if (serializador.Serializar(aux))
                    MessageBox.Show("arma blanca serializada");

            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        #region metodos
        /// <summary>
        /// Genera a partir de una fila de dataRow un objeto de tipo ArmaDeFuego
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ArmaDeFuego GenerarArmaFuegoDesdeFila(DataRow data)
        {
            ArmaDeFuego aux = new ArmaDeFuego(int.Parse(data["id"].ToString()),
                                         data["descripcion"].ToString(),
                                         data["precio"].ToString(),
                                         data["nombre"].ToString(),
                                         int.Parse(data["capacidadCargador"].ToString()),
                                         float.Parse(data["calibre"].ToString())
                                         );

            return aux;
        }
        /// <summary>
        /// Genera a partir de una fila de dataRow un objeto de tipo armaBlanca
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ArmaBlanca GenerarArmaBlancaDesdeFila(DataRow data)
        {
            ArmaBlanca aux = new ArmaBlanca(int.Parse(data["id"].ToString()),
                                         data["descripcion"].ToString(),
                                         data["precio"].ToString(),
                                         data["nombre"].ToString(),
                                         data["material"].ToString(),
                                         float.Parse(data["longitud"].ToString())
                                         );

            return aux;
        }

        /// <summary>
        /// Configura el atributo dataTable para las armas de fuego.
        /// </summary>
        private void ConfigurarTablaArmasDeFuego()
        {
            this.tablaArmas = new DataTable();
            this.tablaArmas.Columns.Add("id",typeof(int));
            this.tablaArmas.Columns.Add("descripcion", typeof(string));
            this.tablaArmas.Columns.Add("precio", typeof(float));
            this.tablaArmas.Columns.Add("nombre", typeof(string));
            this.tablaArmas.Columns.Add("capacidadCargador", typeof(int));
            this.tablaArmas.Columns.Add("calibre", typeof(float));

            this.tablaArmas.PrimaryKey = new DataColumn[] { this.tablaArmas.Columns[0] };
            this.tablaArmas.Columns["id"].AutoIncrement = true;
            this.tablaArmas.Columns["id"].AutoIncrementSeed = 29;
            this.tablaArmas.Columns["id"].AutoIncrementStep = 1;


        }

        /// <summary>
        /// Configura el atributo de dataTable para las armas blancas.
        /// </summary>
        private void ConfigurarTablaArmasBlancas()
        {
            this.tablaArmasBlancas = new DataTable();
            this.tablaArmasBlancas.Columns.Add("id", typeof(int));
            this.tablaArmasBlancas.Columns.Add("descripcion", typeof(string));
            this.tablaArmasBlancas.Columns.Add("precio", typeof(float));
            this.tablaArmasBlancas.Columns.Add("nombre", typeof(string));
            this.tablaArmasBlancas.Columns.Add("material", typeof(string));
            this.tablaArmasBlancas.Columns.Add("longitud", typeof(float));

            this.tablaArmasBlancas.PrimaryKey = new DataColumn[] { this.tablaArmasBlancas.Columns[0] };
            this.tablaArmasBlancas.Columns["id"].AutoIncrement = true;
            this.tablaArmasBlancas.Columns["id"].AutoIncrementSeed = 1;
            this.tablaArmasBlancas.Columns["id"].AutoIncrementStep = 1;

        }

        /// <summary>
        /// Manejador del evento que se produce al registrar una venta. Guardara la arma vendida en un archivo de texto.
        /// </summary>
        /// <param name="aux"></param>
        public void GuardarTxtVenta(Arma aux)
        {
            try
            {
                using(StreamWriter escritor=new StreamWriter("ventas.txt",true))
                {
                    escritor.WriteLine("Hora de venta: " + DateTime.Now);
                    escritor.WriteLine("Objeto vendido");
                    escritor.WriteLine(aux.ToString());
                }

            }
            catch
            {

            }
           
        }

        /// <summary>
        /// Actualizara el label Total sumandole el precio de una nueva venta.
        /// </summary>
        public void ActualizarLabel()
        {
            while (true)
            {
                if (this.lblTotal.InvokeRequired)
                {
                    this.lblTotal.BeginInvoke
                        (
                         (MethodInvoker)delegate ()
                         {
                             this.lblTotal.Text = Armeria.Recaudado.ToString();
                         }
                        );

                }
 
                Thread.Sleep(10000);
            }

        }

        #endregion

    }


}

