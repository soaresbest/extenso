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
}
