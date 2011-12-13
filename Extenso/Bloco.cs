namespace Extenso
{
    public class Bloco
    {
        public int Ordem { get; private set; }
        public Centena Centena { get; set; }

        public Bloco(Centena centena, int ordem)
        {
            Centena = centena;
            Ordem = ordem;
        }

        public override bool Equals(object obj)
        {
            var bloco = (Bloco)obj;

            return bloco.Centena == Centena &&
                   bloco.Ordem == Ordem;
        }

        public static bool operator ==(Bloco left, Bloco right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Bloco left, Bloco right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return string.Format("Centena: {0}; Ordem: {1}", Centena.ToInt(), Ordem);
        }
    }
}