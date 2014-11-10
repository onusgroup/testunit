using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Consulta_PasandoNombre_RetornandoBoleano()
        {
            var result = Program.consulta("pato");
            Assert.IsTrue(result);

            //Error en la prueba ya que no existe el nombre indicado
            var result2 = Program.consulta("marijuana");
            Assert.IsTrue(result2);
        }

    }
}
