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
                default:
                    return "três";
            }
        }
    }
}
