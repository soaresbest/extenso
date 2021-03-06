using System;

namespace Extenso
{
    public class Centena
    {
        private char _algarismoCentena;

        public Centena(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
            Inicializar(algarismoCentena, algarismoDezena, algarismoUnidade);
        }

        public Centena(string texto)
        {
            char centena = '0';
            char dezena = '0';
            char unidade = '0';

            if (texto.Length == 3)
            {
                centena = texto[0];
                dezena = texto[1];
                unidade = texto[2];
            }
            if (texto.Length == 2)
            {
                dezena = texto[0];
                unidade = texto[1];
            }
            if (texto.Length == 1)
            {
                unidade = texto[0];
            }

            Inicializar(centena, dezena, unidade);
        }

        internal Dezena Dezena { get; set; }

        private string CentenaDezena
        {
            get { return (string.Concat(Algarismo_centena, Dezena.DezenaUnidade)); }
        }

        public char Algarismo_centena
        {
            get { return _algarismoCentena; }
        }

        private void Inicializar(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
            _algarismoCentena = algarismoCentena;
            Dezena = new Dezena(algarismoDezena, algarismoUnidade);
        }

        public int ToInt()
        {
            return int.Parse(CentenaDezena);
        }

        public override string ToString()
        {
            if (CentenaDezena == "100")
                return "cem";

            string nomeCentena = NomeCentena();

            if (string.IsNullOrEmpty(nomeCentena))
            {
                return Dezena.ToString();
            }

            if (Dezena.ToString() == string.Empty)
            {
                return nomeCentena;
            }

            return nomeCentena + " e " + Dezena;
        }

        private string NomeCentena()
        {
            switch (Algarismo_centena)
            {
                case '0':
                    return string.Empty;
                case '1':
                    return "cento";
                case '2':
                    return "duzentos";
                case '3':
                    return "trezentos";
                case '4':
                    return "quatrocentos";
                case '5':
                    return "quinhentos";
                case '6':
                    return "seiscentos";
                case '7':
                    return "setecentos";
                case '8':
                    return "oitocentos";
                case '9':
                    return "novecentos";
            }

            throw new Exception("BIZARRO !!");
        }

        public override bool Equals(object obj)
        {
            var centena = (Centena) obj;

            return centena.Algarismo_centena == Algarismo_centena &&
                   centena.Dezena == Dezena;
        }

        public static bool operator ==(Centena left, Centena right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Centena left, Centena right)
        {
            return !Equals(left, right);
        }
    }
}