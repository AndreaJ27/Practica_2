using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int precio;
            string pago;
            
            //Operación

            Console.WriteLine("Ingresa el precio del producto:");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Pagara con tarjeta o efectivo?");
            pago = Console.ReadLine().ToLower();

            if (pago.Equals("tarjeta"))
            {

                Console.WriteLine("Ingrese su numero de tarjeta:");
                int tar = int.Parse(Console.ReadLine());
                //int tar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El producto con precio $" + precio + " se a pagado con el numero de cuenta: " + tar);
            }

            else if (pago.Equals("efectivo"))
            {

                Console.WriteLine("El producto con precio $" + precio + " se ha pagado");

            }

            else
            {
                Console.WriteLine("El metodo de pago no es correcto");
            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
