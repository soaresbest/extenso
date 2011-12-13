using System;

namespace Extenso
{
    public class Unidade
    {
        private readonly char _algarismoUnidade;

        public Unidade(char algarismoUnidade)
        {
            _algarismoUnidade = algarismoUnidade;
        }

        public override string ToString()
        {
            switch (_algarismoUnidade)
            {
                case '0':
                    return string.Empty;
                case '1':
                    return "um";
                case '2':
                    return "dois";
                case '3':
                    return "três";
                case '4':
                    return "quatro";
                case '5':
                    return "cinco";
                case '6':
                    return "seis";
                case '7':
                    return "sete";
                case '8':
                    return "oito";
                case '9':
                    return "nove";
                default:
                    throw new Exception(string.Format("_algarismoUnidade inválido: [{0}]", _algarismoUnidade));
            }
        }
    }
}