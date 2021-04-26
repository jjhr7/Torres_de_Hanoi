using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
 class Hanoi
    {
        private int movimientos;
        private int discos;


        public void mover_disco(Pila a, Pila b)
        {
           
            if (b.isEmpty())
            {
                registrarMovimiento(a, b);
            }
            else if (a.isEmpty())
            {
                registrarMovimiento(b, a);

            }
            else
            {
                Disco discoA = b.lastElement();
                Disco discoB = a.lastElement();
                if(discoA.Valor < discoB.Valor)
                {
                    registrarMovimiento(b, a);
                }
                else
                {
                    registrarMovimiento(a, b);
                }
            }
           
        }

        public void registrarMovimiento(Pila a, Pila b)
        {

            Disco tmp = a.pop();
            Console.WriteLine("Se ha movido el disco: "+tmp.Valor);
            b.push(tmp);
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            movimientos = 0;
            discos = n;
            Boolean condicionSeguir = true;
            if (n % 2 != 0)
            {
                while (condicionSeguir)
                {
                    comprobacionMovimiento(ini,fin, fin);
                    comprobacionMovimiento(ini, aux, fin);
                    comprobacionMovimiento(aux, fin, fin);

                    if (fin.Size == n)
                    {
                        condicionSeguir = false;
                    }
                }
            }
            else
            {

                while (condicionSeguir)
                {
                    comprobacionMovimiento(ini, aux, fin);
                    comprobacionMovimiento(ini, fin, fin);
                    comprobacionMovimiento(aux, fin, fin);

                    if (fin.Size == n)
                    {
                        condicionSeguir = false;
                    }
                }
            }
            return movimientos;
        }

        public int algoritmoRecursivo (int n, Pila ini, Pila fin, Pila aux)
        {
            discos = n;
            movimientos = algoritmoRecursivoReal(n, ini, fin, aux);
            return movimientos;
        }

        private int algoritmoRecursivoReal(int n, Pila ini, Pila fin, Pila aux)
        {
            
            if (n == 1)
            {
                comprobacionMovimiento(ini, fin, fin);

            }
            else
            {
                algoritmoRecursivoReal(n-1, ini, aux, fin);
                comprobacionMovimiento(ini, fin, fin);
                algoritmoRecursivoReal(n-1, aux, fin, ini);
            }
            return movimientos;
        }




        private void comprobacionMovimiento(Pila a, Pila b, Pila fin)
        {
            
            if (fin.Size < discos)
            {
                movimientos++;

                mover_disco(a, b);
            }
        }
    }
}
