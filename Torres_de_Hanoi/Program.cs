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
            Console.WriteLine("Introduzca la cantidad de discos:");
            int valorNumerico;
            String numeroDiscos = Console.ReadLine().ToString();
            while (!Int32.TryParse(numeroDiscos.ToString(), out valorNumerico) || valorNumerico<=0)
            {
                Console.WriteLine("Introduzca la cantidad de discos,el número ha de ser mayor a 0:");
                numeroDiscos = Console.ReadLine().ToString();
            }
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            
            for (int i = valorNumerico; i > 0; i--)
            {
                Disco d = new Disco();
                d.Valor = i;
                ini.push(d);
            }


            Hanoi hanoi = new Hanoi();
            Console.WriteLine("Seleccione la opcion para resolver la torre\na)Iterativo\nb)Recursivo");
            ConsoleKey tecla = Console.ReadKey().Key;
            while (tecla != ConsoleKey.A && tecla != ConsoleKey.B)
            {
                Console.WriteLine("\nSeleccione la opcion para resolver la torre\na)Iterativo\nb)Recursivo");
                tecla = Console.ReadKey().Key;
            }

            if (tecla == ConsoleKey.A)
            {
                Console.WriteLine("\nIterativo: Movimientos realizados: " + hanoi.iterativo(valorNumerico, ini, fin, aux));
            }
            else if (tecla == ConsoleKey.B)
            {
                Console.WriteLine("\nRecursivo: Movimientos realizados: " + hanoi.algoritmoRecursivo(valorNumerico, ini, fin, aux));
            }
            Console.WriteLine("Mínimo de movimientos: " + (Math.Pow(2, valorNumerico)-1) );
            Console.WriteLine("Torre Fin -> "+fin.toString());

            Console.WriteLine("Press any key to exit.");
           
            Console.ReadKey();
        }

    }
}
