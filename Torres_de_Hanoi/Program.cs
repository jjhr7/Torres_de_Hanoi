using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pilas de Hanoi");
            Console.WriteLine("Introduce el numero de discos con el que quieres operar");
            
            int ndiscos = int.Parse(Console.ReadLine());



            Pila Pila1 = new Pila();
            Pila Pila2 = new Pila();
            Pila Pila3 = new Pila();

            Hanoi PilasHanoi = new Hanoi();

            int nMovimientos = PilasHanoi.iterativo(ndiscos,  Pila1,Pila2,Pila3);
            
            Console.WriteLine("El problema se ha resuelto en " + nMovimientos + " movimientos.");

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();
            
        }

    }
}
