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
            if (numero >= 10 && numero <= 19)
            {
                return ConverterDezenaMenorQueDezenove(numero);
            }
            if (numero >= 20 && numero <= 99)
            {
                return JuntarDezenaUnidade(numero);
            }
            if (numero >= 100 && numero <= 999)
            {
                return JuntarCentena(numero);
            }
            throw new Exception("o número " + numero + " não pôde ser tratado.");
        }

        private static string JuntarCentena(ulong numero)
        {
            string centenaConvertida = ConverterCentena(numero);
            string juntados = JuntarDezenaUnidade(numero);

            if (centenaConvertida != "" && juntados != "")
            {
                return string.Format("{0} e {1}", centenaConvertida, juntados);
            }
            if (centenaConvertida != "" && juntados == "")
            {
                return centenaConvertida;
            }
            if (centenaConvertida == "" && juntados == "")
            {
                return "";
            }

            throw new Exception("erro");
        }

        private static string JuntarDezenaUnidade(ulong numero)
        {
            string unidadeConvertida = ConverterUnidade(numero);
            string dezenaConvertida = ConverterDezena(numero);
            
            if (dezenaConvertida != "" && unidadeConvertida != "")
            {
                return string.Format("{0} e {1}", dezenaConvertida, unidadeConvertida);
            }
            if (dezenaConvertida == "" && unidadeConvertida != "")
            {
                return unidadeConvertida;
            }
            if (dezenaConvertida != "" && unidadeConvertida == "")
            {
                return dezenaConvertida;
            }
            if (dezenaConvertida == "" && unidadeConvertida == "")
            {
                return "";
            }
            throw new Exception("erro");
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
            if (numero <= 19)
                return ConverterDezenaMenorQueDezenove(numero);
            else
                return ConverterDezenaMaiorQueDezenove(numero);
        }


        private static string ConverterDezenaMaiorQueDezenove(ulong numero)
        {
            var texto = numero.ToString();

            var dezena = texto[texto.Length - 2];

            switch (dezena)
            {
                case '0':
                    return "";
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
                            "a dezena {0} do número {1} não está no intervalo [2-9] ou [0].",
                            dezena,
                            numero));
                }
            }
        }

        private static string ConverterCentena(ulong numero)
        {
            if (numero == 100)
                return "cem";
            
            var texto = numero.ToString();
            var centena = texto[texto.Length - 3];
            switch (centena)
            {
                case '0':
                    return "";
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

            throw new Exception("bizarro!");
        }

        private static string ConverterDezenaMenorQueDezenove(ulong numero)
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
}
