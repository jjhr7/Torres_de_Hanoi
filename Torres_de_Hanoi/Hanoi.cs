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
                    a.push(b.pop());
                    Console.WriteLine("Moviendo de B a A");
                }
            }
            
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
