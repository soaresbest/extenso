namespace Extenso
{
    public class Extenso
    {
        public static string Converter(ulong numero)
        {
            switch (numero)
            {
                case 1:
                    return "um";
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
                default:
                    return "dez";
            }
        }
    }
}
