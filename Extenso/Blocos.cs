using System.Collections.Generic;
using System.Text;

namespace Extenso
{
    public class Blocos : List<Bloco>
    {
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                var bloco = this[i];
                sb.Append(bloco.Centena.Algarismo_centena);
                sb.Append(bloco.Centena.Dezena.DezenaUnidade);
                if (i < this.Count - 1)
                {
                    sb.Append(".");
                }
            }
            return sb.ToString();
        }
    }
}