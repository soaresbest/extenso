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

                stringBuilder.Append(ColocarSeparadorDeCentena(bloco, blocos));
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

        private static string ColocarSeparadorDeCentena(Bloco bloco, List<Bloco> blocos)
        {
            int indexOf = blocos.IndexOf(bloco);
            bool jaEstaPreenchido = indexOf > 0;

            var proximasCentenasZeradas = ProximasCentenasZeradas(blocos, indexOf);

            if (proximasCentenasZeradas && jaEstaPreenchido)
            {
                return " e ";
            }

            bool temDezenaZerada = bloco.Centena.Dezena.ToInt() == 0;

            bool centenaMenorQueCem = bloco.Centena.ToInt() < 100;

            if (jaEstaPreenchido && (temDezenaZerada || centenaMenorQueCem))
            {
                return " e ";
            }

            return " ";
        }

        private static bool ProximasCentenasZeradas(List<Bloco> blocos, int indexOf)
        {
            int somaCentenas = 0;

            for (int i = indexOf + 1; i < blocos.Count; i++)
            {
                somaCentenas += blocos[i].Centena.ToInt();
            }

            return somaCentenas == 0;
        }
    }
}
