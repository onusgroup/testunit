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
            var Expected = new int();
            var Expected2 = 8;
            Operaciones op = new Operaciones();
            var resultado = op.Sumar(2, 6);

            Assert.ReferenceEquals(Expected, resultado);
            Assert.AreEqual(Expected2, resultado);

        }
    }
}
