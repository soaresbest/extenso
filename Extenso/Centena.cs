using System;

namespace Extenso
{
    public class Centena
    {
        private char _algarismoCentena;
        private Dezena Dezena { get; set; }

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

        private void Inicializar(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
            _algarismoCentena = algarismoCentena;
            Dezena = new Dezena(algarismoDezena, algarismoUnidade);
        }

        private string CentenaDezena
        {
            get { return (string.Concat(_algarismoCentena, Dezena.DezenaUnidade)); }
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

            if (Dezena.ToString() == "zero")
            {
                return nomeCentena;
            }

            return nomeCentena + " e " + Dezena;
        }

        private string NomeCentena()
        {
            switch (_algarismoCentena)
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
    }
}