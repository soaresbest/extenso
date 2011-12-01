using NUnit.Framework;

namespace Extenso.Teste
{
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