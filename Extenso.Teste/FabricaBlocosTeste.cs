using System.Collections.Generic;
using NUnit.Framework;

namespace Extenso.Teste
{
    [TestFixture]
    public class FabricaBlocosTeste
    {
        [Test]
        public void Fabrica_de_blocos_separa_os_blocos()
        {
            List<Bloco> blocos = FabricaBlocos.GerarBlocos("1010");

            var blocoEsperado = new Bloco(new Centena("1"), 2);

            Assert.AreEqual(blocoEsperado, blocos[0]);
        }
    }
}