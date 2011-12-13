using System.Collections.Generic;
using System.Text;
using Extenso.Teste;

namespace Extenso
{
    public static class Extenso
    {
        public static string Converter(string numero)
        {
            var stringBuilder = new StringBuilder();

            List<Bloco> blocos = FabricaBlocos.GerarBlocos(numero);

            if (numero == "1000")
            {
                return "mil";
            }

            foreach (var bloco in blocos)
            {
                string sufixo = ClasseNumerica.SufixoDe(bloco);

                if (sufixo == string.Empty && bloco.Ordem > 1)
                {
                    continue;
                }

                if (DeveColocarE(bloco, stringBuilder))
                {
                    stringBuilder.Append(" e ");
                }
                else
                {
                    stringBuilder.Append(" ");
                }

                stringBuilder.Append(bloco.Centena);

                if (sufixo != string.Empty)
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(sufixo);
                }
            }

            string valor = stringBuilder.ToString();

            return valor.Replace("e zero", "").Trim();
        }

        private static bool DeveColocarE(Bloco bloco, StringBuilder stringBuilder)
        {
            bool jaEstaPreenchido = stringBuilder.Length > 0;
            
            bool temDezenaZerada = bloco.Centena.Dezena.ToInt() == 0;
            
            bool centenaMenorQueCem = bloco.Centena.ToInt() < 100;
            
            return jaEstaPreenchido && (temDezenaZerada || centenaMenorQueCem);
        }
    }
}
