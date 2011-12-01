using System;

namespace Extenso
{
    public static class Extenso
    {
        public static string Converter(ulong numero)
        {
            string numeroTexto = numero.ToString();
            var dezena = new Dezena(numeroTexto);
            return dezena.ToString();
        }
    }

    public class Centena
    {
        public Centena(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
        }

        public Dezena Dezena { get; set; }
    }

    public class Dezena
    {
        public Unidade Unidade { get; set; }
        public char AlgarismoDezena { get; private set; }
        public char AlgarismoUnidade { get; private set; }

        private string DezenaUnidade
        {
            get { return (string.Concat(AlgarismoDezena,AlgarismoUnidade)); }
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

            AlgarismoDezena = algarismoDezena;
            AlgarismoUnidade = algarismoUnidade;
        }

        public Dezena(string texto)
        {
            char dezena='0';
            char unidade;

            if (texto.Length == 2)
            {
                dezena = texto[0];
                unidade = texto[1];
                Inicializar(dezena, unidade);
            }
            else
            {
                unidade = texto[0];
                Inicializar(dezena, unidade);
            }
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
                string vintePraCima = VintePraCima();

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

        private string VintePraCima()
        {
            switch (AlgarismoDezena)
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
                    throw new Exception(string.Format("AlgarismoDezena inválido: [{0}]", AlgarismoDezena));
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
    }

    public class Unidade
    {
        public char AlgarismoUnidade { get; set; }

        public Unidade(char algarismoUnidade)
        {
            AlgarismoUnidade = algarismoUnidade;
        }

        public override string ToString()
        {
            switch (AlgarismoUnidade)
            {
                case '0':
                    return "zero";
                case '1':
                    return "um";
                case '2':
                    return "dois";
                case '3':
                    return "três";
                case '4':
                    return "quatro";
                case '5':
                    return "cinco";
                case '6':
                    return "seis";
                case '7':
                    return "sete";
                case '8':
                    return "oito";
                case '9':
                    return "nove";
                default:
                    throw new Exception(string.Format("AlgarismoUnidade inválido: [{0}]", AlgarismoUnidade));
            }
        }
    }
}
