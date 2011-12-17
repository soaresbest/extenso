using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extenso
{
    public static class NumeroExtenso
    {
        public static string Converter(string numero)
        {
            var regex = new Regex(@"^\d+$");
            bool isMatch = regex.IsMatch(numero);
            if (!isMatch)
            {
                throw new ArgumentException(string.Format("o numero {0} não é numeral", numero), "numero");
            }

            var stringBuilder = new StringBuilder();

            numero = numero.TrimStart('0');

            Blocos blocos = FabricaBlocos.GerarBlocos(numero);

            if (numero == string.Empty)
            {
                return "zero";
            }

            if (numero == "1000")
            {
                return "mil";
            }

            foreach (Bloco bloco in blocos)
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

        private static string ColocarSeparadorDeCentena(Bloco bloco, Blocos blocos)
        {
            // - Array do bloco atual
            int indiceBloco = blocos.IndexOf(bloco);

            // - Array do bloco atual
            bool primeiroBloco = indiceBloco == 0;

            // - Array do bloco atual
            bool ultimoBloco = indiceBloco == blocos.Count - 1;

            // - Não é o primeiro bloco, então haverá separador
            bool jaEstaPreenchido = indiceBloco > 0;

            // - Tem dezena zerada: Para não separar os blocos de centena em caso de: 
            //    - 1.000.200 = "um milhão e duzentos"    // possui "e"
            //    - 1.000.201 = "um milhão duzentos e um" // não possui "e"
            bool temDezenaZerada = bloco.Centena.Dezena.ToInt() == 0;

            // - Centena menor que cem: 
            //    - "mil e setenta"  // possui "e"
            bool centenaMenorQueCem = bloco.Centena.ToInt() < 100;

            // - Todas as centenas pra frente estão zeradas, 
            //   acabou de descrever o número
            //    - "um milhão"             // "1.000.000"  pára no primeiro bloco
            //    - "um milhão e cem mil"   // "1.100.000"  pára no segundo bloco
            bool proximasCentenasZeradas = ProximasCentenasZeradas(blocos, indiceBloco);

            // - Bloco zerado é ignorado
            var blocoZerado = bloco.Centena.ToInt() == 0;
            if (blocoZerado)
            {
                return string.Empty;
            }

            // - O primeiro bloco não possui separados
            if (primeiroBloco)
            {
                return string.Empty;
            }

            // - Só possui um bloco então não precisa de separador
            var possuiApenasUmBloco = blocos.Count == 1;
            if (possuiApenasUmBloco)
            {
                return string.Empty;
            }

            // - Último bloco com valor, então o separador é "e"
            if (jaEstaPreenchido
             && (proximasCentenasZeradas || ultimoBloco))
            {
                return " e ";
            }

            // - Último bloco com valor, então o separador é "e"
            if (jaEstaPreenchido)
            {
                return ", ";
            }

            var sb = new StringBuilder();
            sb.AppendLine("Regra para SEPARADOR não encontrada!");
            sb.AppendLine(blocos.ToString());
            sb.AppendFormat("bloco atual:{0}", bloco);
            throw new Exception(sb.ToString());
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