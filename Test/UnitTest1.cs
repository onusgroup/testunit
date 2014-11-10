using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarTest()
        {

            var Expected = 8;
            Operaciones op = new Operaciones();
            var resultado = op.Sumar(2, 6);


            //TODO: Assert comprueba las condiciones en pruebas unitarias utilizando proposiciones verdaderas o falsas.

            //TODO: Comprueba si dos objetos especificados son iguales.
            Assert.AreEqual(Expected, resultado);
            //TODO: Comprueba si el objeto especificado no es null. Se produce un error en la aserción si es null.
            Assert.IsNotNull(Expected);


        }
    }
}
