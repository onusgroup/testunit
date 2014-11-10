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
        }

    }
}
