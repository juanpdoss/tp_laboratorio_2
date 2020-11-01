using System;
using System.Collections.Generic;
using System.Globalization;
using Archivos;
using Clases_Instanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_unitarios
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FormatoDniInvalido()
        {
            //arrange
            string dniStringInvalido = "413a301A";
           

            //act
            try
            {
                Alumno primero = new Alumno(1, "polkan", "maya", dniStringInvalido, 0, 0);
            }
            catch (Exception e)
            {
                //Assert
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));

            }
           
        }


        [TestMethod]
        public void LanzaExcepcionDeArchivo()
        {
            //arrange
            string path = "";
            string datos = "";
            Texto lector = new Texto();

            //act
            try
            {
                lector.Leer(path,out datos);

            }
            //assert
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArchivosException));
            }

        }

        [TestMethod]
        public void InstanciaListaAlumnos()
        {
            //arrange y act
            Universidad universidad = new Universidad();

            //assert
            Assert.IsNotNull(universidad.Alumnos);
          
        }


    }
}
