using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void ArmaAplicaIva()
        {
            //comprar que al precio se le suma un 21%.
            ArmaBlanca aux = new ArmaBlanca(23, "hoja de bronce", "100", "alabarda", "bronce", 34);
            Assert.AreEqual(121, aux.Precio);

        }

        [TestMethod]
        public void ArmeriaVende()
        {
            
            ArmaBlanca aux = new ArmaBlanca(23, "hoja de bronce", "100", "alabarda", "bronce", 34);      
            Assert.IsTrue(Armeria.Vender(aux));

        }




    }

}
