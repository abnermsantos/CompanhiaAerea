using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Reservas
    {
        string voo;
        string assento;
        string cpf_cliente;

        public string Voo
        {
            get
            {
                return voo;
            }
            set
            {
                voo = value;
            }
        }

        public string Assento
        {
            get
            {
                return assento;
            }
            set
            {
                assento = value;
            }
        }

        public string Cpf_cliente
        {
            get
            {
                return cpf_cliente;
            }
            set
            {
                cpf_cliente = value;
            }
        }
    }
}
