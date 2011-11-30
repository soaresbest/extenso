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
        [TestCase((ulong)10, "dez")]
        [TestCase((ulong)11, "onze")]
        [TestCase((ulong)12, "doze")]
        [TestCase((ulong)13, "treze")]
        [TestCase((ulong)14, "quatorze")]
        [TestCase((ulong)15, "quinze")]
        [TestCase((ulong)16, "dezesseis")]
        [TestCase((ulong)17, "dezessete")]
        [TestCase((ulong)18, "dezoito")]
        [TestCase((ulong)19, "dezenove")]
        [TestCase((ulong)20, "vinte")]
        [TestCase((ulong)21, "vinte e um")]
        [TestCase((ulong)29, "vinte e nove")]
        [TestCase((ulong)30, "trinta")]
        [TestCase((ulong)39, "trinta e nove")]
        [TestCase((ulong)80, "oitenta")]
        [TestCase((ulong)99, "noventa e nove")]
        [TestCase((ulong)100, "cem")]
        [TestCase((ulong)101, "cento e um")]
        [TestCase((ulong)151, "cento e cinquenta e um")]
        [TestCase((ulong)200, "duzentos")]
        [TestCase((ulong)1000, "mil")]
        [TestCase((ulong)1001, "mil e um")]
        [TestCase((ulong)1010, "mil e dez")]
        [TestCase((ulong)1100, "mil e cem")]
        [TestCase((ulong)1111, "mil e cento e onze")]
        [TestCase((ulong)9999, "nove mil novecentos e noventa e nove")]
        public void Para_numero_retornar_por_extenso(ulong numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, Extenso.Converter(numero));
        }
    }
}
