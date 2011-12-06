using System.Diagnostics;

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

        public string SufixoPorExtenso()
        {
            var centenaNum = Centena.ToInt();
            if(centenaNum == 0)
            {
                return string.Empty;
            }

            Debug.WriteLine(centenaNum);
            var plural = centenaNum > 1;
            Debug.WriteLine(plural);

            switch (Ordem)
            {
                case 2:
                    return "mil";
                case 3:
                    if (plural)
                        return "milhões";
                    return "milhão";
                case 4:
                    if (plural)
                        return "bilhões";
                    return "bilhão";
            }
            return string.Empty;
        }
    }
}