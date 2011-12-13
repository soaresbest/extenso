using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ExtensoTeste
    {
        [TestCase("0", "zero")]
        [TestCase("1", "um")]
        [TestCase("10", "dez")]
        [TestCase("11", "onze")]
        [TestCase("19", "dezenove")]
        [TestCase("20", "vinte")]
        [TestCase("21", "vinte e um")]
        [TestCase("99", "noventa e nove")]
        [TestCase("100", "cem")]
        [TestCase("101", "cento e um")]
        [TestCase("110", "cento e dez")]
        [TestCase("111", "cento e onze")]
        [TestCase("999", "novecentos e noventa e nove")]
        [TestCase("2001", "dois mil e um")]
        [TestCase("1000", "mil")]
        [TestCase("2000", "dois mil")]
        public void retornar_por_extenso(string numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, Extenso.Converter(numero));
        }
    }
}
