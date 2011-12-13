using System;

namespace Extenso
{
    public static class ClasseNumerica
    {
        public static string SufixoDe(Bloco bloco)
        {
            int centenaNum = bloco.Centena.ToInt();

            if (centenaNum == 0)
            {
                return string.Empty;
            }

            bool plural = centenaNum > 1;

            switch (bloco.Ordem)
            {
                case 1:
                    return string.Empty;
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
                case 5:
                    if (plural)
                        return "trilhões";
                    return "trilhão";

                case 6:
                    if (plural)
                        return "quatrilhões";
                    return "quatrilhão";

                case 7:
                    if (plural)
                        return "quintilhões";
                    return "quintilhão";

                case 8:
                    if (plural)
                        return "sextilhões";
                    return "sextilhão";

                case 9:
                    if (plural)
                        return "septilhões";
                    return "septilhão";

                case 10:
                    if (plural)
                        return "octilhões";
                    return "octilhão";

                case 11:
                    if (plural)
                        return "nonilhões";
                    return "nonilhão";

                case 12:
                    if (plural)
                        return "decilhões";
                    return "decilhão";

                case 13:
                    if (plural)
                        return "undecilhões";
                    return "undecilhão";

                case 14:
                    if (plural)
                        return "doudecilhões";
                    return "doudecilhão";

                case 15:
                    if (plural)
                        return "tredecilhões";
                    return "tredecilhão";
                default:
                    throw new Exception(string.Format("classe númerica não suportada: {0}", bloco.Ordem));
            }
        }

        //private readonly string _texto;
        //private List<Centena> _centenas;
        //public List<Bloco> Blocos;

        //public ClasseNumerica(string texto)
        //{
        //    _texto = texto;
        //}


        //public IEnumerable<Centena> Centenas
        //{
        //    get { return _centenas; }
        //}

        //public override string ToString()
        //{
        //    var centena = Centenas.First();
        //    if (Centenas.Count() == 3)
        //    {
        //        if (centena.ToInt() == 1)
        //            return "um milhão";

        //        return centena + " milhões";
        //    }

        //    var primeiraCentena = centena;
        //    var ultimaCentena = Centenas.Last();

        //    if (Centenas.Count() > 1)
        //    {
        //        return JuntaDuasCentenas(primeiraCentena, ultimaCentena);
        //    }

        //    return primeiraCentena.ToString();
        //}

        //private string JuntaDuasCentenas(Centena primeiraCentena, Centena ultimaCentena)
        //{
        //    string primeiraCentenaRetorno;

        //    if (primeiraCentena.ToInt() == 1)
        //    {
        //        primeiraCentenaRetorno = "mil";
        //    }
        //    else
        //    {
        //        primeiraCentenaRetorno = string.Format("{0} mil", primeiraCentena);
        //    }

        //    if (ultimaCentena.ToInt() == 0)
        //    {
        //        return primeiraCentenaRetorno;
        //    }

        //    string milharComCentena;

        //    if (VerificarCentenaComDezenaZerada(ultimaCentena))
        //    {
        //        milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }
        //    else if (VerificarCentenaZerada(ultimaCentena))
        //    {
        //        milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }
        //    else
        //    {
        //        milharComCentena = string.Format("{0} {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }

        //    return milharComCentena;
        //}

        //private bool VerificarCentenaZerada(Centena ultimaCentena)
        //{
        //    return ultimaCentena.Algarismo_centena == '0'
        //           && ultimaCentena.Dezena.ToInt() != 0;
        //}

        //private static bool VerificarCentenaComDezenaZerada(Centena ultimaCentena)
        //{
        //    return ultimaCentena.Algarismo_centena != '0'
        //        && ultimaCentena.Dezena.ToInt() == 0;
        //}

        //public string OrdemPorExtenso(int ordem)
        //{
        //    Bloco bloco = ObterBlocoPorOrdem(ordem);
        //    return bloco.SufixoPorExtenso();
        //}

        //private Bloco ObterBlocoPorOrdem(int ordem)
        //{
        //    return Blocos.FirstOrDefault(b => b.Ordem == ordem);
        //}
    }
}