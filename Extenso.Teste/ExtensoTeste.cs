using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ExtensoTeste
    {
        [TestCase((ulong)0, "zero")]
        [TestCase((ulong)1, "um")]
        [TestCase((ulong)10, "dez")]
        [TestCase((ulong)11, "onze")]
        [TestCase((ulong)19, "dezenove")]
        [TestCase((ulong)20, "vinte")]
        [TestCase((ulong)21, "vinte e um")]
        [TestCase((ulong)99, "noventa e nove")]
        [TestCase((ulong)100, "cem")]
        [TestCase((ulong)101, "cento e um")]
        [TestCase((ulong)110, "cento e dez")]
        [TestCase((ulong)111, "cento e onze")]
        [TestCase((ulong)999, "novecentos e noventa e nove")]
        //[TestCase((ulong)2001, "dois mil e um")]
        public void Para_numero_retornar_por_extenso(ulong numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, Extenso.Converter(numero));
        }
    }
}
