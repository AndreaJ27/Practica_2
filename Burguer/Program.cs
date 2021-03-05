using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int papas, guesa, soda;
            int prepapas = 20, presoda = 15, preguesa = 45;
            int total;

            //Operaciones
            Console.WriteLine("Ingrese la cantidad de hamburguesas: ");
            guesa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de papas: ");
            papas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de bebidas: ");
            soda = int.Parse(Console.ReadLine());

            total = ((prepapas * papas) + (preguesa * guesa) + (presoda * soda));

            Console.WriteLine("Su total es: " + total);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
