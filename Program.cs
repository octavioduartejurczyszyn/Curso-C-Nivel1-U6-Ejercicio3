using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista
            int n, a;
            n = 1;
            while (n >= 0)
            {
            int con = 0;
                Console.WriteLine("Escriba un nro: ");
                a = int.Parse(Console.ReadLine());
                while (a > 0)
                {
                    con++;
                    Console.WriteLine("Escriba otro nro o un cero para cortar lista: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("cantidad nros: " + con);
                Console.WriteLine("Escriba otro nro o uno negativo para finalizar: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fin del programa");
        }
    }
}
