using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        
        public void mover_disco(Pila a, Pila b)
        {
            if (!a.isEmpty() && b.isEmpty())
            {
                b.push(a.pop());
                Console.WriteLine("Moviendo de A a B");
            }
            else if (!b.isEmpty() && a.isEmpty())
            {
                a.push(b.pop());
                Console.WriteLine("Moviendo de B a A");
            }
            else 
            {
                if (a.Top < b.Top)
                {
                    b.push(a.pop());
                    Console.WriteLine("Moviendo de A a B");
                }
                else
                {
                    Console.WriteLine("Tamaño de la pila A: "+a.Size);
                    a.push(b.pop());
                    Console.WriteLine("Moviendo de B a A");
                }
            }
            
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int nmovimientos = 0;
            bool solucion = false;

            for (int i = n; i > 0; i--)
            {
                Disco nuevoDisco = new Disco(i);
                ini.push(nuevoDisco);

            }
            
            if (n % 2 == 0)
            {
                while (!solucion)
                {
                    mover_disco(ini,fin);
                    nmovimientos++;
                    
                    mover_disco(ini, aux);
                    nmovimientos++;
                    
                    mover_disco(aux, fin);
                    nmovimientos++;

                    solucion = comprobarSolucion(fin);
                }
            }
            else
            {
                while (!solucion)
                {
                    mover_disco(ini,aux);
                    nmovimientos++;
                    
                    mover_disco(ini, fin);
                    nmovimientos++;
                    
                    mover_disco(aux, fin);
                    nmovimientos++;

                    solucion = comprobarSolucion(fin);
                }
            }

            return nmovimientos;
        }
        
        public bool comprobarSolucion(Pila pila)
        {
            bool solucion = true;

            for (int i = pila.Size; i > 0 && solucion  ;i--)
            {
                if (pila.Elementos[i].Valor > pila.Elementos[i - 1].Valor)
                {
                    solucion = false;
                }
            }
            
            return solucion;
        }

    }
}
