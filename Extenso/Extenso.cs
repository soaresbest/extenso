using System;

namespace Extenso
{
    public static class Extenso
    {
        public static string Converter(ulong numero)
        {
            if (numero <= 9)
            {
                return ConverterUnidade(numero);
            }
            if (numero <= 19)
            {
                return ConverterDeDezAtehDezenove(numero);
            }
            if (numero >= 20 && numero <= 99)
            {
                string dezena = ConverterDezena(numero);
                string unidade = ConverterUnidade(numero);

                if (!string.IsNullOrEmpty(unidade))
                    return string.Format("{0} e {1}", dezena, unidade);

                return dezena;
            }
            throw new Exception("o número " + numero + " não pôde ser tratado.");
        }

        private static string ConverterUnidade(ulong numero)
        {
            var texto = numero.ToString();

            var unidade = texto[texto.Length - 1];

            switch (unidade)
            {
                case '0':
                {
                    if (numero > 9)
                        return "";

                    return "zero";
                }
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
                {
                    throw new Exception(
                    string.Format(
                        "a unidade {0} do número {1} não está no intervalo [0-9].",
                        unidade,
                        numero));
                }
            }
        }

        private static string ConverterDezena(ulong numero)
        {
            var texto = numero.ToString();

            var dezena = texto[texto.Length - 2];

            switch (dezena)
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
                {
                    throw new Exception(
                        string.Format(
                            "a dezena {0} do número {1} não está no intervalo [2-9].",
                            dezena,
                            numero));
                }
            }
        }

        private static string ConverterDeDezAtehDezenove(ulong numero)
        {
            switch (numero)
            {
                case 10:
                    return "dez";
                case 11:
                    return "onze";
                case 12:
                    return "doze";
                case 13:
                    return "treze";
                case 14:
                    return "quatorze";
                case 15:
                    return "quinze";
                case 16:
                    return "dezesseis";
                case 17:
                    return "dezessete";
                case 18:
                    return "dezoito";
                case 19:
                    return "dezenove";
                default:
                {
                    throw new Exception(
                        string.Format(
                            "o número {0} não está no intervalo [10-19].",
                            numero));
                }
            }
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
        public Dezena(char algarismoDezena, char algarismoUnidade)
        {
        }

        public Unidade Unidade { get; set; }
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
