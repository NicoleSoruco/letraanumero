using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral1()
        {//Arrange
            LiteralController literalController = new LiteralController();
            int a = 6;
            string esperado = "SEIS  CON 0/100";

            //Act
            string resultado = literalController.Literalget(a);

            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
