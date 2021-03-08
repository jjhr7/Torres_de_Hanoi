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
        private int top;
        //Representa el conjunto de discos que hay en la pila
        private List<Disco> elementos;
        
        //Constructor
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }
        
        //Getters y setters 
        public int Size
        {
            get => size;
            set => size = value;
        }

        public int Top
        {
            get => top;
            set => top = value;
        }

        public List<Disco> Elementos
        {
            get => elementos;
            set => elementos = value;
        }
        
        //Metodos   
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size++;
            
        }

        public Disco pop()
        {
            Disco ultimoElemento = Elementos[Size];
            Elementos.RemoveAt(Size);
            Size--;
            Top = Elementos[Size].Valor;
            return ultimoElemento;
        }                

        public bool isEmpty()
        {
            if (Size==0) {
                return true;
            } else {
                return false;
            }
        }

    }
}
