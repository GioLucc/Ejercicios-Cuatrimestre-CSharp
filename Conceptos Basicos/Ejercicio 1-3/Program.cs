using System;

namespace Ejercicio_1_3_
{

    /*
     *  Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
     * Validar que el dato ingresado por el usuario sea un número.
     * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
     * Si ingresa "salir", cerrar la consola.
     * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
     */

    class Program
    {
        static void Main(string[] args)
        {
         
            Console.BackgroundColor = ConsoleColor.DarkRed;
          
            int enteredNumber;

            String action = "continuar";

            enteredNumber = 0;

            while(action != "salir")
            {
                Console.Write("Enter a number to check if it's a Prime: ");

                while(!int.TryParse(Console.ReadLine(),out enteredNumber)) // !Validación de numeros || Validación de cadena
                {
                    Console.WriteLine("ERROR! You have entered something different than a number, RE-Enter it: ");
                }

                Console.WriteLine("The entered number was: {0}", enteredNumber);

                Console.WriteLine("Si desea salir del programa escriba 'salir' o si desea continuar 'continuar' ");
                action = Console.ReadLine();
            }



           
        }
    }
}
