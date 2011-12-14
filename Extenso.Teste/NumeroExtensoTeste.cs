using System;
using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class NumeroExtensoTeste
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
        [TestCase("2101", "dois mil e cento e um")]
        [TestCase("1000101", "um milhão e cento e um")]
        [TestCase("1105000", "um milhão e cento e cinco mil")]
        [TestCase("2000000", "dois milhões")]
        [TestCase("1100100100", "um bilhão, cem milhões, cem mil e cem")]
        [TestCase("000001", "um")]
        public void retornar_por_extenso(string numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, NumeroExtenso.Converter(numero));
        }

        [Test]
        public void disparar_argument_exception_converter_alfanumerico()
        {
            Assert.Catch<ArgumentException>(() => NumeroExtenso.Converter("a"));
        }
    }
}