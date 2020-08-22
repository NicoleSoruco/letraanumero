using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroaletra.Controllers;

namespace UnitTestLiteral2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {//Arrange
            LiteralController literalController = new LiteralController();
            int a = 6;
            string esperado = "SEIS CON 0/100";
            //Act
            string resultado = literalController.Literalget(a);
            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
