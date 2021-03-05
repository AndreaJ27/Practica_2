using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int num1, num2, sum, res, mul, div, re;

            //Operaciones
            Console.WriteLine("Ingresa un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("Suma: "+ sum);

            res = num1 - num2;
            Console.WriteLine("Resta: "+ res);

            mul = num1 * num2;
            Console.WriteLine("Multiplicacion: "+ mul);

            div = num1 / num2;
            Console.WriteLine("Division: "+ div);

            re = num1 % num2;
            Console.WriteLine("Residuo: "+ re);


            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
