using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region atributos
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion

        #region enumerados
        public enum ETipo
        {
            Ciclomotor, 
            Sedan, 
            Suv, 
            Todos
        }
        #endregion

        #region constructores
        //solo se invoca a traves del constructor publico
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        //constructor publico de taller, recibe solo un parametro para el campo espacioDisponible

        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");

            foreach (Vehiculo auxiliar in taller.vehiculos)
            {
                switch (tipo)
                {
                    //en cada case valido con operador IS que el vehiculo sea del tipo requerido para agregar sus datos al StringBuilder
                    case ETipo.Suv:
                        if(auxiliar is Suv)
                        {
                            sb.AppendLine(auxiliar.Mostrar());  
                        }                                                                       
                        break;

                    case ETipo.Ciclomotor:
                        if(auxiliar is Ciclomotor)
                        {
                            sb.AppendLine(auxiliar.Mostrar());
                        }                       
                        break;

                    case ETipo.Sedan:
                        if(auxiliar is Sedan)
                        {
                            sb.AppendLine(auxiliar.Mostrar());
                        }                    
                        break;
                    
                    default:
                        {
                            sb.AppendLine(auxiliar.Mostrar());
                        }                       
                        break;
                   
                }
            }

            return sb.ToString();
        }
        #endregion

        #region sobrecarga de operadores
        /// <summary>
        /// Agregará un elemento a la lista, validando que el elemento no este en la lista ni que se exceda la capacidad de la misma.
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool yaEstaEnTaller = false;
            int contadorLugares = 0;

            foreach(Vehiculo auxiliar in taller.vehiculos)
            {
                if(auxiliar == vehiculo)
                {
                    yaEstaEnTaller = true;
                    break;
                }
                contadorLugares++;
            }

            if(!yaEstaEnTaller && contadorLugares<taller.espacioDisponible)
            {
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo item in taller.vehiculos)
            {
                if(item == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
       
                }

            }

            return taller;
        }
        #endregion
    }
}
