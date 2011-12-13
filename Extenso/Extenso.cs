using System.Collections.Generic;
using System.Text;

namespace Extenso
{
    public static class Extenso
    {
        public static string Converter(string numero)
        {
            var stringBuilder = new StringBuilder();

            numero = numero.TrimStart('0');

            List<Bloco> blocos = FabricaBlocos.GerarBlocos(numero);

            if (numero == string.Empty)
            {
                return "zero";
            }

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

            return stringBuilder.ToString();
        }

        private static string ColocarSeparadorDeCentena(Bloco bloco, List<Bloco> blocos)
        {
            int indexOf = blocos.IndexOf(bloco);
            bool jaEstaPreenchido = indexOf > 0;

            var proximasCentenasZeradas = ProximasCentenasZeradas(blocos, indexOf);

            if (bloco.Centena.ToInt() == 0)
            {
                return string.Empty;
            }

            if (proximasCentenasZeradas && jaEstaPreenchido)
            {
                return " e ";
            }

            bool temDezenaZerada = bloco.Centena.Dezena.ToInt() == 0;

            bool centenaMenorQueCem = bloco.Centena.ToInt() < 100;

            if (jaEstaPreenchido && (temDezenaZerada || centenaMenorQueCem))
            {
                return ", ";
            }

            return string.Empty;
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
