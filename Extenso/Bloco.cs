namespace Extenso
{
    public class Bloco
    {
        public int Ordem { get; set; }
        public Centena Centena { get; set; }

        public Bloco(Centena centena, int ordem)
        {
            Centena = centena;
            Ordem = ordem;
        }
    }
}