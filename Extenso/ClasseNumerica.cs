using System.Collections.Generic;

namespace Extenso
{
    public class ClasseNumerica
    {
        private readonly string _texto;

        public ClasseNumerica(string texto)
        {
            _texto = texto;
        }

        public IEnumerable<Centena> Centenas
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public override string ToString()
        {
            return "mil";
        }
    }
}