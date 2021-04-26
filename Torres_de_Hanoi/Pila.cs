using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }


        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */
        public Pila()
        {
            Elementos = new List<Disco>();
            Size = 0;

        }

        public void push(Disco d)
        {
          
            Elementos.Add(d);
            Size++;
        }

        public Disco pop()
        {
            Disco disco = Elementos[Elementos.Count-1];
            Elementos.RemoveAt(Elementos.Count - 1);
            Size--;
            return disco;
        }                

        public bool isEmpty()
        {
            return Size == 0;
        }

        public Disco lastElement()
        {
            return Elementos[Elementos.Count - 1];
        }

        public String toString()
        {
            String res = "La torre tiene los siguientes discos: ";
            for(int i = 0; i < Elementos.Count; i++)
            {
                res += "  " + Elementos[i].Valor;
            }
            return res; 
        }
    }
}
