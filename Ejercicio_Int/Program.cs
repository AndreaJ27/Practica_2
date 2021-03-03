using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.-Declarar 3 variables de tipo INT y asignarles valores estaticos

            int numero_1 = 5;
            int numero_2 = 20;
            int numero_3 = 10;

            //2.-Crear una variables de tipo INT la cual guardara la SUMA de las 3 variables anteriores

            int suma = numero_1 + numero_2 + numero_3;

            //3.-Mostrar en pantalla el valor de SUMA "El valor de Suma es: "

            Console.WriteLine("El valir de la Suma es: " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            
        }
    }
}
