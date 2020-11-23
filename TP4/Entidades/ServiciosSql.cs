using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estatica ServiciosSql.
    /// </summary>
    public static class ServiciosSql
    {
        
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;
     
        /// <summary>
        /// Llena el dataTable recibido como parametro con los datos de la tabla en la base de datos.
        /// </summary>
        /// <param name="tabla"></param>
        public static void GetArmasDeFuego(DataTable tabla)
        {                
            try
            {             
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = System.Data.CommandType.Text;
                ServiciosSql.comando.CommandText = "SELECT * FROM armasDeFuego";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;

                if(ServiciosSql.conexion.State != ConnectionState.Open)
                ServiciosSql.conexion.Open();

                ServiciosSql.lector = ServiciosSql.comando.ExecuteReader();

                while(lector.Read())
                {
                   tabla.Load(lector);
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                tabla = null;
            }
            finally
            {
                if (ServiciosSql.conexion.State == System.Data.ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

          
        }
        /// <summary>
        /// Llena el dataTable recibido como parametro con los datos de la tabla en la base de datos.
        /// </summary>
        /// <param name="tabla"></param>
        public static void GetArmasBlancas(DataTable tabla)
        {

            List<ArmaBlanca> armas;

            try
            {
                armas = new List<ArmaBlanca>();
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = System.Data.CommandType.Text;
                ServiciosSql.comando.CommandText = "SELECT * FROM armasBlancas";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;


                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                ServiciosSql.lector = ServiciosSql.comando.ExecuteReader();

                while (lector.Read())
                {
                   tabla.Load(lector);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                tabla = null;
            }
            finally
            {
                if (ServiciosSql.conexion.State == System.Data.ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

     

        }
        /// <summary>
        /// Quita el objeto recibido por parametro de la base de datos.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns></returns>
        public static bool QuitarArmaDeFuego(ArmaDeFuego arma)
        {
            bool pude = true;

            try
            {
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.CommandText = "DELETE FROM armasDeFuego WHERE id=@id";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.Parameters.AddWithValue("@id", arma.Id);

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();


                int filasAfectas = ServiciosSql.comando.ExecuteNonQuery();
                if (filasAfectas == 0)
                    pude = false;
            }
            catch
            {
                pude = false;

            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

            return pude;

        }
        /// <summary>
        /// Quita el objeto recibido por parametro de la base de datos.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns></returns>
        public static bool QuitarArmaBlanca(ArmaBlanca arma)
        {
            bool pude = true;

            try
            {
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.CommandText = "DELETE FROM armasBlancas WHERE id=@id";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.Parameters.AddWithValue("@id", arma.Id);

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();


                int filasAfectas = ServiciosSql.comando.ExecuteNonQuery();
                if (filasAfectas == 0)
                    pude = false;
            }
            catch
            {
                pude = false;

            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

            return pude;

        }
        /// <summary>
        /// Inserta el objeto recibido por parametro en la base de datos.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns></returns>
        public static bool InsertarArmaDeFuego(ArmaDeFuego arma)
        {
            bool pude = true;

            try
            {
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.Connection = ServiciosSql.conexion;

                string cadenaComando = "INSERT INTO armasDeFuego (descripcion,precio,nombre,capacidadCargador,calibre) ";
                cadenaComando += "VALUES (@descripcion,@precio,@nombre,@capacidadCargador,@calibre)";
            
                ServiciosSql.comando.Parameters.AddWithValue("@descripcion", arma.Descripcion);
                ServiciosSql.comando.Parameters.AddWithValue("@precio", arma.Precio);
                ServiciosSql.comando.Parameters.AddWithValue("@nombre", arma.Nombre);
                ServiciosSql.comando.Parameters.AddWithValue("@capacidadCargador", arma.CapacidadCargador);
                ServiciosSql.comando.Parameters.AddWithValue("@calibre", arma.Calibre);

                ServiciosSql.comando.CommandText = cadenaComando;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                int filasAfectadas = ServiciosSql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    pude = false;

            }
            catch
            {
                pude = false;
            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

            return pude;


        }
        /// <summary>
        /// Inserta el objeto recibido por parametro en la base de datos.
        /// </summary>
        /// <param name="arma"></param>
        /// <returns></returns>
        public static bool InsertarArmaBlanca(ArmaBlanca arma)
        {
            bool pude = true;

            try
            {
                ServiciosSql.conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True");
                ServiciosSql.comando = new SqlCommand();
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.Connection = ServiciosSql.conexion;

                string cadenaComando = "INSERT INTO armasBlancas (descripcion,precio,nombre,material,longitud) ";
                cadenaComando += "VALUES (@descripcion,@precio,@nombre,@material,@longitud)";

                ServiciosSql.comando.Parameters.AddWithValue("@descripcion", arma.Descripcion);
                ServiciosSql.comando.Parameters.AddWithValue("@precio", arma.Precio);
                ServiciosSql.comando.Parameters.AddWithValue("@nombre", arma.Nombre);
                ServiciosSql.comando.Parameters.AddWithValue("@material", arma.Material);
                ServiciosSql.comando.Parameters.AddWithValue("@longitud", arma.Longitud);
       

                ServiciosSql.comando.CommandText = cadenaComando;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();


                int filasAfectadas = ServiciosSql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    pude = false;

            }
            catch
            {
                pude = false;
            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();

            }

            return pude;


        }

    }
}
