using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanhiaAerea.Bean
{
    class Aviao
    {
        string numeroSerie;
        string modelo;

        public string NumeroSerie
        {
            get
            {
                return numeroSerie;
            }
            set
            {
                numeroSerie = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
    }
}
