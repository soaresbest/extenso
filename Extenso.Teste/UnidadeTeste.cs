using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class UnidadeTeste
    {
        [TestCase('0', "zero")]
        [TestCase('1', "um")]
        [TestCase('2', "dois")]
        [TestCase('3', "três")]
        [TestCase('4', "quatro")]
        [TestCase('5', "cinco")]
        [TestCase('6', "seis")]
        [TestCase('7', "sete")]
        [TestCase('8', "oito")]
        [TestCase('9', "nove")]
        public void ToString_retorna_por_extenso_para_cada_algarismo(char algarismo, string resultadoEsperado)
        {
            var unidade = new Unidade(algarismo);

            Assert.AreEqual(resultadoEsperado, unidade.ToString());
        }
    }
}