using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Aeroportos
    {
        string nome;
        string cidade;
        string codigo;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }

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
    }
}
