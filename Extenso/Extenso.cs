namespace Extenso
{
    public class Extenso
    {
        const string dois = "dois";
        const string um = "um";
        const string vinte = "vinte";

        public static string Converter(ulong numero)
        {
            switch (numero)
            {
                case 1:
                    return um;
                case 2:
                    return "dois";
                case 3:
                    return "três";
                case 4:
                    return "quatro";
                case 5:
                    return "cinco";
                case 6:
                    return "seis";
                case 7:
                    return "sete";
                case 8:
                    return "oito";
                case 9:
                    return "nove";
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
                case 20:
                    return vinte;
                case 21:
                    return vinte + " e " + um;
                case 22:
                    return vinte + " e " + dois;
                default:
                    return "";
            }
        }
    }
}
