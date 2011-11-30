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
    }
}
