using System;
using System.Collections.Generic;

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
            var numero = ulong.Parse(_texto);
            if (numero < 1000)
                return new Centena(_texto).ToString();

            return "mil";
        }
    }
}