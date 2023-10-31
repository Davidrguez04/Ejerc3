using Ejerc3.Servicios;

namespace Ejerc3.Controladores
{
    /*Escribe un programa que solicite un número entero mayor que 0 al usuario, lo lea de la consola y muestre 
     * por pantalla la siguiente ejecución.
    Por ejemplo, supongamos que el número es 4, entonces:
    1
    12
    123
    1234
    El método que solicite el número deberá estar definido en un servicio. El método mostrará el mensaje de petición 
    de número, recogerá el número escrito en la consola y lo devolverá al método main.
    El método se encargue de la ejecución para mostrar por pantalla el patrón indicado también irá en un servicio.*/
    class Program
    {
        static void Main(string[] args)
        {
            InterfazNumero ni=new ImplNumero();
            InterfazEjecucion mi=new ImplEjecucion();

            int num=ni.solicitudNumero();

            mi.calculoNum(num);


        }
    }
}
