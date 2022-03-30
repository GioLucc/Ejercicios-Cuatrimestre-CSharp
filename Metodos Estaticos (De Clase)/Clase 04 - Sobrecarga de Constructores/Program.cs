using System;

namespace Clase_04___Sobrecarga_de_Constructores_
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing t = new Thing();

            t.EstablecerValor(5);
            t.EstablecerValor(DateTime.Now);
            t.EstablecerValor("Dumbass");

            Console.WriteLine(Thing.Mostrar(t));

            Console.ReadKey();
        }
    }
}
