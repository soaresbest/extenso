using System;
using System.Collections.Generic;

namespace Extenso
{
    public static class FabricaBlocos
    {
        public static List<Bloco> GerarBlocos(string numeroTexto)
        {
            List<Centena> centenas = QuebrarCentenas(numeroTexto);

            var blocos = new List<Bloco>();

            for (int i = 0; i < centenas.Count; i++)
            {
                int ordem = centenas.Count - i;
                var bloco = new Bloco(centenas[i], ordem);

                blocos.Add(bloco);
            }

            return blocos;
        }

        private static List<Centena> QuebrarCentenas(string texto)
        {
            int quantidadeCentenas = QuantidadeCentenas(texto);

            var centenas = new List<Centena>();

            for (int i = quantidadeCentenas; i >= 1; i--)
            {
                int indiceInicial = BuscarIndiceInicialCentena(i, texto);
                int tamanhoCentena = BuscarTamanhoCentena(i, texto);

                string centenaTexto = texto.Substring(indiceInicial, tamanhoCentena);
                var centena = new Centena(centenaTexto);

                centenas.Add(centena);
            }

            return centenas;
        }

        private static int QuantidadeCentenas(string texto)
        {
            int resto = texto.Length%3;

            int quociente = Convert.ToInt32(texto.Length/3);

            if (resto > 0)
                return quociente + 1;

            return quociente;
        }

        private static int BuscarTamanhoCentena(int indice, string texto)
        {
            int quociente = texto.Length/3;

            if (indice > quociente)
                return texto.Length%3;

            return 3;
        }

        private static int BuscarIndiceInicialCentena(int indice, string texto)
        {
            int indiceInicial = texto.Length - (3*indice);

            if (indiceInicial < 0)
            {
                indiceInicial = 0;
            }

            return indiceInicial;
        }
    }
}