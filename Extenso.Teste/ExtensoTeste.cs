using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class ExtensoTeste
    {
        [TestCase((ulong)1, "um")]
        [TestCase((ulong)2, "dois")]
        [TestCase((ulong)3, "três")]
        [TestCase((ulong)4, "quatro")]
        [TestCase((ulong)5, "cinco")]
        [TestCase((ulong)6, "seis")]
        [TestCase((ulong)7, "sete")]
        [TestCase((ulong)8, "oito")]
        [TestCase((ulong)9, "nove")]
        public void Para_unidade_retornar_por_extenso(ulong numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, Extenso.Converter(numero));
        }
    }
}
