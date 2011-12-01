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

        [TestCase("3325644748", 4)]
        [TestCase("332564378", 3)]
        [TestCase("33256478", 3)]
        [TestCase("4256478", 3)]
        [TestCase("566478", 3)]
        [TestCase("64778", 2)]
        public void deve_retorna_quantidade_de_centenas_para_numeros_grandes(string numero, int quantidadeEsperada)
        {
            var milhar = new ClasseNumerica(numero);
            Assert.AreEqual(quantidadeEsperada, milhar.QuantidadeCentenas);
        }

        [Test]
        public void ultima_centena_deve_ser_792_para_3548792()
        {
            var milhar = new ClasseNumerica("3548792");
            Assert.AreEqual(792, milhar.Centenas.Last().ToInt());
        }
    }
}