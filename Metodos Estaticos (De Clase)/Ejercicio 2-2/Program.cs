using System;
using Classes_Library;

namespace Ejercicio_2_2_
{
    class Program
    {
        /* Ejercicio I02 - ¿Desea continuar?
            * Consigna
            * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
            * Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
            * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
        */
        static void Main(string[] args)
        {
            int enterANumber;
            int numbersAcumulator;
            char answer;

            numbersAcumulator = 0;

            do
            {
                Console.WriteLine("Please enter a number so we can sum it ;)!");

                while (!int.TryParse(Console.ReadLine(), out enterANumber)) // !Validación de numeros || Validación de cadena
                {
                    Console.WriteLine("ERROR! You have entered something different than a number, RE-Enter it: ");
                }

                numbersAcumulator += enterANumber;

                Console.WriteLine("Do you want to keep adding numbers? If you do press S if not whatever!");
                answer = char.Parse(Console.ReadLine());

            } while (Validator.ValidateAnswer(answer));

            Console.WriteLine("The sum of the number you have entered is: {0}!",numbersAcumulator);
            Console.ReadKey();

        }
    }
}
