using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ExtensoTeste
    {
        [Test]
        public void Para_1_retornar_um()
        {
            Assert.AreEqual("um", Extenso.Converter(1));
        }

        [Test]
        public void Para_2_retornar_dois()
        {
            Assert.AreEqual("dois", Extenso.Converter(2));
        }

        [Test]
        public void Para_3_retornar_tres()
        {
            Assert.AreEqual("três", Extenso.Converter(3));
        }
    }
}
