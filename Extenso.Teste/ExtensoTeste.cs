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
        [TestCase((ulong)99, "noventa e nove")]
        [TestCase((ulong)100, "cem")]
        public void Para_numero_retornar_por_extenso(ulong numero, string respostaEsperada)
        {
            Assert.AreEqual(respostaEsperada, Extenso.Converter(numero));
        }
    }

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

    [TestFixture]
    public class DezenaTeste
    {
        [TestCase('1', '0', "dez")]
        [TestCase('1', '1', "onze")]
        [TestCase('1', '2', "doze")]
        [TestCase('1', '3', "treze")]
        [TestCase('1', '4', "quatorze")]
        [TestCase('1', '5', "quinze")]
        [TestCase('1', '6', "dezesseis")]
        [TestCase('1', '7', "dezessete")]
        [TestCase('1', '8', "dezoito")]
        [TestCase('1', '9', "dezenove")]
        [TestCase('2', '0', "vinte")]
        [TestCase('2', '1', "vinte e um")]
        [TestCase('2', '9', "vinte e nove")]
        [TestCase('3', '0', "trinta")]
        [TestCase('9', '9', "noventa e nove")]
        public void ToString_retorna_por_extenso_para_cada_algarismo(char algarismoDezena, char algarismoUnidade, string resultadoEsperado)
        {
            var dezena = new Dezena(algarismoDezena, algarismoUnidade);
            Assert.AreEqual(resultadoEsperado, dezena.ToString());
        }

        [Test]
        public void ToInt_retorna_a_dezena_numericamente()
        {
            var dezena = new Dezena('4', '7');
            Assert.AreEqual(47, dezena.ToInt());
        }
    }
}
