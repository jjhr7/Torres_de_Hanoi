using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        private int nMovimientos;
        private int discos;
        
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty())
            {
                b.push(a.pop());
                Console.WriteLine("Moviendo de A a B");
            }
            else if ( a.isEmpty())
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
                    a.push(b.pop());
                    Console.WriteLine("Moviendo de B a A");
                }
            }
            
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
             nMovimientos = 0;
             bool solucion = false;
             
            if (n % 2 != 0)
            {
                while (!solucion)
                {
                    comprobarSolucion(ini,fin, fin);
                    comprobarSolucion(ini, aux, fin);
                    comprobarSolucion(aux, fin, fin);
                    
                    if (fin.Size == n)
                    {
                        solucion = true;
                    }
                }
            }
            else
            {
                while (!solucion)
                {
                    comprobarSolucion(ini,aux, fin);
                    comprobarSolucion(ini, fin, fin);
                    comprobarSolucion(aux, fin, fin);

                    if (fin.Size == n)
                    {
                        solucion = true;
                    }
                }
            }

            return nMovimientos;
        }
        
        public void comprobarSolucion(Pila a, Pila b, Pila fin)
        {
            if (fin.Size < discos)
            {
                nMovimientos++;
                
                mover_disco(a, b);
            }
        }

    }
}
