using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operación 

            Console.WriteLine("Ingresa algun caracter: ");
            char c = (char)Console.Read();

            if (Char.IsLetter(c))
            {
                if(Char.IsLower(c))
                {
                    Console.WriteLine("El caracter es letra minuscula");
                } 
                
                else
                 {
                    Console.WriteLine("El caracter es letra mayscula");
                 }
             
            }

            else
             {
                Console.WriteLine("El caracter es un numero");
             }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
