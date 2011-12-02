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

        [TestCase("321321321321321321321321321321", 10)]
        [TestCase("3325644748", 4)]
        [TestCase("332564378", 3)]
        [TestCase("33256478", 3)]
        [TestCase("4256478", 3)]
        [TestCase("566478", 2)]
        [TestCase("64778", 2)]
        [TestCase("64", 1)]
        [TestCase("", 0)]
        public void deve_retorna_quantidade_de_centenas_para_numeros_grandes(string numero, int quantidadeEsperada)
        {
            var milhar = new ClasseNumerica(numero);
            Assert.AreEqual(quantidadeEsperada, milhar.QuantidadeCentenas());
        }

        [TestCase(17, "12345678901234567890", 1)]
        [TestCase(2, "12345678901234567890", 6)]
        [TestCase(0, "12345678901234567890", 7)]
        public void deve_retornar_o_indice_inicial_da_centena(int indiceEsperado, string texto, int indiceInicial)
        {
            var milhar = new ClasseNumerica(texto);
            Assert.AreEqual(indiceEsperado, milhar.BuscarIndiceInicialCentena(indiceInicial));
        }

        [TestCase(3, "12345678901234567890", 1)]
        [TestCase(3, "12345678901234567890", 6)]
        [TestCase(2, "12345678901234567890", 7)]
        public void deve_retornar_o_tamanho_da_centena(int tamanhoEsperado, string texto, int indiceInicial)
        {
            var milhar = new ClasseNumerica(texto);
            Assert.AreEqual(tamanhoEsperado, milhar.BuscarTamanhoCentena(indiceInicial));
        }

        [Test]
        public void ultima_centena_vale_214_para_5447845214()
        {
            var milhar = new ClasseNumerica("5447845214");
            Assert.AreEqual(214, milhar.Centenas.Last().ToInt());
        }

        [Test]
        public void penultima_centena_vale_845_para_5447845214()
        {
            var milhar = new ClasseNumerica("5447845214");
            int index = milhar.Centenas.Count() - 2;
            Assert.AreEqual(845, milhar.Centenas.ElementAt(index).ToInt());
        }

        [Test]
        public void primeira_centena_vale_5_para_5447845214()
        {
            var milhar = new ClasseNumerica("5447845214");
            Assert.AreEqual(5, milhar.Centenas.First().ToInt());
        }

        [TestCase("um", "1")]
        [TestCase("novecentos e noventa e nove", "999")]
        [TestCase("mil", "1000")]
        [TestCase("mil e um", "1001")]
        [TestCase("mil e cem", "1100")]
        [TestCase("mil cento e um", "1101")]
        [TestCase("duzentos mil duzentos e um", "200201")]
        [TestCase("cem mil e um", "100001")]
        [TestCase("um milhão", "1000000")]
        [TestCase("dois milhões", "2000000")]
        [TestCase("novecentos milhões", "900000000")]
        public void deve_retornar_extenso_para_entrada_numerica(string esperado, string numeroPassado)
        {
            var classeNumerica = new ClasseNumerica(numeroPassado);
            Assert.AreEqual(esperado, classeNumerica.ToString());
        }

        [Test]
        public void toString_da_dezena_da_centena_deve_retornar_1()
        {
            var classeNumerica = new ClasseNumerica("1001");
            Assert.AreEqual(1, classeNumerica.Centenas.Last().ToInt());
        }

        [Test]
        public void ordem_do_primeiro_bloco_vale_1()
        {
            var classeNumerica = new ClasseNumerica("100");
            Assert.AreEqual(1, classeNumerica.Blocos.First().Ordem);
        }

        [Test]
        public void ordem_do_segundo_bloco_vale_2()
        {
            var classeNumerica = new ClasseNumerica("100100");
            Assert.AreEqual(2, classeNumerica.Blocos[1].Ordem);
        }
    }
}