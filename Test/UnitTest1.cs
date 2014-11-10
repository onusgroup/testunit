using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sumar_PasandoEnteros_RetornandoLaSuma()
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

        [TestMethod]
        public void Restar_PasandoEnteros_RetornandoLaResta()
        {
            int expected = 100;
            Operaciones op = new Operaciones();
            var res = op.Restar(50, 30);
            //TODO: Comprueba si dos objetos especificados no son iguales. Se produce un error en la aserción si los objetos son iguales.
            Assert.AreNotEqual(expected, res);
        
        }


    }
}
