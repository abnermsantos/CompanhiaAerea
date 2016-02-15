using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Voos
    {
        string codigo;
        string data;
        string origem;
        string destino;

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public string Origem
        {
            get
            {
                return origem;
            }
            set
            {
                origem = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }
    }
}
