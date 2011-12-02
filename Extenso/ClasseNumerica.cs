using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Extenso
{
    public class ClasseNumerica
    {
        private readonly string _texto;
        private List<Centena> _centenas;

        public ClasseNumerica(string texto)
        {
            _texto = texto;
            QuebrarCentenas(texto);
        }

        private void QuebrarCentenas(string texto)
        {
            int quantidadeCentenas = QuantidadeCentenas();
            _centenas = new List<Centena>();

            for (int i = quantidadeCentenas; i >= 1; i--)
            {
                int indiceInicial = BuscarIndiceInicialCentena(i);
                int tamanhoCentena = BuscarTamanhoCentena(i);
                var centenaTexto = texto.Substring(indiceInicial, tamanhoCentena);
                var centena = new Centena(centenaTexto);
                _centenas.Add(centena);
            }
        }

        public int BuscarTamanhoCentena(int indice)
        {
            int quociente = _texto.Length / 3;

            if (indice > quociente)
                return _texto.Length % 3;

            return 3;
        }

        public int BuscarIndiceInicialCentena(int indice)
        {
            int indiceInicial = _texto.Length - (3 * indice);

            if (indiceInicial < 0)
            {
                indiceInicial = 0;
            }

            return indiceInicial;
        }

        public IEnumerable<Centena> Centenas
        {
            get { return _centenas; }
        }

        public int QuantidadeCentenas()
        {
            int resto = _texto.Length % 3;

            int quociente = Convert.ToInt32(_texto.Length / 3);

            if (resto > 0)
                return quociente + 1;

            return quociente;
        }

        public override string ToString()
        {
            if (Centenas.Count() == 3)
            {
                if (Centenas.First().ToInt() == 1)
                    return "um milhão";
                else
                    return "dois milhões";
            }

            var primeiraCentena = Centenas.First();
            var ultimaCentena = Centenas.Last();

            if (Centenas.Count() > 1)
            {
                string primeiraCentenaRetorno;
                if (primeiraCentena.ToInt() == 1)
                {
                    primeiraCentenaRetorno = "mil";
                }
                else
                {
                    primeiraCentenaRetorno = string.Format("{0} mil", primeiraCentena);
                }

                if (ultimaCentena.ToInt() == 0)
                {

                    return primeiraCentenaRetorno;
                }

                string milharComCentena;

                if (VerificarCentenaComDezenaZerada(ultimaCentena))
                {
                    milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
                }
                else if (VerificarCentenaZerada(ultimaCentena))
                {
                    milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
                }
                else
                {
                    milharComCentena = string.Format("{0} {1}", primeiraCentenaRetorno, ultimaCentena);
                }

                return milharComCentena;
            }

            return primeiraCentena.ToString();
        }

        private bool VerificarCentenaZerada(Centena ultimaCentena)
        {
            return ultimaCentena.Algarismo_centena == '0'
                   && ultimaCentena.Dezena.ToInt() != 0;
        }

        private static bool VerificarCentenaComDezenaZerada(Centena ultimaCentena)
        {
            return ultimaCentena.Algarismo_centena != '0' 
                   && ultimaCentena.Dezena.ToInt() == 0;
        }
    }
}