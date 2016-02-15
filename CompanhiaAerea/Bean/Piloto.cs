using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Piloto
    {
        string nome;
        string cht;
        string dataNasc;

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

        public string Cht
        {
            get
            {
                return cht;
            }
            set
            {
                cht = value;
            }
        }

        public string DataNasc
        {
            get
            {
                return dataNasc;
            }
            set
            {
                dataNasc = value;
            }
        }
    }
}
