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

            for (int i = 1; i <= quantidadeCentenas; i++)
            {
                int indiceInicial = BuscarIndiceInicialCentena(i);
                int tamanhoCentena = BuscarTamanhoCentena(i);
            }
        }

        public int BuscarTamanhoCentena(int i)
        {
            throw new NotImplementedException();
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
            return "mil";
        }
    }
}