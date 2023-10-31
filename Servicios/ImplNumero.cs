using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc3.Servicios
{
    internal class ImplNumero:InterfazNumero
    {
        public int solicitudNumero()
        {
            int numero;
            do
            {
                Console.WriteLine("Introduzca un número mayor que 0: ");
               
            }while(!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

            return numero;
        }
    }
}
