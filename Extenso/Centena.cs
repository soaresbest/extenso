namespace Extenso
{
    public class Centena
    {
        private readonly char _algarismoCentena;
        private readonly char _algarismoDezena;
        private readonly char _algarismoUnidade;

        public Dezena Dezena { get; set; }

        public Centena(char algarismoCentena, char algarismoDezena, char algarismoUnidade)
        {
            _algarismoCentena = algarismoCentena;
            _algarismoDezena = algarismoDezena;
            _algarismoUnidade = algarismoUnidade;
        }

        private string CentenaDezena
        {
            get { return (string.Concat(_algarismoCentena, _algarismoDezena, _algarismoUnidade)); }
        }

        public int ToInt()
        {
            return int.Parse(CentenaDezena);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}