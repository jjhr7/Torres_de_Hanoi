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
        //Representa la cantidad de discos que hay en la pila
        private int size;
        //Representa el disco que está en la parte superior del pila
        private string top;
        //Representa el conjunto de discos que hay en la pila
        private List<Disco> elementos;
        
        //Constructor parametrizado
        public Pila(int size, string top)
        {
            Size = size;
            Top = top;
            Elementos = new List<Disco>();
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public string Top
        {
            get => top;
            set => top = value;
        }

        public List<Disco> Elementos
        {
            get => elementos;
            set => elementos = value;
        }
        
        
        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            Disco ultimoElemento = Elementos[Elementos.Count];
            Elementos.Remove(Elementos[Elementos.Count]);
            return ultimoElemento;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count()==0) {
                return true;
            } else {
                return false;
            }
        }

    }
}
