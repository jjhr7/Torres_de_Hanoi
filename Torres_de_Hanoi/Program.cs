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
            
            int ndiscos;
            String numeroDiscos = Console.ReadLine();
            while (!Int32.TryParse(numeroDiscos.ToString(), out ndiscos) || ndiscos<=0)
            {
                Console.WriteLine("Introduzca la cantidad de discos,el número ha de ser mayor a 0:");
                numeroDiscos = Console.ReadLine().ToString();
            }



            Pila Pila1 = new Pila();
            Pila Pila2 = new Pila();
            Pila Pila3 = new Pila();
            
            for (int i = ndiscos; i > 0; i--)
            {
                Disco d = new Disco(i);
                d.Valor = i;
                Pila1.push(d);
            }

            Hanoi PilasHanoi = new Hanoi();

            int nMovimientos = PilasHanoi.iterativo(ndiscos,  Pila1,Pila2,Pila3);
            
            Console.WriteLine("El problema se ha resuelto en " + nMovimientos + " movimientos.");

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();
            
        }

    }
}
