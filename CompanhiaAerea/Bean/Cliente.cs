using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Cliente
    {
        string nome;
        string cpf;
        string cidade;

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

        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
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
    }
}
