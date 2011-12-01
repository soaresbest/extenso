using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ClasseNumericaTeste
    {
        [Test]
        public void para_1000_retorna_mil()
        {
            var milhar = new ClasseNumerica("1000");
            Assert.AreEqual("mil", milhar.ToString());
        }

        [Test]
        public void deve_retorna_3_centenas_para_3548792()
        {
            var milhar = new ClasseNumerica("3548792");

            Assert.AreEqual(3, milhar.Centenas.Count());
        }
    }
}