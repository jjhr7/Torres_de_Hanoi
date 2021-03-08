using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        private int valor;

        public Disco(int valor)
        {
            Valor = valor;
        }

        public int Valor
        {
            get => valor;
            set => valor = value;
        }
  
    }
}
