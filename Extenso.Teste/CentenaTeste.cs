using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class CentenaTeste
    {
        [Test]
        public void ToInt_retorna_a_centena_numericamente()
        {
            var centena = new Centena('4', '7', '1');
            Assert.AreEqual(471, centena.ToInt());
        }

        [TestCase('1', '0', '0', "cem")]
        [TestCase('1', '0', '1', "cento e um")]
        [TestCase('1', '1', '1', "cento e onze")]
        [TestCase('2', '0', '0', "duzentos")]
        [TestCase('9', '9', '9', "novecentos e noventa e nove")]
        public void ToString_retorna_por_extenso_para_cada_algarismo(char algarismoCentena, char algarismoDezena, char algarismoUnidade, string resultadoEsperado)
        {
            var centena = new Centena(algarismoCentena, algarismoDezena, algarismoUnidade);
            Assert.AreEqual(resultadoEsperado, centena.ToString());
        }
    }
}