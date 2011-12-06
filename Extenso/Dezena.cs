using System;

namespace Extenso
{
    public class Dezena
    {
        private char _algarismoDezena;
        private char _algarismoUnidade;

        private Unidade Unidade { get; set; }

        public string DezenaUnidade
        {
            get { return (string.Concat(_algarismoDezena,_algarismoUnidade)); }
        }

        public int ToInt()
        {
            return int.Parse(DezenaUnidade);
        }

        public Dezena(char algarismoDezena, char algarismoUnidade)
        {
            Inicializar(algarismoDezena, algarismoUnidade);
        }

        private void Inicializar(char algarismoDezena, char algarismoUnidade)
        {
            Unidade = new Unidade(algarismoUnidade);

            _algarismoDezena = algarismoDezena;
            _algarismoUnidade = algarismoUnidade;
        }

        public override string ToString()
        {
            int numero = ToInt();

            if (numero < 10)
            {
                return Unidade.ToString();
            }
            if (numero >= 10 && numero <= 19)
            {
                return DezDezenove();
            }
            else
            {
                string vintePraCima = NomeDezena();

                string unidadeNome = Unidade.ToString();

                if (unidadeNome == "zero")
                {
                    return vintePraCima;
                }
                else
                {
                    return vintePraCima + " e " + unidadeNome;
                }
            }
        }

        private string NomeDezena()
        {
            switch (_algarismoDezena)
            {
                case '2':
                    return "vinte";
                case '3':
                    return "trinta";
                case '4':
                    return "quarenta";
                case '5':
                    return "cinquenta";
                case '6':
                    return "sessenta";
                case '7':
                    return "setenta";
                case '8':
                    return "oitenta";
                case '9':
                    return "noventa";
                default:
                    throw new Exception(string.Format("_algarismoDezena inválido: [{0}]", _algarismoDezena));
            }
        }

        private string DezDezenove()
        {
            switch (DezenaUnidade)
            {
                case "10":
                    return "dez";
                case "11":
                    return "onze";
                case "12":
                    return "doze";
                case "13":
                    return "treze";
                case "14":
                    return "quatorze";
                case "15":
                    return "quinze";
                case "16":
                    return "dezesseis";
                case "17":
                    return "dezessete";
                case "18":
                    return "dezoito";
                case "19":
                    return "dezenove";
                default:
                    throw new Exception(string.Format("DezenaUnidade inválida: [{0}]", DezenaUnidade));
            }
        }

        public override bool Equals(object obj)
        {
            var dezena = (Dezena)obj;

            return dezena.DezenaUnidade == DezenaUnidade;
        }
    }
}