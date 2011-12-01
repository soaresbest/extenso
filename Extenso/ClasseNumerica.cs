using System.Collections.Generic;

namespace Extenso
{
    public class ClasseNumerica
    {
        private readonly string _texto;
        private List<Centena> _centenas;

        public ClasseNumerica(string texto)
        {
            _texto = texto;
        }

        public IEnumerable<Centena> Centenas
        {
            get 
            {
                _centenas = Centenas3();
                return _centenas;
            }
        }

        private static List<Centena> Centenas3()
        {
            var centenas = new List<Centena>();
            centenas.Add(new Centena("111"));
            centenas.Add(new Centena("111"));
            centenas.Add(new Centena("111"));
            return centenas;
        }

        public override string ToString()
        {
            return "mil";
        }
    }
}