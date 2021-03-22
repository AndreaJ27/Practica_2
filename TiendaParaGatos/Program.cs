using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TiendaParaGatos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int latas;
            double total;


            //Mensajes
            Console.WriteLine("Bienvenido a la tienda de comida para gatos");
            Console.WriteLine("Por ingrese la cantidad de latas que llevara: ");
            latas = int.Parse(Console.ReadLine());

            //Operaciones
            if (latas <= 49)
            {
                total = latas * 2;
                Console.WriteLine("Su total es: $" + total);

            }
            else if (latas >= 50 && latas <= 99)
            {
                total = latas * 1.75;
                Console.WriteLine("Su total ya con descuento es: $" + total);

            }
            else if (latas >= 100)
            {
                total = latas * 1.50;
                Console.WriteLine("Su total ya con descuento es: $" + total);
            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
