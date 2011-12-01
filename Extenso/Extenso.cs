namespace Extenso
{
    public static class Extenso
    {
        public static string Converter(ulong numero)
        {
            string numeroTexto = numero.ToString();
            var centena = new Centena(numeroTexto);
            return centena.ToString();
        }
    }
}
