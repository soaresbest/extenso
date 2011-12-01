using System;

namespace Extenso
{
    public class Centena
    {
        private readonly char _algarismoCentena;
        private readonly char _algarismoDezena;
        private readonly char _algarismoUnidade;

        public Dezena Dezena { get; set; }

        public Centena(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
            _algarismoCentena = algarismoCentena;
            _algarismoDezena = algarismoDezena;
            _algarismoUnidade = algarismoUnidade;
        }

        private string CentenaDezena
        {
            get { return (string.Concat(_algarismoCentena, _algarismoDezena, _algarismoUnidade)); }
        }

        public int ToInt()
        {
            return int.Parse(CentenaDezena);
        }

        public override string ToString()
        {
            Dezena dezena = new Dezena(_algarismoDezena, _algarismoUnidade);

            if (CentenaDezena == "100")
                return "cem";

            string nomeCentena = NomeCentena();

            if (string.IsNullOrEmpty(nomeCentena))
            {
                return dezena.ToString();
            }

            if (dezena.ToString() == "zero")
            {
                return nomeCentena;
            }

            return nomeCentena + " e " + dezena;
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