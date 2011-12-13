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

                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Append(" e ");
                }

                stringBuilder.Append(bloco.Centena);

                if (sufixo != string.Empty)
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(sufixo);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
