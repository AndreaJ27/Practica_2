using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String nombre;
            int edad;
            

            //Operación
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            
            edad = int.Parse(Console.ReadLine());


            //Resultado
            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
