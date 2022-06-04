using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro2024
{
    internal class ClassFuncoesGlobais
    {
        // Estrutura de campos
        public struct RegistoEstadios
        {
            public int NumeroEstadio;
            public string NomeEstadio;
            public int Capacidade;
        }

        public static RegistoEstadios[] ArrayEstadios = new RegistoEstadios[0]; // Sem dimensão

        //  ou..
        // public static RegistoEstadios[] ArrayEstadios = Array.Empty<RegistoEstadios>();

    }

}
